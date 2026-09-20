using AssetTrackingSystem1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTrackingSystem1.Models
{
    public class Desktop : Asset, IDesktop
    {
        // constructor that initializes base properties

        //public Desktop(Price price, DateTime purchaseDate, string brand, string model, string officeLocation)
        //{
        //    PriceUSD = price;
        //    PurchaseDate = purchaseDate;
        //    Brand = brand;
        //    Model = model;
        //    OfficeLocation = officeLocation;
        //}

        public Desktop(Price _price, DateTime _purchaseDate, string _brand, string _model, string _officeLocation)
        {
            PriceUSD = _price;
            PurchaseDate = _purchaseDate;
            Brand = _brand;
            Model = _model;
            OfficeLocation = _officeLocation;
        }

        int id;
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Price PriceUSD { get; set; }
        public decimal PriceLocal { get; set; }
        public string? OfficeLocation { get; set; }
    }
}
