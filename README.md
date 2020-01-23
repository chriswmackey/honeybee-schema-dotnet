# HoneybeeDotNet - the C# library for the Honeybee Model Schema

This is the documentation for Honeybee model schema.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.3.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ladybug-tools/honeybee-core](https://github.com/ladybug-tools/honeybee-core)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

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
using HoneybeeDotNet.Api;
using HoneybeeDotNet.Client;
using HoneybeeDotNet.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out HoneybeeDotNet.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using HoneybeeDotNet.Api;
using HoneybeeDotNet.Client;
using HoneybeeDotNet.Model;

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

 - [Model.Adiabatic](docs/Adiabatic.md)
 - [Model.Aperture](docs/Aperture.md)
 - [Model.ApertureEnergyPropertiesAbridged](docs/ApertureEnergyPropertiesAbridged.md)
 - [Model.AperturePropertiesAbridged](docs/AperturePropertiesAbridged.md)
 - [Model.ApertureSetAbridged](docs/ApertureSetAbridged.md)
 - [Model.ConstructionSetAbridged](docs/ConstructionSetAbridged.md)
 - [Model.Door](docs/Door.md)
 - [Model.DoorEnergyPropertiesAbridged](docs/DoorEnergyPropertiesAbridged.md)
 - [Model.DoorPropertiesAbridged](docs/DoorPropertiesAbridged.md)
 - [Model.DoorSetAbridged](docs/DoorSetAbridged.md)
 - [Model.ElectricEquipmentAbridged](docs/ElectricEquipmentAbridged.md)
 - [Model.EnergyMaterial](docs/EnergyMaterial.md)
 - [Model.EnergyMaterialNoMass](docs/EnergyMaterialNoMass.md)
 - [Model.EnergyWindowMaterialBlind](docs/EnergyWindowMaterialBlind.md)
 - [Model.EnergyWindowMaterialGas](docs/EnergyWindowMaterialGas.md)
 - [Model.EnergyWindowMaterialGasCustom](docs/EnergyWindowMaterialGasCustom.md)
 - [Model.EnergyWindowMaterialGasMixture](docs/EnergyWindowMaterialGasMixture.md)
 - [Model.EnergyWindowMaterialGlazing](docs/EnergyWindowMaterialGlazing.md)
 - [Model.EnergyWindowMaterialShade](docs/EnergyWindowMaterialShade.md)
 - [Model.EnergyWindowMaterialSimpleGlazSys](docs/EnergyWindowMaterialSimpleGlazSys.md)
 - [Model.Face](docs/Face.md)
 - [Model.Face3D](docs/Face3D.md)
 - [Model.FaceEnergyPropertiesAbridged](docs/FaceEnergyPropertiesAbridged.md)
 - [Model.FacePropertiesAbridged](docs/FacePropertiesAbridged.md)
 - [Model.FloorSetAbridged](docs/FloorSetAbridged.md)
 - [Model.GasEquipmentAbridged](docs/GasEquipmentAbridged.md)
 - [Model.Ground](docs/Ground.md)
 - [Model.IdealAirSystemAbridged](docs/IdealAirSystemAbridged.md)
 - [Model.InfiltrationAbridged](docs/InfiltrationAbridged.md)
 - [Model.LightingAbridged](docs/LightingAbridged.md)
 - [Model.Model](docs/Model.md)
 - [Model.ModelEnergyProperties](docs/ModelEnergyProperties.md)
 - [Model.ModelProperties](docs/ModelProperties.md)
 - [Model.OpaqueConstructionAbridged](docs/OpaqueConstructionAbridged.md)
 - [Model.Outdoors](docs/Outdoors.md)
 - [Model.PeopleAbridged](docs/PeopleAbridged.md)
 - [Model.Plane](docs/Plane.md)
 - [Model.ProgramTypeAbridged](docs/ProgramTypeAbridged.md)
 - [Model.RoofCeilingSetAbridged](docs/RoofCeilingSetAbridged.md)
 - [Model.Room](docs/Room.md)
 - [Model.RoomEnergyPropertiesAbridged](docs/RoomEnergyPropertiesAbridged.md)
 - [Model.RoomPropertiesAbridged](docs/RoomPropertiesAbridged.md)
 - [Model.ScheduleDay](docs/ScheduleDay.md)
 - [Model.ScheduleFixedIntervalAbridged](docs/ScheduleFixedIntervalAbridged.md)
 - [Model.ScheduleRuleAbridged](docs/ScheduleRuleAbridged.md)
 - [Model.ScheduleRulesetAbridged](docs/ScheduleRulesetAbridged.md)
 - [Model.ScheduleTypeLimit](docs/ScheduleTypeLimit.md)
 - [Model.SetpointAbridged](docs/SetpointAbridged.md)
 - [Model.Shade](docs/Shade.md)
 - [Model.ShadeConstruction](docs/ShadeConstruction.md)
 - [Model.ShadeEnergyPropertiesAbridged](docs/ShadeEnergyPropertiesAbridged.md)
 - [Model.ShadePropertiesAbridged](docs/ShadePropertiesAbridged.md)
 - [Model.Surface](docs/Surface.md)
 - [Model.VentilationAbridged](docs/VentilationAbridged.md)
 - [Model.WallSetAbridged](docs/WallSetAbridged.md)
 - [Model.WindowConstructionAbridged](docs/WindowConstructionAbridged.md)


## Documentation for Authorization

All endpoints do not require authorization.
