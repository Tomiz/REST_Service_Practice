using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_Service_Practice
{
    /// <summary>
    /// Step 2: Preparing the data to return
    /// </summary>
    public class ProductSingleton
    {
        private static readonly ProductSingleton _instance = new ProductSingleton();
        
        private ProductSingleton() { }

        public static ProductSingleton Instance
        {
            get { return _instance; }
        }

        public List<Product> ProductList
        {
            get { return productItemList;  }
        }

        private List<Product> productItemList = new List<Product>()
        {
            new Product() {Id = 1, Name = "product 1", CategoryName = "category 1", Price = 10},
            new Product() {Id = 2, Name = "product 2", CategoryName = "category 2", Price = 15},
            new Product() {Id = 3, Name = "product 3", CategoryName = "category 3", Price = 20},
            new Product() {Id = 4, Name = "product 4", CategoryName = "category 4", Price = 25}
        };

    }
}