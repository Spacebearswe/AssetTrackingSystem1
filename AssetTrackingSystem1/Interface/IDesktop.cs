using AssetTrackingSystem1.Models;

namespace AssetTrackingSystem1.Interface
{
    public interface IDesktop
    {
        string? Brand { get; set; }
        string? Model { get; set; }
        string? OfficeLocation { get; set; }
        decimal PriceLocal { get; set; }
        Price PriceUSD { get; set; }
        DateTime PurchaseDate { get; set; }
    }
}