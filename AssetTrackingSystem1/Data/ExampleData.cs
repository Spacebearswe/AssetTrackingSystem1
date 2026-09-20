using AssetTrackingSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AssetTrackingSystem1.Data
{
    public class ExampleData
    {

        public ExampleData(List<AssetListNode> assetList)
        {
                // some example data for testing purposes
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(200, CurrencyType.USD), DateTime.Now.AddMonths(-36 + 4), "Motorola", "X3", "USA")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(400, CurrencyType.USD), DateTime.Now.AddMonths(-36 + 5), "Motorola", "X3", "USA")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(400, CurrencyType.USD), DateTime.Now.AddMonths(-36 + 10), "Motorola", "X2", "USA")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(4500, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 6), "Samsung", "Galaxy 10", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(4500, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 7), "Samsung", "Galaxy 10", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(3000, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 4), "Sony", "XPeria 7", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(3000, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 5), "Sony", "XPeria 7", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(220, CurrencyType.EUR), DateTime.Now.AddMonths(-36 + 12), "Siemens", "Brick", "Germany")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(220, CurrencyType.EUR), DateTime.Now.AddMonths(-36 + 12), "Siemens", "Brick", "Germany")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(100, CurrencyType.USD), DateTime.Now.AddMonths(-38), "Dell", "Desktop 900", "USA")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(100, CurrencyType.USD), DateTime.Now.AddMonths(-37), "Dell", "Desktop 900", "USA")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(300, CurrencyType.USD), DateTime.Now.AddMonths(-36 + 1), "Lenovo", "X100", "USA")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(300, CurrencyType.USD), DateTime.Now.AddMonths(-36 + 4), "Lenovo", "X200", "USA")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(500, CurrencyType.USD), DateTime.Now.AddMonths(-36 + 9), "Lenovo", "X300", "USA")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1500, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 7), "Dell", "Optiplex 100", "Sweden")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1400, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 8), "Dell", "Optiplex 200", "Sweden")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1300, CurrencyType.SEK), DateTime.Now.AddMonths(-36 + 9), "Dell", "Optiplex 300", "Sweden")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1600, CurrencyType.EUR), DateTime.Now.AddMonths(-36 + 14), "Asus", "ROG 600", "Germany")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1200, CurrencyType.EUR), DateTime.Now.AddMonths(-36 + 4), "Asus", "ROG 500", "Germany")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1200, CurrencyType.EUR), DateTime.Now.AddMonths(-36 + 3), "Asus", "ROG 500", "Germany")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1300, CurrencyType.EUR), DateTime.Now.AddMonths(-36 + 2), "Asus", "ROG 500", "Germany")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(200m, CurrencyType.USD), DateTime.Now.AddMonths(-32), "Motorola", "X3", "USA")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(400m, CurrencyType.USD), DateTime.Now.AddMonths(-31), "Motorola", "X3", "USA")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(400m, CurrencyType.USD), DateTime.Now.AddMonths(-26), "Motorola", "X2", "USA")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(4500m, CurrencyType.SEK), DateTime.Now.AddMonths(-30), "Samsung", "Galaxy 10", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(4500m, CurrencyType.SEK), DateTime.Now.AddMonths(-29), "Samsung", "Galaxy 10", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(3000m, CurrencyType.SEK), DateTime.Now.AddMonths(-32), "Sony", "XPeria 7", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(3000m, CurrencyType.SEK), DateTime.Now.AddMonths(-31), "Sony", "XPeria 7", "Sweden")));
                assetList.Add(AssetListNode.CreateForSmartphone(new Smartphone(new Price(220m, CurrencyType.EUR), DateTime.Now.AddMonths(-24), "Siemens", "Brick", "Germany")));
                assetList.Add(AssetListNode.CreateForDesktop(new Desktop(new Price(1300m, CurrencyType.SEK), DateTime.Now.AddMonths(-27), "Dell", "Optiplex 300", "Sweden")));
            //}
            //catch (Exception ex)
            //        {
            //    Console.WriteLine($"An error occurred: Could not load default data. {ex.Message}");
            //}
        }
    }
}
