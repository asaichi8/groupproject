﻿using System;
using System.Collections.Generic;
namespace ShoppingListApp.src
{
    public class Shop
    {
        private static List<Shop> allShops = new List<Shop>();

        private readonly string name;
        private bool isFiltered;


        public Shop(string _name)
        {
            if (allShops.Any(shop => shop.name == _name))
                throw new ArgumentException($"Duplicate shop {_name} not allowed!");

            this.name = _name;
            this.isFiltered = false;

            allShops.Add(this);
        }


        public string Name
        {
            get { return name; }
        }

        public bool IsFiltered
        {
            get { return isFiltered; }
            set { isFiltered = value; }
        }

        public static List<Shop> AllShops
        {
            get { return allShops; }
        }

        public static void DisableAllFilters()
        {
            allShops.ForEach(shop => shop.isFiltered = false);
        }
    }
}