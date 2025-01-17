﻿using HoneybeeSchema.Energy;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HB = HoneybeeSchema;
using HBEng = HoneybeeSchema.Energy;

namespace HoneybeeSchema.Helper
{
    public static partial class EnergyLibrary
    {
        /// <summary>
        /// This will return the top main folder path of where ladybug_tools is. Use HoneybeeSchema.Pathes.LadybugToolsRootFolder instead.
        /// </summary>
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string LadybugToolsRootFolder => Pathes.LadybugToolsRootFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string ResourcesStandardsFolder => Pathes.ResourcesStandardsFolder;
        /// <summary>
        /// This returns ladybug_tools/resources/standards/honeybee_standards.
        /// </summary>
        ///   [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string DefaultStandardsFolder => Pathes.DefaultStandardsFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        private static List<string> _DefaultLibJsons => Pathes._DefaultLibJsons;



        #region Honeybee OpenStudio Standards

        //honeybee_energy_standards
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string EnergyStandardsFolder => Pathes.EnergyStandardsFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string BuildingVintagesFolder => Pathes.BuildingVintagesFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string BuildingProgramTypesFolder => Pathes.BuildingProgramTypesFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string ConstructionsFolder => Pathes.ConstructionsFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string ConstructionSetFolder => Pathes.ConstructionSetFolder;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static string ScheduleFolder => Pathes.ScheduleFolder;
        private static ModelEnergyProperties _standardEnergyLibrary;
        public static ModelEnergyProperties StandardEnergyLibrary
        {
            get
            {
                if (_standardEnergyLibrary == null)
                {
                    var eng = new ModelEnergyProperties();
                    eng.AddMaterials(StandardsOpaqueMaterials.Values);
                    eng.AddMaterials(StandardsWindowMaterials.Values);
                    eng.AddConstructions(StandardsOpaqueConstructions.Values);
                    eng.AddConstructions(StandardsWindowConstructions.Values);
                    eng.AddConstructionSets(StandardsConstructionSets.Values);
                    eng.AddProgramTypes(StandardsProgramTypes.Values);
                    eng.AddSchedules(StandardsSchedules.Values);
                    _standardEnergyLibrary = eng;
                }
                return _standardEnergyLibrary;
            }
        }
        
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static IEnumerable<string> BuildingVintages => Pathes.BuildingVintages;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static IEnumerable<string> BuildingTypeJsonFilePaths => Pathes.BuildingTypeJsonFilePaths;
        [Obsolete("This is deprecated. This has been moved to HoneybeeSchema.Pathes", false)]
        public static IEnumerable<string> ConstructionsetJsonFilePaths => Pathes.ConstructionsetJsonFilePaths;

        // "2013::MediumOffice::OpenOffice"
        public static (ProgramTypeAbridged programType, IEnumerable<ScheduleRulesetAbridged> schedules) GetStandardProgramTypeByIdentifier(string standardProgramType)
        {
            var year = standardProgramType.Split(':').First();
            if (string.IsNullOrEmpty(year))
                throw new ArgumentException($"Invalid {standardProgramType}");


            var found = StandardsProgramTypes.TryGetValue(standardProgramType, out ProgramTypeAbridged programType);
            if (!found)
                throw new ArgumentException($"Cannot find {standardProgramType}");

            var scheduleNames = programType.GetAllSchedules();
            var sches = scheduleNames.Select(_ => StandardsSchedules[_]).ToList();
            return (programType, sches);

        }

