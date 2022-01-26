using CoffeeLover.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeLover.Data
{
    public static class DbInitialiser
    {
        /// <summary>
        /// Initialises the database with seeded data, calling each method to
        /// create test data for each model. 
        /// </summary>
        public static void Initialise(ApplicationDbContext context)
        {
            AddProduct(context);

        }

        private static void AddProduct(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }
            var product = new Products[]
            {
                new Products
                {
                    ProductID = "2031",
                    ProductName = "Hot Chocolate",
                    Description = "A light hot chocolate to warm you up",
                    ImageURL = "HotChocolate.jpg",
                    Price = 2.10m,
                    SupplierID = 55
                },

                new Products
                {
                    ProductID = "2586",
                    ProductName = "Tea",
                    Description = "A relaxing tea to calm you down.",
                    ImageURL = "Tea.jpg",
                    Price = 1.2m,
                    SupplierID = 51
                },

                new Products
                {
                    ProductID = "2469",
                    ProductName = "Coffee",
                    Description = "A coffee with the richest of beans.",
                    ImageURL = "Cofffe.jpg",
                    Price = 2.40m,
                    SupplierID = 52
                },

                new Products
                {
                    ProductID = "9648",
                    ProductName = "Coffee",
                    Description = "A coffee with the richest of beans.",
                    ImageURL = "Cofffe.jpg",
                    Price = 2.40m,
                    SupplierID = 52
                },
            };
            context.Products.AddRange(product);
            context.SaveChanges();
        }
    }
}