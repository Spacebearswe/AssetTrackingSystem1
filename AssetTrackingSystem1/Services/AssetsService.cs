using AssetTrackingSystem1.Data;
using AssetTrackingSystem1.Models;
using AssetTrackingSystem1.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using System.Linq;
using static AssetTrackingSystem1.Models.Countries;
using static AssetTrackingSystem1.Models.CurrencyType;
using static AssetTrackingSystem1.Models.Price;


namespace AssetTrackingSystem1.Services
{
    public class AssetsService: AssetListNode
    {
        // This list will hold the assets in memory in this class. 
        private List<AssetListNode> assetList;

        // Constructor that takes an AssetList as a parameter
        public AssetsService(List<AssetListNode> _assetList)
        {
            assetList = _assetList;
        }

        /// <summary>
        /// Gets all assets.
        /// </summary>
        /// <returns>An enumerable collection of assets.</returns>
        public async Task ListAllAssets()
        {

            // Flatten the asset list into a local list of concrete assets, then sort by OfficeLocation and PurchaseDate
            Console.WriteLine("Asset List:");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Office          Type            Brand           Model                Purchase Date      Status");
            Console.WriteLine();

            var flattened = new List<Asset>();
            foreach (var node in assetList)
            {
                if (node.desktopModel != null) flattened.Add(node.desktopModel);
                if (node.laptopModel != null) flattened.Add(node.laptopModel);
                if (node.tabletModel != null) flattened.Add(node.tabletModel);
                if (node.smartphoneModel != null) flattened.Add(node.smartphoneModel);
            }
            // Order by OfficeLocation then by PurchaseDate (ascending).
            // Use local type-pattern matching helpers to extract the properties without changing model types.
            string GetOfficeLocation(Asset a)
            {
                return a switch
                {
                    Desktop d => d.OfficeLocation ?? string.Empty,
                    Laptop l => l.OfficeLocation ?? string.Empty,
                    Tablet t => t.OfficeLocation ?? string.Empty,
                    Smartphone s => s.OfficeLocation ?? string.Empty,
                    _ => string.Empty,
                };
            }

            DateTime GetPurchaseDate(Asset a)
            {
                return a switch
                {
                    Desktop d => d.PurchaseDate,
                    Laptop l => l.PurchaseDate,
                    Tablet t => t.PurchaseDate,
                    Smartphone s => s.PurchaseDate,
                    _ => DateTime.MinValue,
                };
            }

            var ordered = flattened.OrderBy(a => GetOfficeLocation(a)).ThenBy(a => GetPurchaseDate(a));

            foreach (var asset in ordered)
            {
                switch (asset)
                {
                    case Desktop d:
                        WriteAssetToConsole(d);
                        break;
                    case Laptop l:
                        WriteAssetToConsole(l);
                        break;
                    case Tablet t:
                        WriteAssetToConsole(t);
                        break;
                    case Smartphone s:
                        WriteAssetToConsole(s);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            return;
        }

        public void WriteAssetToConsole(Desktop desktop)
        {
            // Write the asset details to the console (no newline so status can be appended)
            Console.Write($"{("Office " + desktop.OfficeLocation),-15} {desktop.GetType().Name,-15} {desktop.Brand,-15} {desktop.Model,-20} {desktop.PurchaseDate.ToShortDateString(),-15}");


            // Calculate the status of the desktop based on its purchase date and the current date
            // End-of-Life Rules 
            // Status YELLOW  Condition Less than 3 months remaining
            // Status RED     Condition Less than 6 months remaining

            TimeSpan timeLeft = desktop.PurchaseDate.AddYears(3) - DateTime.Now;
            if (timeLeft.TotalDays < 90)
            {
                ColoredText.Write("    (YELLOW)", ConsoleColor.Yellow);
            }
            else if (timeLeft.TotalDays < 180)
            {
                ColoredText.Write("    (RED)", ConsoleColor.Red);
            }

            // End the current line
            Console.WriteLine();
        }

        public void WriteAssetToConsole(Laptop laptop)
        {
            // Write the asset details to the console (no newline so status can be appended)
            Console.Write($"{("Office " + laptop.OfficeLocation),-15} {laptop.GetType().Name,-15} {laptop.Brand,-15} {laptop.Model,-20} {laptop.PurchaseDate.ToShortDateString(),-15}");


            // Calculate the status of the desktop based on its purchase date and the current date
            // End-of-Life Rules 
            // Status YELLOW  Condition Less than 3 months remaining
            // Status RED     Condition Less than 6 months remaining

            TimeSpan timeLeft = laptop.PurchaseDate.AddYears(3) - DateTime.Now;
            if (timeLeft.TotalDays < 90)
            {
                ColoredText.Write("    (YELLOW)", ConsoleColor.Yellow);
            }
            else if (timeLeft.TotalDays < 180)
            {
                ColoredText.Write("    (RED)", ConsoleColor.Red);
            }

            // End the current line
            Console.WriteLine();
        }

        public void WriteAssetToConsole(Smartphone smartphone)
        {
            // Write the asset details to the console (no newline so status can be appended)
            Console.Write($"{("Office " + smartphone.OfficeLocation),-15} {smartphone.GetType().Name,-15} {smartphone.Brand,-15} {smartphone.Model,-20} {smartphone.PurchaseDate.ToShortDateString(),-15}");


            // Calculate the status of the desktop based on its purchase date and the current date
            // End-of-Life Rules 
            // Status YELLOW  Condition Less than 3 months remaining
            // Status RED     Condition Less than 6 months remaining

            TimeSpan timeLeft = smartphone.PurchaseDate.AddYears(3) - DateTime.Now;
            if (timeLeft.TotalDays < 90)
            {
                ColoredText.Write("    (YELLOW)", ConsoleColor.Yellow);
            }
            else if (timeLeft.TotalDays < 180)
            {
                ColoredText.Write("    (RED)", ConsoleColor.Red);
            }

            // End the current line
            Console.WriteLine();
        }

        public void WriteAssetToConsole(Tablet tablet)
        {
            // Write the asset details to the console (no newline so status can be appended)
            Console.Write($"{("Office " + tablet.OfficeLocation),-15} {tablet.GetType().Name,-15} {tablet.Brand,-15} {tablet.Model,-20} {tablet.PurchaseDate.ToShortDateString(),-15}");


            // Calculate the status of the desktop based on its purchase date and the current date
            // End-of-Life Rules 
            // Status YELLOW  Condition Less than 3 months remaining
            // Status RED     Condition Less than 6 months remaining

            TimeSpan timeLeft = tablet.PurchaseDate.AddYears(3) - DateTime.Now;
            if (timeLeft.TotalDays < 90)
            {
                ColoredText.Write("    (YELLOW)", ConsoleColor.Yellow);
            }
            else if (timeLeft.TotalDays < 180)
            {
                ColoredText.Write("    (RED)", ConsoleColor.Red);
            }

            // End the current line
            Console.WriteLine();
        }

        public bool addExampleAssets()
        {
            var exampleData = new ExampleData(assetList);
            return true;
        }


    }
}