        // "2004::ClimateZone1::SteelFramed"
        public static (ConstructionSetAbridged constructionSet, IEnumerable<IConstruction> constructions, IEnumerable<IMaterial> materials) GetStandardConstructionSetByIdentifier(string standardConstructionSet)
        {
            var resources = GetResourcesByStandardConstructionSetIdentifier(standardConstructionSet);
            var cSet = resources.ConstructionSets.OfType<ConstructionSetAbridged>().FirstOrDefault();
            var constructions = resources.ConstructionList;
            var materials = resources.MaterialList;
            return (cSet, constructions, materials);

        }
        public static ModelEnergyProperties GetResourcesByStandardConstructionSetIdentifier(string standardConstructionSet)
        {
            var year = standardConstructionSet.Split(':').First();
            if (string.IsNullOrEmpty(year))
                throw new ArgumentException($"Invalid {standardConstructionSet}");

            var found = StandardsConstructionSets.TryGetValue(standardConstructionSet, out ConstructionSetAbridged cSet);
            if (!found)
                throw new ArgumentException($"Cannot find {standardConstructionSet}");

            // get constructions
            var cNames = cSet.GetAllConstructions();

            var constructions = cNames.Select(_ =>
            {
                IConstruction con = null;
                if (StandardsOpaqueConstructions.TryGetValue(_, out var opaque))
                    con = opaque;
                else if (StandardsWindowConstructions.TryGetValue(_, out var window))
                    con = window;
                //TODO: Shade, AirBoundary, WindowDynamic
                return con;
            });

            var materials = constructions
                .SelectMany(_ => _.GetAbridgedConstructionMaterials())
                .Select(_ =>
                {
                    IMaterial mat = null;
                    if (StandardsOpaqueMaterials.TryGetValue(_, out var opaque))
                        mat = opaque;
                    else if (StandardsWindowMaterials.TryGetValue(_, out var window))
                        mat = window;
                    return mat;
                });

            var res = new ModelEnergyProperties();
            res.AddConstructionSet(cSet);
            res.AddConstructions(constructions);
            res.AddMaterials(materials);

            return res;

        }

        // "2004::ClimateZone1::SteelFramed"
        private static Dictionary<string, HB.ConstructionSetAbridged> _standardsConstructionSets;
        public static Dictionary<string, HB.ConstructionSetAbridged> StandardsConstructionSets
        {
            get
            {
                if (_standardsConstructionSets == null)
                {
                    //Load from Json 
                    var dic = new Dictionary<string, HB.ConstructionSetAbridged>();
                    foreach (var jsonFile in ConstructionsetJsonFilePaths)
                    {
                        var constructionSets = LoadLibrary(jsonFile, HB.ConstructionSetAbridged.FromJson);
                        dic = dic.Concat(constructionSets.ToDictionary(_ => _.Identifier, _ => _)).ToDictionary(_ => _.Key, _ => _.Value);
                    }
                    _standardsConstructionSets = dic;
                }
                return _standardsConstructionSets;
            }
        }

        //Constructions  load from honeybee\honeybee_energy_standards\data\constructions\window_construction.json
        private static Dictionary<string, HB.WindowConstructionAbridged> _standardsWindowConstructions;
        public static Dictionary<string, HB.WindowConstructionAbridged> StandardsWindowConstructions
        {
            get
            {
                if (_standardsWindowConstructions == null)
                {
                    var contrs = LoadLibrary(Path.Combine(ConstructionsFolder, "window_construction.json"), HB.WindowConstructionAbridged.FromJson);
                    _standardsWindowConstructions = contrs.ToDictionary(_ => _.Identifier, _ => _);
                }
                return _standardsWindowConstructions;
            }
        }


        //load from honeybee\honeybee_energy_standards\data\constructions\opaque_construction.json
        private static Dictionary<string, HB.OpaqueConstructionAbridged> _standardsOpaqueConstructions;
        public static Dictionary<string, HB.OpaqueConstructionAbridged> StandardsOpaqueConstructions
        {
            get
            {

                if (_standardsOpaqueConstructions == null)
                {
                    var opaques = LoadLibrary(Path.Combine(ConstructionsFolder, "opaque_construction.json"), HB.OpaqueConstructionAbridged.FromJson);
                    _standardsOpaqueConstructions = opaques.ToDictionary(_ => _.Identifier, _ => _);
                }
                return _standardsOpaqueConstructions;
            }
        }


