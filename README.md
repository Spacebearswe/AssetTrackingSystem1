# AssetTrackingSystem1

Console-based asset tracker written in C# targeting .NET 10.

## Overview

This project is a simple in-memory asset registry for desktops, laptops, tablets, and smartphones. It provides a menu-driven console UI with basic features:

- Add example assets
- List assets (with colored status based on purchase date)
- Flatten and sort assets by office and purchase date

## Prerequisites

- .NET 10 SDK: https://dotnet.microsoft.com

## Build

From the repository root run:

```
dotnet build AssetTrackingSystem1/AssetTrackingSystem1.csproj
```

## Run

Run the console app from the project folder:

```
dotnet run --project AssetTrackingSystem1/AssetTrackingSystem1.csproj
```

Use the menu; option `4` lists all assets. Option `10` adds example assets used for testing.

## Project structure

- Models/ - domain models (Asset, Desktop, Laptop, Tablet, Smartphone, Price, enums)
- Data/ - AssetListNode container used to hold different asset types
- Services/ - business logic and console output helpers (AssetsService, etc.)
- Utilities/ - ColoredText for colored console output
- Program.cs - application entry and menu

## Notes for developers

- OfficeLocation and PurchaseDate are stored on concrete asset classes (Desktop, Laptop, Tablet, Smartphone), not on the base Asset class.
- AssetsService flattens AssetListNode instances into a local List<Asset>, then orders that list by OfficeLocation and PurchaseDate using LINQ. Example:

```csharp
var ordered = flattened
	.OrderBy(a => GetOfficeLocation(a))
	.ThenBy(a => GetPurchaseDate(a));

// helper functions use pattern matching to extract properties from concrete types
string GetOfficeLocation(Asset a) => a switch {
	Desktop d => d.OfficeLocation ?? string.Empty,
	Laptop l => l.OfficeLocation ?? string.Empty,
	Tablet t => t.OfficeLocation ?? string.Empty,
	Smartphone s => s.OfficeLocation ?? string.Empty,
	_ => string.Empty
};

DateTime GetPurchaseDate(Asset a) => a switch {
	Desktop d => d.PurchaseDate,
	Laptop l => l.PurchaseDate,
	Tablet t => t.PurchaseDate,
	Smartphone s => s.PurchaseDate,
	_ => DateTime.MinValue
};
```

- ColoredText provides Write/WriteLine overloads to print colored text inline (used to append status on the same line).

## Contributing

Feel free to open issues or submit pull requests. Suggested improvements:

- Move OfficeLocation and PurchaseDate to the base Asset class or introduce an interface implemented by all asset types to simplify sorting.
- Add dedicated WriteAssetToConsole overloads for each concrete type to unify formatting.

## License

No license file included. Add a LICENSE if you plan to publish this project under an open-source license.

---
