[![Build](https://github.com/ladybug-tools/honeybee-schema-dotnet/workflows/CD/badge.svg)](https://github.com/ladybug-tools/honeybee-schema-dotnet/actions) [![NuGet Version and Downloads count](https://buildstats.info/nuget/HoneybeeSchema?dWidth=50)](https://www.nuget.org/packages/HoneybeeSchema)

# HoneybeeSchema - the C# library for the Honeybee Model Schema

Documentation for Honeybee model schema

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.48.2
- SDK version: 1.48.2
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/honeybee-schema](https://github.com/ladybug-tools/honeybee-schema)

## Frameworks supported


- .NET Core >=1.0
- .NET Framework >=4.5

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using HoneybeeSchema.Api;
using HoneybeeSchema.Client;
using HoneybeeSchema.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out HoneybeeSchema.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HoneybeeSchema.Api;
using HoneybeeSchema.Client;
using HoneybeeSchema.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------


## Documentation for Models

 - [Model.AFNCrack](docs/AFNCrack.md)
 - [Model.AFNCrackAllOf](docs/AFNCrackAllOf.md)
 - [Model.Adiabatic](docs/Adiabatic.md)
 - [Model.AdiabaticAllOf](docs/AdiabaticAllOf.md)
 - [Model.AirBoundaryConstruction](docs/AirBoundaryConstruction.md)
 - [Model.AirBoundaryConstructionAbridged](docs/AirBoundaryConstructionAbridged.md)
 - [Model.AirBoundaryConstructionAbridgedAllOf](docs/AirBoundaryConstructionAbridgedAllOf.md)
 - [Model.AirBoundaryConstructionAllOf](docs/AirBoundaryConstructionAllOf.md)
 - [Model.AllAirBase](docs/AllAirBase.md)
 - [Model.AllAirBaseAllOf](docs/AllAirBaseAllOf.md)
 - [Model.AllAirEconomizerType](docs/AllAirEconomizerType.md)
 - [Model.Aperture](docs/Aperture.md)
 - [Model.ApertureAllOf](docs/ApertureAllOf.md)
 - [Model.ApertureConstructionSet](docs/ApertureConstructionSet.md)
 - [Model.ApertureConstructionSetAbridged](docs/ApertureConstructionSetAbridged.md)
 - [Model.ApertureConstructionSetAbridgedAllOf](docs/ApertureConstructionSetAbridgedAllOf.md)
 - [Model.ApertureConstructionSetAllOf](docs/ApertureConstructionSetAllOf.md)
 - [Model.ApertureEnergyPropertiesAbridged](docs/ApertureEnergyPropertiesAbridged.md)
 - [Model.ApertureEnergyPropertiesAbridgedAllOf](docs/ApertureEnergyPropertiesAbridgedAllOf.md)
 - [Model.ApertureModifierSet](docs/ApertureModifierSet.md)
 - [Model.ApertureModifierSetAbridged](docs/ApertureModifierSetAbridged.md)
 - [Model.ApertureModifierSetAbridgedAllOf](docs/ApertureModifierSetAbridgedAllOf.md)
 - [Model.ApertureModifierSetAllOf](docs/ApertureModifierSetAllOf.md)
 - [Model.AperturePropertiesAbridged](docs/AperturePropertiesAbridged.md)
 - [Model.AperturePropertiesAbridgedAllOf](docs/AperturePropertiesAbridgedAllOf.md)
 - [Model.ApertureRadiancePropertiesAbridged](docs/ApertureRadiancePropertiesAbridged.md)
 - [Model.ApertureRadiancePropertiesAbridgedAllOf](docs/ApertureRadiancePropertiesAbridgedAllOf.md)
 - [Model.Autocalculate](docs/Autocalculate.md)
 - [Model.AutocalculateAllOf](docs/AutocalculateAllOf.md)
 - [Model.Autosize](docs/Autosize.md)
 - [Model.AutosizeAllOf](docs/AutosizeAllOf.md)
 - [Model.BSDF](docs/BSDF.md)
 - [Model.BSDFAllOf](docs/BSDFAllOf.md)
 - [Model.BaseModifierSet](docs/BaseModifierSet.md)
 - [Model.BaseModifierSetAbridged](docs/BaseModifierSetAbridged.md)
 - [Model.BaseModifierSetAbridgedAllOf](docs/BaseModifierSetAbridgedAllOf.md)
 - [Model.BaseModifierSetAllOf](docs/BaseModifierSetAllOf.md)
 - [Model.Baseboard](docs/Baseboard.md)
 - [Model.BaseboardAllOf](docs/BaseboardAllOf.md)
 - [Model.BaseboardEquipmentType](docs/BaseboardEquipmentType.md)
 - [Model.BuildingType](docs/BuildingType.md)
 - [Model.Color](docs/Color.md)
 - [Model.ColorAllOf](docs/ColorAllOf.md)
 - [Model.ConstructionSet](docs/ConstructionSet.md)
 - [Model.ConstructionSetAbridged](docs/ConstructionSetAbridged.md)
 - [Model.ConstructionSetAbridgedAllOf](docs/ConstructionSetAbridgedAllOf.md)
 - [Model.ConstructionSetAllOf](docs/ConstructionSetAllOf.md)
 - [Model.ControlType](docs/ControlType.md)
 - [Model.DOASBase](docs/DOASBase.md)
 - [Model.DOASBaseAllOf](docs/DOASBaseAllOf.md)
 - [Model.DatedBaseModel](docs/DatedBaseModel.md)
 - [Model.DatedBaseModelAllOf](docs/DatedBaseModelAllOf.md)
 - [Model.DaylightingControl](docs/DaylightingControl.md)
 - [Model.DaylightingControlAllOf](docs/DaylightingControlAllOf.md)
 - [Model.Door](docs/Door.md)
 - [Model.DoorAllOf](docs/DoorAllOf.md)
 - [Model.DoorConstructionSet](docs/DoorConstructionSet.md)
 - [Model.DoorConstructionSetAbridged](docs/DoorConstructionSetAbridged.md)
 - [Model.DoorConstructionSetAbridgedAllOf](docs/DoorConstructionSetAbridgedAllOf.md)
 - [Model.DoorConstructionSetAllOf](docs/DoorConstructionSetAllOf.md)
 - [Model.DoorEnergyPropertiesAbridged](docs/DoorEnergyPropertiesAbridged.md)
 - [Model.DoorEnergyPropertiesAbridgedAllOf](docs/DoorEnergyPropertiesAbridgedAllOf.md)
 - [Model.DoorModifierSet](docs/DoorModifierSet.md)
 - [Model.DoorModifierSetAbridged](docs/DoorModifierSetAbridged.md)
 - [Model.DoorModifierSetAbridgedAllOf](docs/DoorModifierSetAbridgedAllOf.md)
 - [Model.DoorModifierSetAllOf](docs/DoorModifierSetAllOf.md)
 - [Model.DoorPropertiesAbridged](docs/DoorPropertiesAbridged.md)
 - [Model.DoorPropertiesAbridgedAllOf](docs/DoorPropertiesAbridgedAllOf.md)
 - [Model.DoorRadiancePropertiesAbridged](docs/DoorRadiancePropertiesAbridged.md)
 - [Model.DoorRadiancePropertiesAbridgedAllOf](docs/DoorRadiancePropertiesAbridgedAllOf.md)
 - [Model.EconomizerType](docs/EconomizerType.md)
 - [Model.ElectricEquipment](docs/ElectricEquipment.md)
 - [Model.ElectricEquipmentAbridged](docs/ElectricEquipmentAbridged.md)
 - [Model.ElectricEquipmentAbridgedAllOf](docs/ElectricEquipmentAbridgedAllOf.md)
 - [Model.ElectricEquipmentAllOf](docs/ElectricEquipmentAllOf.md)
 - [Model.EnergyBaseModel](docs/EnergyBaseModel.md)
 - [Model.EnergyBaseModelAllOf](docs/EnergyBaseModelAllOf.md)
 - [Model.EnergyMaterial](docs/EnergyMaterial.md)
 - [Model.EnergyMaterialAllOf](docs/EnergyMaterialAllOf.md)
 - [Model.EnergyMaterialNoMass](docs/EnergyMaterialNoMass.md)
 - [Model.EnergyMaterialNoMassAllOf](docs/EnergyMaterialNoMassAllOf.md)
 - [Model.EnergyMaterialVegetation](docs/EnergyMaterialVegetation.md)
 - [Model.EnergyMaterialVegetationAllOf](docs/EnergyMaterialVegetationAllOf.md)
 - [Model.EnergyWindowMaterialBlind](docs/EnergyWindowMaterialBlind.md)
 - [Model.EnergyWindowMaterialBlindAllOf](docs/EnergyWindowMaterialBlindAllOf.md)
 - [Model.EnergyWindowMaterialGas](docs/EnergyWindowMaterialGas.md)
 - [Model.EnergyWindowMaterialGasAllOf](docs/EnergyWindowMaterialGasAllOf.md)
 - [Model.EnergyWindowMaterialGasCustom](docs/EnergyWindowMaterialGasCustom.md)
 - [Model.EnergyWindowMaterialGasCustomAllOf](docs/EnergyWindowMaterialGasCustomAllOf.md)
 - [Model.EnergyWindowMaterialGasMixture](docs/EnergyWindowMaterialGasMixture.md)
 - [Model.EnergyWindowMaterialGasMixtureAllOf](docs/EnergyWindowMaterialGasMixtureAllOf.md)
 - [Model.EnergyWindowMaterialGlazing](docs/EnergyWindowMaterialGlazing.md)
 - [Model.EnergyWindowMaterialGlazingAllOf](docs/EnergyWindowMaterialGlazingAllOf.md)
 - [Model.EnergyWindowMaterialShade](docs/EnergyWindowMaterialShade.md)
 - [Model.EnergyWindowMaterialShadeAllOf](docs/EnergyWindowMaterialShadeAllOf.md)
 - [Model.EnergyWindowMaterialSimpleGlazSys](docs/EnergyWindowMaterialSimpleGlazSys.md)
 - [Model.EnergyWindowMaterialSimpleGlazSysAllOf](docs/EnergyWindowMaterialSimpleGlazSysAllOf.md)
 - [Model.EquipmentBase](docs/EquipmentBase.md)
 - [Model.EquipmentBaseAllOf](docs/EquipmentBaseAllOf.md)
 - [Model.EvaporativeCooler](docs/EvaporativeCooler.md)
 - [Model.EvaporativeCoolerAllOf](docs/EvaporativeCoolerAllOf.md)
 - [Model.EvaporativeCoolerEquipmentType](docs/EvaporativeCoolerEquipmentType.md)
 - [Model.FCU](docs/FCU.md)
 - [Model.FCUAllOf](docs/FCUAllOf.md)
 - [Model.FCUEquipmentType](docs/FCUEquipmentType.md)
 - [Model.FCUwithDOASAbridged](docs/FCUwithDOASAbridged.md)
 - [Model.FCUwithDOASAbridgedAllOf](docs/FCUwithDOASAbridgedAllOf.md)
 - [Model.FCUwithDOASEquipmentType](docs/FCUwithDOASEquipmentType.md)
 - [Model.Face](docs/Face.md)
 - [Model.Face3D](docs/Face3D.md)
 - [Model.Face3DAllOf](docs/Face3DAllOf.md)
 - [Model.FaceAllOf](docs/FaceAllOf.md)
 - [Model.FaceEnergyPropertiesAbridged](docs/FaceEnergyPropertiesAbridged.md)
 - [Model.FaceEnergyPropertiesAbridgedAllOf](docs/FaceEnergyPropertiesAbridgedAllOf.md)
 - [Model.FacePropertiesAbridged](docs/FacePropertiesAbridged.md)
 - [Model.FacePropertiesAbridgedAllOf](docs/FacePropertiesAbridgedAllOf.md)
 - [Model.FaceRadiancePropertiesAbridged](docs/FaceRadiancePropertiesAbridged.md)
 - [Model.FaceRadiancePropertiesAbridgedAllOf](docs/FaceRadiancePropertiesAbridgedAllOf.md)
 - [Model.FaceSubSet](docs/FaceSubSet.md)
 - [Model.FaceSubSetAbridged](docs/FaceSubSetAbridged.md)
 - [Model.FaceSubSetAbridgedAllOf](docs/FaceSubSetAbridgedAllOf.md)
 - [Model.FaceSubSetAllOf](docs/FaceSubSetAllOf.md)
 - [Model.FaceType](docs/FaceType.md)
 - [Model.FloorConstructionSet](docs/FloorConstructionSet.md)
 - [Model.FloorConstructionSetAbridged](docs/FloorConstructionSetAbridged.md)
 - [Model.FloorConstructionSetAbridgedAllOf](docs/FloorConstructionSetAbridgedAllOf.md)
 - [Model.FloorConstructionSetAllOf](docs/FloorConstructionSetAllOf.md)
 - [Model.FloorModifierSet](docs/FloorModifierSet.md)
 - [Model.FloorModifierSetAbridged](docs/FloorModifierSetAbridged.md)
 - [Model.FloorModifierSetAbridgedAllOf](docs/FloorModifierSetAbridgedAllOf.md)
 - [Model.FloorModifierSetAllOf](docs/FloorModifierSetAllOf.md)
 - [Model.ForcedAirFurnace](docs/ForcedAirFurnace.md)
 - [Model.ForcedAirFurnaceAllOf](docs/ForcedAirFurnaceAllOf.md)
 - [Model.FuelTypes](docs/FuelTypes.md)
 - [Model.FurnaceEquipmentType](docs/FurnaceEquipmentType.md)
 - [Model.GasEquipment](docs/GasEquipment.md)
 - [Model.GasEquipmentAbridged](docs/GasEquipmentAbridged.md)
 - [Model.GasEquipmentAbridgedAllOf](docs/GasEquipmentAbridgedAllOf.md)
 - [Model.GasEquipmentAllOf](docs/GasEquipmentAllOf.md)
 - [Model.GasType](docs/GasType.md)
 - [Model.GasUnitHeater](docs/GasUnitHeater.md)
 - [Model.GasUnitHeaterAllOf](docs/GasUnitHeaterAllOf.md)
 - [Model.GasUnitHeaterEquipmentType](docs/GasUnitHeaterEquipmentType.md)
 - [Model.Glass](docs/Glass.md)
 - [Model.GlassAllOf](docs/GlassAllOf.md)
 - [Model.GlobalConstructionSet](docs/GlobalConstructionSet.md)
 - [Model.GlobalConstructionSetAllOf](docs/GlobalConstructionSetAllOf.md)
 - [Model.GlobalModifierSet](docs/GlobalModifierSet.md)
 - [Model.GlobalModifierSetAllOf](docs/GlobalModifierSetAllOf.md)
 - [Model.Glow](docs/Glow.md)
 - [Model.GlowAllOf](docs/GlowAllOf.md)
 - [Model.Ground](docs/Ground.md)
 - [Model.GroundAllOf](docs/GroundAllOf.md)
 - [Model.HeatCoolBase](docs/HeatCoolBase.md)
 - [Model.HeatCoolBaseAllOf](docs/HeatCoolBaseAllOf.md)
 - [Model.IDdBaseModel](docs/IDdBaseModel.md)
 - [Model.IDdBaseModelAllOf](docs/IDdBaseModelAllOf.md)
 - [Model.IDdEnergyBaseModel](docs/IDdEnergyBaseModel.md)
 - [Model.IDdEnergyBaseModelAllOf](docs/IDdEnergyBaseModelAllOf.md)
 - [Model.IDdRadianceBaseModel](docs/IDdRadianceBaseModel.md)
 - [Model.IDdRadianceBaseModelAllOf](docs/IDdRadianceBaseModelAllOf.md)
 - [Model.IdealAirSystemAbridged](docs/IdealAirSystemAbridged.md)
 - [Model.IdealAirSystemAbridgedAllOf](docs/IdealAirSystemAbridgedAllOf.md)
 - [Model.Infiltration](docs/Infiltration.md)
 - [Model.InfiltrationAbridged](docs/InfiltrationAbridged.md)
 - [Model.InfiltrationAbridgedAllOf](docs/InfiltrationAbridgedAllOf.md)
 - [Model.InfiltrationAllOf](docs/InfiltrationAllOf.md)
 - [Model.InternalMassAbridged](docs/InternalMassAbridged.md)
 - [Model.InternalMassAbridgedAllOf](docs/InternalMassAbridgedAllOf.md)
 - [Model.Light](docs/Light.md)
 - [Model.LightAllOf](docs/LightAllOf.md)
 - [Model.Lighting](docs/Lighting.md)
 - [Model.LightingAbridged](docs/LightingAbridged.md)
 - [Model.LightingAbridgedAllOf](docs/LightingAbridgedAllOf.md)
 - [Model.LightingAllOf](docs/LightingAllOf.md)
 - [Model.Mesh3D](docs/Mesh3D.md)
 - [Model.Mesh3DAllOf](docs/Mesh3DAllOf.md)
 - [Model.Metal](docs/Metal.md)
 - [Model.MetalAllOf](docs/MetalAllOf.md)
 - [Model.Mirror](docs/Mirror.md)
 - [Model.MirrorAllOf](docs/MirrorAllOf.md)
 - [Model.Model](docs/Model.md)
 - [Model.ModelAllOf](docs/ModelAllOf.md)
 - [Model.ModelEnergyProperties](docs/ModelEnergyProperties.md)
 - [Model.ModelEnergyPropertiesAllOf](docs/ModelEnergyPropertiesAllOf.md)
 - [Model.ModelProperties](docs/ModelProperties.md)
 - [Model.ModelPropertiesAllOf](docs/ModelPropertiesAllOf.md)
 - [Model.ModelRadianceProperties](docs/ModelRadianceProperties.md)
 - [Model.ModelRadiancePropertiesAllOf](docs/ModelRadiancePropertiesAllOf.md)
 - [Model.ModifierBase](docs/ModifierBase.md)
 - [Model.ModifierBaseAllOf](docs/ModifierBaseAllOf.md)
 - [Model.ModifierSet](docs/ModifierSet.md)
 - [Model.ModifierSetAbridged](docs/ModifierSetAbridged.md)
 - [Model.ModifierSetAbridgedAllOf](docs/ModifierSetAbridgedAllOf.md)
 - [Model.ModifierSetAllOf](docs/ModifierSetAllOf.md)
 - [Model.MoistureDiffusionModel](docs/MoistureDiffusionModel.md)
 - [Model.NoLimit](docs/NoLimit.md)
 - [Model.NoLimitAllOf](docs/NoLimitAllOf.md)
 - [Model.OpaqueConstruction](docs/OpaqueConstruction.md)
 - [Model.OpaqueConstructionAbridged](docs/OpaqueConstructionAbridged.md)
 - [Model.OpaqueConstructionAbridgedAllOf](docs/OpaqueConstructionAbridgedAllOf.md)
 - [Model.OpaqueConstructionAllOf](docs/OpaqueConstructionAllOf.md)
 - [Model.OpenAPIGenBaseModel](docs/OpenAPIGenBaseModel.md)
 - [Model.Outdoors](docs/Outdoors.md)
 - [Model.OutdoorsAllOf](docs/OutdoorsAllOf.md)
 - [Model.PSZ](docs/PSZ.md)
 - [Model.PSZAllOf](docs/PSZAllOf.md)
 - [Model.PSZEquipmentType](docs/PSZEquipmentType.md)
 - [Model.PTAC](docs/PTAC.md)
 - [Model.PTACAllOf](docs/PTACAllOf.md)
 - [Model.PTACEquipmentType](docs/PTACEquipmentType.md)
 - [Model.PVAV](docs/PVAV.md)
 - [Model.PVAVAllOf](docs/PVAVAllOf.md)
 - [Model.PVAVEquipmentType](docs/PVAVEquipmentType.md)
 - [Model.People](docs/People.md)
 - [Model.PeopleAbridged](docs/PeopleAbridged.md)
 - [Model.PeopleAbridgedAllOf](docs/PeopleAbridgedAllOf.md)
 - [Model.PeopleAllOf](docs/PeopleAllOf.md)
 - [Model.Plane](docs/Plane.md)
 - [Model.PlaneAllOf](docs/PlaneAllOf.md)
 - [Model.Plastic](docs/Plastic.md)
 - [Model.PlasticAllOf](docs/PlasticAllOf.md)
 - [Model.ProcessAbridged](docs/ProcessAbridged.md)
 - [Model.ProcessAbridgedAllOf](docs/ProcessAbridgedAllOf.md)
 - [Model.ProgramType](docs/ProgramType.md)
 - [Model.ProgramTypeAbridged](docs/ProgramTypeAbridged.md)
 - [Model.ProgramTypeAbridgedAllOf](docs/ProgramTypeAbridgedAllOf.md)
 - [Model.ProgramTypeAllOf](docs/ProgramTypeAllOf.md)
 - [Model.PropertiesBaseAbridged](docs/PropertiesBaseAbridged.md)
 - [Model.PropertiesBaseAbridgedAllOf](docs/PropertiesBaseAbridgedAllOf.md)
 - [Model.RadianceAsset](docs/RadianceAsset.md)
 - [Model.RadianceAssetAllOf](docs/RadianceAssetAllOf.md)
 - [Model.RadianceShadeStateAbridged](docs/RadianceShadeStateAbridged.md)
 - [Model.RadianceShadeStateAbridgedAllOf](docs/RadianceShadeStateAbridgedAllOf.md)
 - [Model.RadianceSubFaceStateAbridged](docs/RadianceSubFaceStateAbridged.md)
 - [Model.RadianceSubFaceStateAbridgedAllOf](docs/RadianceSubFaceStateAbridgedAllOf.md)
 - [Model.Residential](docs/Residential.md)
 - [Model.ResidentialAllOf](docs/ResidentialAllOf.md)
 - [Model.ResidentialEquipmentType](docs/ResidentialEquipmentType.md)
 - [Model.RoofCeilingConstructionSet](docs/RoofCeilingConstructionSet.md)
 - [Model.RoofCeilingConstructionSetAbridged](docs/RoofCeilingConstructionSetAbridged.md)
 - [Model.RoofCeilingConstructionSetAbridgedAllOf](docs/RoofCeilingConstructionSetAbridgedAllOf.md)
 - [Model.RoofCeilingConstructionSetAllOf](docs/RoofCeilingConstructionSetAllOf.md)
 - [Model.RoofCeilingModifierSet](docs/RoofCeilingModifierSet.md)
 - [Model.RoofCeilingModifierSetAbridged](docs/RoofCeilingModifierSetAbridged.md)
 - [Model.RoofCeilingModifierSetAbridgedAllOf](docs/RoofCeilingModifierSetAbridgedAllOf.md)
 - [Model.RoofCeilingModifierSetAllOf](docs/RoofCeilingModifierSetAllOf.md)
 - [Model.Room](docs/Room.md)
 - [Model.RoomAllOf](docs/RoomAllOf.md)
 - [Model.RoomEnergyPropertiesAbridged](docs/RoomEnergyPropertiesAbridged.md)
 - [Model.RoomEnergyPropertiesAbridgedAllOf](docs/RoomEnergyPropertiesAbridgedAllOf.md)
 - [Model.RoomPropertiesAbridged](docs/RoomPropertiesAbridged.md)
 - [Model.RoomPropertiesAbridgedAllOf](docs/RoomPropertiesAbridgedAllOf.md)
 - [Model.RoomRadiancePropertiesAbridged](docs/RoomRadiancePropertiesAbridged.md)
 - [Model.RoomRadiancePropertiesAbridgedAllOf](docs/RoomRadiancePropertiesAbridgedAllOf.md)
 - [Model.Roughness](docs/Roughness.md)
 - [Model.SHWEquipmentType](docs/SHWEquipmentType.md)
 - [Model.SHWSystem](docs/SHWSystem.md)
 - [Model.SHWSystemAllOf](docs/SHWSystemAllOf.md)
 - [Model.ScheduleDay](docs/ScheduleDay.md)
 - [Model.ScheduleDayAllOf](docs/ScheduleDayAllOf.md)
 - [Model.ScheduleFixedInterval](docs/ScheduleFixedInterval.md)
 - [Model.ScheduleFixedIntervalAbridged](docs/ScheduleFixedIntervalAbridged.md)
 - [Model.ScheduleFixedIntervalAbridgedAllOf](docs/ScheduleFixedIntervalAbridgedAllOf.md)
 - [Model.ScheduleFixedIntervalAllOf](docs/ScheduleFixedIntervalAllOf.md)
 - [Model.ScheduleNumericType](docs/ScheduleNumericType.md)
 - [Model.ScheduleRuleAbridged](docs/ScheduleRuleAbridged.md)
 - [Model.ScheduleRuleAbridgedAllOf](docs/ScheduleRuleAbridgedAllOf.md)
 - [Model.ScheduleRuleset](docs/ScheduleRuleset.md)
 - [Model.ScheduleRulesetAbridged](docs/ScheduleRulesetAbridged.md)
 - [Model.ScheduleRulesetAbridgedAllOf](docs/ScheduleRulesetAbridgedAllOf.md)
 - [Model.ScheduleRulesetAllOf](docs/ScheduleRulesetAllOf.md)
 - [Model.ScheduleTypeLimit](docs/ScheduleTypeLimit.md)
 - [Model.ScheduleTypeLimitAllOf](docs/ScheduleTypeLimitAllOf.md)
 - [Model.ScheduleUnitType](docs/ScheduleUnitType.md)
 - [Model.Sensor](docs/Sensor.md)
 - [Model.SensorAllOf](docs/SensorAllOf.md)
 - [Model.SensorGrid](docs/SensorGrid.md)
 - [Model.SensorGridAllOf](docs/SensorGridAllOf.md)
 - [Model.ServiceHotWater](docs/ServiceHotWater.md)
 - [Model.ServiceHotWaterAbridged](docs/ServiceHotWaterAbridged.md)
 - [Model.ServiceHotWaterAbridgedAllOf](docs/ServiceHotWaterAbridgedAllOf.md)
 - [Model.ServiceHotWaterAllOf](docs/ServiceHotWaterAllOf.md)
 - [Model.Setpoint](docs/Setpoint.md)
 - [Model.SetpointAbridged](docs/SetpointAbridged.md)
 - [Model.SetpointAbridgedAllOf](docs/SetpointAbridgedAllOf.md)
 - [Model.SetpointAllOf](docs/SetpointAllOf.md)
 - [Model.Shade](docs/Shade.md)
 - [Model.ShadeAllOf](docs/ShadeAllOf.md)
 - [Model.ShadeConstruction](docs/ShadeConstruction.md)
 - [Model.ShadeConstructionAllOf](docs/ShadeConstructionAllOf.md)
 - [Model.ShadeEnergyPropertiesAbridged](docs/ShadeEnergyPropertiesAbridged.md)
 - [Model.ShadeEnergyPropertiesAbridgedAllOf](docs/ShadeEnergyPropertiesAbridgedAllOf.md)
 - [Model.ShadeLocation](docs/ShadeLocation.md)
 - [Model.ShadeModifierSet](docs/ShadeModifierSet.md)
 - [Model.ShadeModifierSetAbridged](docs/ShadeModifierSetAbridged.md)
 - [Model.ShadeModifierSetAbridgedAllOf](docs/ShadeModifierSetAbridgedAllOf.md)
 - [Model.ShadeModifierSetAllOf](docs/ShadeModifierSetAllOf.md)
 - [Model.ShadePropertiesAbridged](docs/ShadePropertiesAbridged.md)
 - [Model.ShadePropertiesAbridgedAllOf](docs/ShadePropertiesAbridgedAllOf.md)
 - [Model.ShadeRadiancePropertiesAbridged](docs/ShadeRadiancePropertiesAbridged.md)
 - [Model.ShadeRadiancePropertiesAbridgedAllOf](docs/ShadeRadiancePropertiesAbridgedAllOf.md)
 - [Model.SlatOrientation](docs/SlatOrientation.md)
 - [Model.StateGeometryAbridged](docs/StateGeometryAbridged.md)
 - [Model.StateGeometryAbridgedAllOf](docs/StateGeometryAbridgedAllOf.md)
 - [Model.Surface](docs/Surface.md)
 - [Model.SurfaceAllOf](docs/SurfaceAllOf.md)
 - [Model.TemplateSystem](docs/TemplateSystem.md)
 - [Model.TemplateSystemAllOf](docs/TemplateSystemAllOf.md)
 - [Model.Trans](docs/Trans.md)
 - [Model.TransAllOf](docs/TransAllOf.md)
 - [Model.Units](docs/Units.md)
 - [Model.VAV](docs/VAV.md)
 - [Model.VAVAllOf](docs/VAVAllOf.md)
 - [Model.VAVEquipmentType](docs/VAVEquipmentType.md)
 - [Model.VRF](docs/VRF.md)
 - [Model.VRFAllOf](docs/VRFAllOf.md)
 - [Model.VRFEquipmentType](docs/VRFEquipmentType.md)
 - [Model.VRFwithDOASAbridged](docs/VRFwithDOASAbridged.md)
 - [Model.VRFwithDOASAbridgedAllOf](docs/VRFwithDOASAbridgedAllOf.md)
 - [Model.VRFwithDOASEquipmentType](docs/VRFwithDOASEquipmentType.md)
 - [Model.Ventilation](docs/Ventilation.md)
 - [Model.VentilationAbridged](docs/VentilationAbridged.md)
 - [Model.VentilationAbridgedAllOf](docs/VentilationAbridgedAllOf.md)
 - [Model.VentilationAllOf](docs/VentilationAllOf.md)
 - [Model.VentilationControlAbridged](docs/VentilationControlAbridged.md)
 - [Model.VentilationControlAbridgedAllOf](docs/VentilationControlAbridgedAllOf.md)
 - [Model.VentilationControlType](docs/VentilationControlType.md)
 - [Model.VentilationOpening](docs/VentilationOpening.md)
 - [Model.VentilationOpeningAllOf](docs/VentilationOpeningAllOf.md)
 - [Model.VentilationSimulationControl](docs/VentilationSimulationControl.md)
 - [Model.VentilationSimulationControlAllOf](docs/VentilationSimulationControlAllOf.md)
 - [Model.View](docs/View.md)
 - [Model.ViewAllOf](docs/ViewAllOf.md)
 - [Model.ViewType](docs/ViewType.md)
 - [Model.Vintages](docs/Vintages.md)
 - [Model.Void](docs/Void.md)
 - [Model.VoidAllOf](docs/VoidAllOf.md)
 - [Model.WSHP](docs/WSHP.md)
 - [Model.WSHPAllOf](docs/WSHPAllOf.md)
 - [Model.WSHPEquipmentType](docs/WSHPEquipmentType.md)
 - [Model.WSHPwithDOASAbridged](docs/WSHPwithDOASAbridged.md)
 - [Model.WSHPwithDOASAbridgedAllOf](docs/WSHPwithDOASAbridgedAllOf.md)
 - [Model.WSHPwithDOASEquipmentType](docs/WSHPwithDOASEquipmentType.md)
 - [Model.WallConstructionSet](docs/WallConstructionSet.md)
 - [Model.WallConstructionSetAbridged](docs/WallConstructionSetAbridged.md)
 - [Model.WallConstructionSetAbridgedAllOf](docs/WallConstructionSetAbridgedAllOf.md)
 - [Model.WallConstructionSetAllOf](docs/WallConstructionSetAllOf.md)
 - [Model.WallModifierSet](docs/WallModifierSet.md)
 - [Model.WallModifierSetAbridged](docs/WallModifierSetAbridged.md)
 - [Model.WallModifierSetAbridgedAllOf](docs/WallModifierSetAbridgedAllOf.md)
 - [Model.WallModifierSetAllOf](docs/WallModifierSetAllOf.md)
 - [Model.WindowAC](docs/WindowAC.md)
 - [Model.WindowACAllOf](docs/WindowACAllOf.md)
 - [Model.WindowACEquipmentType](docs/WindowACEquipmentType.md)
 - [Model.WindowConstruction](docs/WindowConstruction.md)
 - [Model.WindowConstructionAbridged](docs/WindowConstructionAbridged.md)
 - [Model.WindowConstructionAbridgedAllOf](docs/WindowConstructionAbridgedAllOf.md)
 - [Model.WindowConstructionAllOf](docs/WindowConstructionAllOf.md)
 - [Model.WindowConstructionDynamic](docs/WindowConstructionDynamic.md)
 - [Model.WindowConstructionDynamicAbridged](docs/WindowConstructionDynamicAbridged.md)
 - [Model.WindowConstructionDynamicAbridgedAllOf](docs/WindowConstructionDynamicAbridgedAllOf.md)
 - [Model.WindowConstructionDynamicAllOf](docs/WindowConstructionDynamicAllOf.md)
 - [Model.WindowConstructionShade](docs/WindowConstructionShade.md)
 - [Model.WindowConstructionShadeAbridged](docs/WindowConstructionShadeAbridged.md)
 - [Model.WindowConstructionShadeAbridgedAllOf](docs/WindowConstructionShadeAbridgedAllOf.md)
 - [Model.WindowConstructionShadeAllOf](docs/WindowConstructionShadeAllOf.md)


## Documentation for Authorization

All endpoints do not require authorization.