        // "2013::MediumOffice::OpenOffice"
        private static Dictionary<string, HB.ProgramTypeAbridged> _standardsProgramTypes;
        public static Dictionary<string, HB.ProgramTypeAbridged> StandardsProgramTypes
        {
            get
            {
                if (_standardsProgramTypes == null)
                {
                    //Load from Json 
                    var dic = new Dictionary<string, HB.ProgramTypeAbridged>();
                    foreach (var jsonFile in BuildingTypeJsonFilePaths)
                    {
                        var programTypes = LoadLibrary(jsonFile, HB.ProgramTypeAbridged.FromJson);
                        dic = dic.Concat(programTypes.ToDictionary(_ => _.Identifier, _ => _)).ToDictionary(_ => _.Key, _ => _.Value);
                    }
                    _standardsProgramTypes = dic;
                }
                return _standardsProgramTypes;
            }
        }


        //Window Materials 
        //                  load from honeybee\honeybee_energy_standards\data\constructions\window_material.json
        private static Dictionary<string, HBEng.IMaterial> _standardsWindowMaterials;
        public static Dictionary<string, HBEng.IMaterial> StandardsWindowMaterials
        {

            get
            {
                if (_standardsWindowMaterials == null)
                {
                    var wins = LoadWindowMaterials(Path.Combine(ConstructionsFolder, "window_material.json"));
                    _standardsWindowMaterials = wins.ToDictionary(_ => _.Identifier, _ => _);
                }
                return _standardsWindowMaterials;
            }
        }




        //                 load from honeybee\honeybee_energy_standards\data\constructions\opaque_material.json
        private static Dictionary<string, HBEng.IMaterial> _standardsOpaqueMaterials;
        public static Dictionary<string, HBEng.IMaterial> StandardsOpaqueMaterials
        {
            get
            {
                if (_standardsOpaqueMaterials == null)
                {
                    var opaMaterils = LoadOpqueMaterials(Path.Combine(ConstructionsFolder, "opaque_material.json"));
                    _standardsOpaqueMaterials = opaMaterils.ToDictionary(_ => _.Identifier, _ => _);
                }
                return _standardsOpaqueMaterials;

            }
        }


        //Schedules
        private static Dictionary<string, HB.ScheduleRulesetAbridged> _standardsSchedules;
        public static Dictionary<string, HB.ScheduleRulesetAbridged> StandardsSchedules
        {
            get
            {
                if (_standardsSchedules == null)
                {
                    var sches = LoadLibraryParallel(Path.Combine(ScheduleFolder, "schedule.json"), HB.ScheduleRulesetAbridged.FromJson);
                    _standardsSchedules = sches.ToDictionary(_ => _.Identifier, _ => _);
                }
                return _standardsSchedules;
            }
        }

        // end of Honeybee OpenStudio Standards
        #endregion

      

        #region Honeybee Default Standards

        //Default Model Energy Property
        private static HB.ModelEnergyProperties _defaultModelEnergyProperty;
        public static HB.ModelEnergyProperties DefaultModelEnergyProperties
        {
            get
            {
                if (_defaultModelEnergyProperty == null)
                {
                    // Load from local ladybug_tools folder
                    if (File.Exists(_DefaultLibJsons[0]))
                    {
                        _defaultModelEnergyProperty = LoadHoneybeeObject(_DefaultLibJsons[0], HB.ModelEnergyProperties.FromJson);
                    }
                    else
                    {
                        // Download from URL
                        var file = Path.Combine(Path.GetTempPath(), "energy_default.json");
                        var url = @"https://raw.githubusercontent.com/ladybug-tools/honeybee-standards/master/honeybee_standards/energy_default.json";
                        DownLoadLibrary(url, file);
                        _defaultModelEnergyProperty = LoadHoneybeeObject(file, HB.ModelEnergyProperties.FromJson);

                    }

                    // add default HVACs to loaded energy_default
                    if (_defaultModelEnergyProperty.Hvacs == null)
                    {
                        _defaultModelEnergyProperty.AddHVACs(DefaultHVACs.ToList());
                    }
                    
                }

                return _defaultModelEnergyProperty;
            }
        }
        //Default Model Radiance Property
        private static HB.ModelRadianceProperties _defaultModelRadianceProperty;
        public static HB.ModelRadianceProperties DefaultModelRadianceProperties
        {
            get
            {
                if (_defaultModelRadianceProperty == null)
                {
                    // Load from local ladybug_tools folder
                    if (File.Exists(_DefaultLibJsons[0]))
                    {
                        _defaultModelRadianceProperty = LoadHoneybeeObject(_DefaultLibJsons[1], HB.ModelRadianceProperties.FromJson);
                    }
                    else
                    {
                        // Download from URL
                        var file = Path.Combine(Path.GetTempPath(), "radiance_default.json");
                        var url = @"https://raw.githubusercontent.com/ladybug-tools/honeybee-standards/master/honeybee_standards/radiance_default.json";
                        DownLoadLibrary(url, file);
                        _defaultModelRadianceProperty = LoadHoneybeeObject(file, HB.ModelRadianceProperties.FromJson);

                    }

                }

                return _defaultModelRadianceProperty;
            }
        }

