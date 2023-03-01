using System;
using System.Collections.Generic;
namespace ShoppingListApp.src
{
    /// <summary>
    /// Represents a shop.
    /// </summary>
    public class Shop
    {
        private static List<Shop> allShops = new List<Shop>(); // list of all available shops in the app

        private readonly string name;
        private bool isFiltered;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shop"/> class with the specified name.
        /// </summary>
        /// <param name="_name">The name of the shop.</param>
        /// <exception cref="ArgumentException">Thrown when a shop with the same name already exists.</exception>
        public Shop(string _name)
        {
            if (allShops.Any(shop => shop.name == _name))
                throw new ArgumentException($"Duplicate shop {_name} not allowed!");

            this.name = _name;
            this.isFiltered = false;

            allShops.Add(this);
        }


        /// <summary>
        /// Gets the name of the shop.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the shop is filtered.
        /// </summary>
        public bool IsFiltered
        {
            get { return isFiltered; }
            set { isFiltered = value; }
        }

        /// <summary>
        /// Gets a list of every shop object created.
        /// </summary>
        public static List<Shop> AllShops
        {
            get { return allShops; }
        }

        /// <summary>
        /// Disables filtering for all shop objects created.
        /// </summary>
        public static void DisableAllFilters()
        {
            allShops.ForEach(shop => shop.isFiltered = false);
        }
    }
}
