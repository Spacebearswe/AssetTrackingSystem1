using AssetTrackingSystem1.Data;
using AssetTrackingSystem1.Models;
using AssetTrackingSystem1.Services;
using AssetTrackingSystem1.Utilities;
using System;
using System.Threading.Tasks; // added


internal class Program
{
    public static async Task Main() // changed to async Task
    {
        //Keep the assetslist as a local variable in the main method and pass it to the AssetManagerService constructor.
        //This way, you can ensure that the same instance of AssetsService is used throughout the application.
        List<AssetListNode> assetList = new List<AssetListNode>();

        var assetsService = new AssetsService(assetList);
        //var assetManager = new AssetManagerService(assetsService); // adjust ctor if needed
        await new Program().MainMenu(assetsService); // await call

        Program program = new Program();
        await program.MainMenu(assetsService); // await call
    }

    public async Task MainMenu(AssetsService assetsService) // changed to async Task
    {
        bool doRun = true;
        while (doRun)
        {
            Console.Clear();
            ColoredText.WriteLine("Asset Tracking System", ConsoleColor.Yellow);
            Console.WriteLine("");
            Console.WriteLine("Enter a Number");
            Console.WriteLine("1-Add a Asset");
            Console.WriteLine("2-Search a Asset");
            Console.WriteLine("3-List Assets");
            Console.WriteLine("4-List All Assets");
            Console.WriteLine("5-Remove Asset");
            Console.WriteLine("6-Update Asset");
            Console.WriteLine("7-Show Statistics");
            Console.WriteLine("8-Load Assets");
            Console.WriteLine("9-Save Assets");
            Console.WriteLine("10-Load defults");
            Console.WriteLine("0-Quit");

            Console.Write("Enter a Number ");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //assetsService.AddAsset();
                    break;
                case "2":
                    //assetsService.SearchAsset();
                    break;
                case "3":
                    //assetsService.ListAssets();
                    break;
                case "4":
                    await assetsService.ListAllAssets();
                    break;
                case "5":
                    //assetsService.RemoveAsset();
                    break;
                case "6":
                    //assetsService.UpdateAsset();
                    break;
                case "7":
                    // assetManager.ShowStatistics();
                    break;
                case "8":
                    // assetManager.LoadAssets();
                    break;
                case "9":
                    // assetsService.SaveAssets();
                    break;
                case "10":
                    assetsService.addExampleAssets();
                    break;
                case "0":
                    Console.WriteLine("Thank you for using this application");
                    doRun = false;
                    break;

                default:
                    Console.WriteLine("Invalid Selection");
                    Console.ReadKey();
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

    }
}