        //ConstructionSets
        private static IEnumerable<HB.ConstructionSetAbridged> _defaultConstructionSets;
        public static IEnumerable<HB.ConstructionSetAbridged> DefaultConstructionSets
        {
            get
            {
                _defaultConstructionSets = _defaultConstructionSets ?? DefaultModelEnergyProperties.ConstructionSets.OfType<HB.ConstructionSetAbridged>();
                return _defaultConstructionSets;
            }

        }

        //DefaultMaterials
        private static IEnumerable<HB.Energy.IMaterial> _defaultMaterials;
        /// <summary>
        /// All default materials including opaque and window materials.
        /// </summary>
        public static IEnumerable<HB.Energy.IMaterial> DefaultMaterials
        {
            get
            {
                _defaultMaterials = _defaultMaterials ?? DefaultModelEnergyProperties.Materials.OfType<HB.Energy.IMaterial>();
                return _defaultMaterials;
            }
        }

        //DefaultOpaqueMaterials
        private static IEnumerable<HB.Energy.IMaterial> _defaultOpaqueMaterials;
        public static IEnumerable<HB.Energy.IMaterial> DefaultOpaqueMaterials
        {
            get
            {
                _defaultOpaqueMaterials = 
                    _defaultOpaqueMaterials ?? 
                    DefaultModelEnergyProperties.Materials.Where(_ => _ is HB.EnergyMaterial || _ is HB.EnergyMaterialNoMass)
                    .OfType<HB.Energy.IMaterial>(); 

                return _defaultOpaqueMaterials;
            }
        }

        //DefaultMaterials
        private static IEnumerable<HB.Energy.IMaterial> _defaultWindowMaterials;
        public static IEnumerable<HB.Energy.IMaterial> DefaultWindowMaterials
        {
            get
            {
                _defaultWindowMaterials =
                    _defaultWindowMaterials ??
                    DefaultModelEnergyProperties.Materials.Where(_ => _.GetType().Name.StartsWith("EnergyWindowMaterial"))
                    .OfType<HB.Energy.IMaterial>();

                return _defaultWindowMaterials;
            }
        }

        //DefaultConstructions
        private static IEnumerable<HB.Energy.IConstruction> _defaultConstructions;
        public static IEnumerable<HB.Energy.IConstruction> DefaultConstructions
        {
            get
            {
                _defaultConstructions = _defaultConstructions ?? DefaultModelEnergyProperties.Constructions.OfType<HB.Energy.IConstruction>();
                return _defaultConstructions;
            }
        }

        //ProgramTypes
        private static IEnumerable<HB.ProgramTypeAbridged> _defaultProgramTypes;
        public static IEnumerable<HB.ProgramTypeAbridged> DefaultProgramTypes
        {
            get
            {
                _defaultProgramTypes = _defaultProgramTypes ?? DefaultModelEnergyProperties.ProgramTypes.OfType<HB.ProgramTypeAbridged>();
                return _defaultProgramTypes;
            }
        }

