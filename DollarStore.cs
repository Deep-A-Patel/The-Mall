using System;
using System.Collections.Generic;

namespace TheMall
{
    public class DollarStore : IStorable<DollarItem>
    {
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();

        // private double _price = 1.00;

        public void AddToInventory(string dollarItemName, DollarItem dollarItem)
        {
            _inventory.Add(dollarItemName, dollarItem);
        }

        public DollarItem GetFromInventory(string name)
        {
            return _inventory[name];
        }
    }
}