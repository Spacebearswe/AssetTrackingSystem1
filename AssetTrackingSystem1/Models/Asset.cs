using AssetTrackingSystem1.Interface;
using System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AssetTrackingSystem1.Models
{
    public class Asset : IAsset
    {
        private static int _NextAssetId = 1; // starts at 1
        public int AssetId { get; set; }

        public Asset()
        {
            AssetId = _NextAssetId++;
        }


    }
}