        //Service hot water
        private static IEnumerable<HB.ServiceHotWaterAbridged> _serviceHotWaterLoads;
        public static IEnumerable<HB.ServiceHotWaterAbridged> DefaultServiceHotWaterLoads
        {
            get
            { 
                if (_serviceHotWaterLoads == null)
                {
                    var items = DefaultProgramTypes.Select(_ => _?.ServiceHotWater).Where(_ => _ != null).ToList();
                    foreach (var item in items)
                    {
                        item.DisplayName = $"{item.Identifier} ({item.FlowPerArea} L/h-m2)";
                    }
                    _serviceHotWaterLoads = items;
                }
                return _serviceHotWaterLoads;
            }
        }

        //HVACs
        private static IEnumerable<HB.Energy.IHvac> _defaultHVACs;
        public static IEnumerable<HB.Energy.IHvac> DefaultHVACs 
        {
            get
            {
                
                _defaultHVACs = _defaultHVACs?? DefaultModelEnergyProperties.Hvacs?.OfType<HB.Energy.IHvac>();
                if (_defaultHVACs == null)
                {
                    _defaultHVACs = new List<IHvac>() { new IdealAirSystemAbridged(Guid.NewGuid().ToString(), "Ideal Air System") };
                }
                return _defaultHVACs;
            }
        
        }
            

        //People load
        private static IEnumerable<HB.PeopleAbridged> _defaultPeopleLoads;
        public static IEnumerable<HB.PeopleAbridged> DefaultPeopleLoads
        {
            get
            {
                if (_defaultPeopleLoads == null)
                {
                    var peopleList = DefaultProgramTypes.Select(_ => _?.People).Where(_ => _ != null).ToList();
                    foreach (var item in peopleList)
                    {
                        item.DisplayName = $"{item.Identifier} ({Math.Round(item.PeoplePerArea * 100, 1)} ppl/100m2)";
                    }
                    //peopleList.Add(
                    //    new PeopleAbridged(
                    //        Guid.NewGuid().ToString(),
                    //        0.5381957525591208,
                    //        "Generic Office Occupancy",
                    //        "Generic Office Activity",
                    //        "Office Comference People (53.8 ppl/100m2)"
                    //        )
                    //    );
                    _defaultPeopleLoads = peopleList;
                }
                return _defaultPeopleLoads;
            }
        }


        //Lighting load
        private static IEnumerable<HB.LightingAbridged> _defaultLightingLoads;
        public static IEnumerable<HB.LightingAbridged> DefaultLightingLoads
        {
            get
            {
                if (_defaultLightingLoads == null)
                {
                    var items = DefaultProgramTypes.Select(_ => _?.Lighting).Where(_ => _ != null).ToList();
                    foreach (var item in items)
                    {
                        item.DisplayName = $"{item.Identifier} ({item.WattsPerArea} W/m2)";
                    }
                    _defaultLightingLoads = items;
                }
                return _defaultLightingLoads;
            }
        }

        //ElecEqp load
        private static IEnumerable<HB.ElectricEquipmentAbridged> _defaultElectricEquipmentLoads;
        public static IEnumerable<HB.ElectricEquipmentAbridged> DefaultElectricEquipmentLoads
        {
            get
            {
                if (_defaultElectricEquipmentLoads == null)
                {
                    var items = DefaultProgramTypes.Select(_ => _?.ElectricEquipment).Where(_ => _ != null).ToList();
                    foreach (var item in items)
                    {
                        item.DisplayName = $"{item.Identifier} ({item.WattsPerArea} W/m2)";
                    }
                    _defaultElectricEquipmentLoads = items;
                }
                return _defaultElectricEquipmentLoads;
            }
        }

        //GasEqp load
        private static IEnumerable<HB.GasEquipmentAbridged> _defaultGasEquipmentLoads;
        public static IEnumerable<HB.GasEquipmentAbridged> GasEquipmentLoads
        {
            get
            {
                if (_defaultGasEquipmentLoads == null)
                {
                    var items = DefaultProgramTypes.Select(_ => _?.GasEquipment).Where(_ => _ != null).ToList();
                    foreach (var item in items)
                    {
                        item.DisplayName = $"{item.Identifier} ({item.WattsPerArea} W/m2)";
                    }
                    _defaultGasEquipmentLoads = items;
                }
                return _defaultGasEquipmentLoads;
            }
        }

