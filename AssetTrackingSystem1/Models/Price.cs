using System;
using System.Collections.Generic;
using System.Text;
using static AssetTrackingSystem1.Models.CurrencyType;

namespace AssetTrackingSystem1.Models
{
    public readonly struct Price
    {
        public decimal Amount { get; }
        public CurrencyType Currency { get; }

        public Price(decimal amount, CurrencyType currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override string ToString() => $"{Amount} {Currency}";
    }

}
