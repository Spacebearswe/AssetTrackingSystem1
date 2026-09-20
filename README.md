# AssetTrackingSystem1

Console-based Asset Tracking System written in C#.

## Overview

This solution provides a simple in-memory asset registry for desktops, laptops, tablets and smartphones. It supports adding example data, listing assets, and basic end-of-life status coloring for assets based on purchase date.

## Prerequisites

- .NET 10 SDK (or compatible .NET 10 runtime) installed: https://dotnet.microsoft.com

## Build

From the repository root run:

```bash
dotnet build AssetTrackingSystem1/AssetTrackingSystem1.csproj
```

## Run

Run the console app from the project folder:

```bash
dotnet run --project AssetTrackingSystem1/AssetTrackingSystem1.csproj
```

The application displays a menu. Use option `4` (List All Assets) to show assets. Example assets can be added from the menu option that calls `addExampleAssets()`.

## Important files / structure

- AssetTrackingSystem1/Models - Domain models (Asset, Desktop, Laptop, Tablet, Smartphone, Price, enums)
- AssetTrackingSystem1/Data - AssetListNode container
- AssetTrackingSystem1/Services - Business logic and console output helpers (AssetsService, etc.)
- AssetTrackingSystem1/Utilities - Colored console output helper (ColoredText)
- AssetTrackingSystem1/Program.cs - Console menu and application entry

## Notes

- Office location and purchase date are stored on concrete asset types (Desktop/Laptop/Tablet/Smartphone).
- AssetsService flattens AssetListNode entries into a local list and uses LINQ to order by office then purchase date.
- ColoredText provides Write/WriteLine overloads to print colored status inline.

## Contributing

Open an issue or submit a PR. Add tests and update the README when adding features.

## License

No license specified. Add a LICENSE file if you intend to publish under an open-source license.