        //GasEqp load
        private static IEnumerable<HB.InfiltrationAbridged> _defaultInfiltrationLoads;
        public static IEnumerable<HB.InfiltrationAbridged> DefaultInfiltrationLoads
        {
            get
            {
                if (_defaultInfiltrationLoads == null)
                {
                    var items = new List<InfiltrationAbridged>()
                    {
                        new InfiltrationAbridged("Passive house", 0.000071, "Generic Office Infiltration"),
                        new InfiltrationAbridged("Tight building", 0.0001, "Generic Office Infiltration"),
                        new InfiltrationAbridged("ASHRAE 2013", 0.000285, "Generic Office Infiltration"),
                        new InfiltrationAbridged("Generic Office", 0.0002266, "Generic Office Infiltration"),
                        new InfiltrationAbridged("Average building", 0.0003, "Generic Office Infiltration"),
                        new InfiltrationAbridged("Leaky building", 0.0006, "Generic Office Infiltration")

                    };

                    foreach (var item in items)
                    {
                        item.DisplayName = $"{item.Identifier} ({item.FlowPerExteriorArea} m3/s per m2 facade @4Pa)";
                    }
                    _defaultInfiltrationLoads = items;
                }
                return _defaultInfiltrationLoads;
            }
        }

        //Ventilation load
        private static IEnumerable<HB.VentilationAbridged> _defaultVentilationLoads;
        public static IEnumerable<HB.VentilationAbridged> DefaultVentilationLoads
        {
            get
            {
                if (_defaultVentilationLoads == null)
                {
                    var items = DefaultProgramTypes.Select(_ => _.Ventilation).Where(_ => _ != null).ToList();
                    foreach (var item in items)
                    {
                        item.DisplayName = $"{item.Identifier} ({item.FlowPerArea} m3/s per m2 floor)";
                    }
                    _defaultVentilationLoads = items;
                }
                return _defaultVentilationLoads;
            }
        }

        //Setpoints
        private static IEnumerable<HB.SetpointAbridged> _defaultSetpoints;
        public static IEnumerable<HB.SetpointAbridged> DefaultSetpoints
        {
            get
            {
                _defaultSetpoints = _defaultSetpoints ?? DefaultProgramTypes.Select(_ => _.Setpoint).Where(_ => _ != null);
                return _defaultSetpoints;
            }
        }

        //DefaultScheduleTypeLimit
        private static IEnumerable<HB.ScheduleTypeLimit> _defaultScheduleTypeLimit;
        public static IEnumerable<HB.ScheduleTypeLimit> DefaultScheduleTypeLimit
        {
            get
            {
                _defaultScheduleTypeLimit = _defaultScheduleTypeLimit ?? DefaultModelEnergyProperties.ScheduleTypeLimits;
                return _defaultScheduleTypeLimit;
            }
        }


        //DefaultScheduleRuleset
        private static IEnumerable<HB.ScheduleRulesetAbridged> _defaultScheduleRuleset;
        public static IEnumerable<HB.ScheduleRulesetAbridged> DefaultScheduleRuleset
        {
            get
            {
                _defaultScheduleRuleset = _defaultScheduleRuleset ?? DefaultModelEnergyProperties.Schedules.OfType<HB.ScheduleRulesetAbridged>();
                return _defaultScheduleRuleset;
            }
        }


        #endregion



        #region Utilities
        public static string DownLoadLibrary(string standardsUrl, string saveAsfileName)
        {
            var url = standardsUrl;
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                Directory.CreateDirectory(DefaultStandardsFolder);
                var file = Path.Combine(DefaultStandardsFolder, saveAsfileName);
                wc.DownloadFile(url, file);
                return file;
            }
        }



        public static IEnumerable<T> LoadLibrary<T>(string jsonFile, Func<string, T> func)
        {

            if (!File.Exists(jsonFile))
                throw new ArgumentException($"Invalid file: {jsonFile}");

            using (var file = File.OpenText(jsonFile))
            using (var reader = new JsonTextReader(file))
            {
                var jObjs = JToken.ReadFrom(reader);
                var libItems = jObjs.Values();

                var hbObjs = libItems.Select(_ => func(_.ToString()));
                return hbObjs;
            }

        }

