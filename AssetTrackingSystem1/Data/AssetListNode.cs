using AssetTrackingSystem1.Models;
using AssetTrackingSystem1.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTrackingSystem1.Data
{
    public class AssetListNode
    {
        // The AssetListNode class represents a generic asset with properties such as
        // Tablets, Smartphones and more. Simple to expand to new asset types in the future.
        // It serves as a base class for specific asset types like Tablets and Smartphones.
        // To be able to acess the variabels in this class from inherited clases
        // these variables must be public 

        public AssetListNode() { }

        // Factory methods to create AssetListNode instances for different asset types
        public static AssetListNode CreateForDesktop(Desktop d)
        {
            return new AssetListNode { desktopModel = d };
        }

        public static AssetListNode CreateForLaptop(Laptop l)
        {
            return new AssetListNode { laptopModel = l };
        }

        public static AssetListNode CreateForTablet(Tablet t)
        {
            return new AssetListNode { tabletModel = t };
        }

        public static AssetListNode CreateForSmartphone(Smartphone s)
        {
            return new AssetListNode { smartphoneModel = s };
        }

        // Assign to the instance field (this.desktop) instead of declaring a local variable

        private Desktop? _desktopModel;
        public Desktop? desktopModel
        {
            get => _desktopModel;
            set
            {
                _desktopModel = value;
                if (_desktopModel is not null)
                {
                    // perform common initialization when a desktop is assigned
                    // e.g. populate metadata, set id, validate etc.
                }
            }
        }

        private Laptop? _laptopModel;
        public Laptop? laptopModel
        {
            get => _laptopModel;
            set
            {
                _laptopModel = value;
                if (_laptopModel is not null)
                {
                    // perform common initialization when a laptop is assigned
                    // e.g. populate metadata, set id, validate etc.
                }
            }
        }

        private Smartphone? _smartphoneModel;
        public Smartphone? smartphoneModel
        {
            get => _smartphoneModel;
            set
            {
                _smartphoneModel = value;
                if (_smartphoneModel is not null)
                {
                    // perform common initialization when a smartphone is assigned
                    // e.g. populate metadata, set id, validate etc.
                }
            }
        }

        private Tablet? _tabletModel;
        public Tablet? tabletModel
        {
            get => _tabletModel;
            set
            {
                _tabletModel = value;
                if (_tabletModel is not null)
                {
                    // perform common initialization when a tablet is assigned
                    // e.g. populate metadata, set id, validate etc.
                }
            }
        }

        // assign to the instance field (this.desktopModel) instead of declaring a local variable
        //public AssetListNode(Asset _assetList, Desktop _deskTopComputer)
        //{
        //    // assign to the instance field (not a new local variable)
        //    this.desktopModel = _deskTopComputer;
        //}

        //public AssetListNode(Asset _assitList, LaptopModel _laptopComputer)
        //{
        //    this.laptopModel = _laptopComputer;
        //}

        //public AssetListNode(Asset _assitList, TabletModel _tabletComputer)
        //{
        //    this.tabletModel = _tabletComputer;
        //}

        //public AssetListNode(Asset _assitList, SmartphoneModel _smartphoneComputer)
        //{
        //    this.smartphoneModel = _smartphoneComputer;
        //}

        public Desktop desktop;
        public Laptop laptop;
        public Tablet tablet;
        public Smartphone smartphone;
    }
}