        public static T LoadHoneybeeObject<T>(string jsonFile, Func<string, T> func)
        {

            if (!File.Exists(jsonFile))
                throw new ArgumentException($"Invalid file: {jsonFile}");

            var text = File.ReadAllText(jsonFile);
            T hbObjs = func(text);
            return hbObjs;
          

        }

        public static IEnumerable<T> LoadLibraryParallel<T>(string jsonFile, Func<string, T> func)
        {

            if (!File.Exists(jsonFile))
                throw new ArgumentException($"Invalid file: {jsonFile}");


            var text = File.ReadAllText(jsonFile);
            using (var file = File.OpenText(jsonFile))
            using (var reader = new JsonTextReader(file))
            {
                var jObjs = JToken.ReadFrom(reader);
                var libItems = jObjs.Values();

                var hbObjs = libItems.AsParallel().Select(_ => func(_.ToString()));
                return hbObjs;
            }

        }


        public static Dictionary<string, IEnumerable<string>> LoadBuildingVintage(string buildingVintageFile)
        {
            var vintageJson = Path.Combine(BuildingVintagesFolder, buildingVintageFile);

            if (!File.Exists(vintageJson))
                throw new ArgumentException($"{vintageJson} doesn't exist");

            var vintageDic = new Dictionary<string, IEnumerable<string>>();
            using (var file = File.OpenText(vintageJson))
            using (var reader = new JsonTextReader(file))
            {
                var jObjs = JObject.Load(reader);

                var buildingTypes = jObjs.Children<JProperty>();
                foreach (var item in buildingTypes)
                {
                    var name = item.Name;
                    var spaceTypes = item.Value.Select(_ => _.ToString());
                    vintageDic.Add(name, spaceTypes);

                }

            }

            return vintageDic;


        }


        public static List<HBEng.IMaterial> LoadWindowMaterials(string windowMaterialJsonFile)
        {
            var jsonFile = windowMaterialJsonFile;
            if (!File.Exists(jsonFile))
                throw new ArgumentException($"Invalid file: {jsonFile}");

            var materials = new List<HBEng.IMaterial>();


            using (var file = File.OpenText(jsonFile))
            using (var reader = new JsonTextReader(file))
            {
                var jObjs = JToken.ReadFrom(reader);
                var libItems = jObjs.Values();
                foreach (var item in libItems)
                {
                    var typeName = item.Value<string>("type");
                    switch (typeName)
                    {
                        case nameof(HB.EnergyWindowMaterialBlind):
                            materials.Add(HB.EnergyWindowMaterialBlind.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyWindowMaterialGas):
                            materials.Add(HB.EnergyWindowMaterialGas.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyWindowMaterialGasCustom):
                            materials.Add(HB.EnergyWindowMaterialGasCustom.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyWindowMaterialGasMixture):
                            materials.Add(HB.EnergyWindowMaterialGasMixture.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyWindowMaterialGlazing):
                            materials.Add(HB.EnergyWindowMaterialGlazing.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyWindowMaterialShade):
                            materials.Add(HB.EnergyWindowMaterialShade.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyWindowMaterialSimpleGlazSys):
                            materials.Add(HB.EnergyWindowMaterialSimpleGlazSys.FromJson(item.ToString()));
                            break;
                        default:
                            throw new ArgumentException($"{typeName} is not supported, please report this message to developers.");
                            //break;
                    }
                }

                return materials;
            }
        }

        public static List<HBEng.IMaterial> LoadOpqueMaterials(string opaqueMaterialJsonFile)
        {
            var jsonFile = opaqueMaterialJsonFile;
            if (!File.Exists(jsonFile))
                throw new ArgumentException($"Invalid file: {jsonFile}");

            var materials = new List<HBEng.IMaterial>();

            using (var file = File.OpenText(jsonFile))
            using (var reader = new JsonTextReader(file))
            {
                var jObjs = JToken.ReadFrom(reader);
                var libItems = jObjs.Values();
                foreach (var item in libItems)
                {
                    var typeName = item.Value<string>("type");
                    switch (typeName)
                    {
                        case nameof(HB.EnergyMaterial):
                            materials.Add(HB.EnergyMaterial.FromJson(item.ToString()));
                            break;
                        case nameof(HB.EnergyMaterialNoMass):
                            materials.Add(HB.EnergyMaterialNoMass.FromJson(item.ToString()));
                            break;
                        default:
                            throw new ArgumentException($"{typeName} is not supported, please report this message to developers.");
                            //break;
                    }
                }

                return materials;
            }
        }

        public static HB.Energy.IBuildingConstructionset GetConstructionSetByIdentifier(string identifier)
        {
            // TODO: change it to all construction set collection bucket
            var lib = EnergyLibrary.DefaultConstructionSets;
            var obj = lib.FirstOrDefault(_ => _.Identifier == identifier);
            if (obj == null)
                throw new ArgumentNullException($"Failed to find the construction set {identifier}");
            return obj;
        }

        public static HB.Energy.IProgramtype GetProgramTypeByIdentifier(string identifier)
        {
            // TODO: change it to all program type collection bucket
            var lib = EnergyLibrary.DefaultProgramTypes;
            var obj = lib.FirstOrDefault(_ => _.Identifier == identifier);
            if (obj == null)
                throw new ArgumentNullException($"Failed to find the program type {identifier}");
            return obj;
        }

        public static HB.Energy.IHvac GetHVACByIdentifier(string identifier)
        {
            // TODO: change it to all hvacs collection bucket
            var lib = EnergyLibrary.DefaultHVACs;
            var obj = lib.FirstOrDefault(_ => _.Identifier == identifier);
            if (obj == null)
                throw new ArgumentNullException($"Failed to find the program type {identifier}");
            return obj;
        }

        public static HB.OpaqueConstructionAbridged GetOpaqueConstructionByIdentifier(string identifier)
        {
            var found = EnergyLibrary.StandardsOpaqueConstructions.TryGetValue(identifier, out OpaqueConstructionAbridged opaque);
            if (!found)
                throw new ArgumentNullException($"Failed to find the opaque construction {identifier}");
            return opaque;
        }
        public static HB.WindowConstructionAbridged GetWindowConstructionByIdentifier(string identifier)
        {
            var found = EnergyLibrary.StandardsWindowConstructions.TryGetValue(identifier, out WindowConstructionAbridged win);
            if (!found)
                throw new ArgumentNullException($"Failed to find the window construction {identifier}");
            return win;
        }
        public static HB.ShadeConstruction GetShadeConstructionByIdentifier(string identifier)
        {
            throw new ArgumentNullException($"Failed to find the shade constructions {identifier}");
            //var lib = EnergyLibrary.;
            //var obj = lib.FirstOrDefault(_ => _.Name == name);
            //if (obj == null)
            //    throw new ArgumentNullException($"Failed to find the window construction {name}");
            //return obj;
        }
        public static HBEng.IMaterial GetOpaqueMaterialByIdentifier(string identifier)
        {
            var found = EnergyLibrary.StandardsOpaqueMaterials.TryGetValue(identifier, out IMaterial material);
            if (!found)
                throw new ArgumentNullException($"Failed to find the opaque material {identifier}");
            return material;
        }
        public static HBEng.IMaterial GetWindowMaterialByIdentifier(string identifier)
        {
            var found = EnergyLibrary.StandardsWindowMaterials.TryGetValue(identifier, out IMaterial material);
            if (!found)
                throw new ArgumentNullException($"Failed to find the opaque material {identifier}");
            return material;
        }

        public static List<HBEng.IMaterial> GetConstructionMaterials(HB.OpaqueConstructionAbridged construction)
        {
            return construction.Materials.Select(_ => GetOpaqueMaterialByIdentifier(_)).ToList();
        }
        public static List<HBEng.IMaterial> GetConstructionMaterials(HB.WindowConstructionAbridged construction)
        {
            return construction.Materials.Select(_ => GetWindowMaterialByIdentifier(_)).ToList();
        }

#endregion

    }

}
