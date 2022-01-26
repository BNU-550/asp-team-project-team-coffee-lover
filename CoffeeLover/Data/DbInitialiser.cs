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
            AddAddress(context);
            AddCashier(context);
            AddCustomer_Payment_Method(context);
            AddSupplier(context);
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
                    ProductName = "Cappachino",
                    Description = "A throthy cappachino.",
                    ImageURL = "Cappachino.jpg",
                    Price = 3.2m,
                    SupplierID = 42
                },

                new Products
                {
                    ProductID = "5479",
                    ProductName = "Expresso",
                    Description = "An energising expresso.",
                    ImageURL = "Expresso.jpg",
                    Price = 1.65m,
                    SupplierID = 86
                },

                new Products
                {
                    ProductID = "4863",
                    ProductName = "Muffin",
                    Description = "A rich hot chocolate.",
                    ImageURL = "Muffin.jpg",
                    Price = 2.2m,
                    SupplierID = 42
                },

                new Products
                {
                    ProductID = "6894",
                    ProductName = "Sausage Muffin",
                    Description = "A sausage muffin with tomato sauce.",
                    ImageURL = "Sausage.jpg",
                    Price = 3.6m,
                    SupplierID = 86
                },

                new Products
                {
                    ProductID = "6289",
                    ProductName = "Tea",
                    Description = "A pleasent tea.",
                    ImageURL = "Tea.jpg",
                    Price = 1.9m,
                    SupplierID = 85
                },

                new Products
                {
                    ProductID = "4239",
                    ProductName = "Toastie",
                    Description = "A toastie with your choice of filling.",
                    ImageURL = "Toastie.jpg",
                    Price = 3.8m,
                    SupplierID = 86
                },
            };
            context.Products.AddRange(product);
            context.SaveChanges();
        }

        private static void AddAddress(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }
            var address = new Address[]
            {
                new Address
                {
                    AddressID = 320,
                    Line1Address = "9 Charlie road",
                    City = "London",
                    Postcode = "PJ96K21"
                },

                new Address
                {
                    AddressID = 279,
                    Line1Address = "2 lay's line",
                    City = "Aylesbury",
                    Postcode = "KW49PNK"
                },

                new Address
                {
                    AddressID = 592,
                    Line1Address = "8 Harold's cross",
                    City = "Wycombe",
                    Postcode = "LK600OM"
                },
        
            };
            context.Address.AddRange(address);
            context.SaveChanges();


        }
        private static void AddCashier(ApplicationDbContext context)
        {
            if (context.Cashier.Any())
            {
                return;
            }
            var cashier = new Cashier[]
            {
                new Cashier
                {
                    OrderItemsOrderID = 40,
                    OrderItemsProductsID = 51,
                    StaffID = 4920,
                    FirstName = "Harry",
                    LastName =  "Edward",
                    Email = "Harry.Edward5920@Gmail.com"
                },

                new Cashier
                {
                    OrderItemsOrderID = 89,
                    OrderItemsProductsID = 28,
                    StaffID = 4256,
                    FirstName = "Quinn",
                    LastName =  "Lots",
                    Email = "Quinn.Lots1@gmail.com"
                },

                new Cashier
                {
                    OrderItemsOrderID = 27,
                    OrderItemsProductsID = 51,
                    StaffID = 4928,
                    FirstName = "Luke",
                    LastName =  "Ray",
                    Email = "Luke.Ray85@Gmail.com"
                },

            };
            context.Cashier.AddRange(cashier);
            context.SaveChanges();
        }
        private static void AddCustomer_Payment_Method(ApplicationDbContext context)
        {
            if (context.Customer_Payment_Method.Any())
            {
                return;
            }
            var paymentMethod = new Customer_Payment_Method[]
            {
                new Customer_Payment_Method
                {
                    PaymentMethodCode = 40,
                    CardNumber = "4024007143009966",
                    DateOfPurcahse = DateTime.Now,
                    Total = 13.32m,
                    BillNumber = 50
                },

                new Customer_Payment_Method
                {
                    PaymentMethodCode = 41,
                    CardNumber = "4539631764497479",
                    DateOfPurcahse = DateTime.Now,
                    Total = 4.89m,
                    BillNumber = 51
                },

                new Customer_Payment_Method
                {
                    PaymentMethodCode = 40,
                    CardNumber = "4916547519530542",
                    DateOfPurcahse = DateTime.Now,
                    Total = 8.69m,
                    BillNumber = 52
                },
            };
            context.Customer_Payment_Method.AddRange(paymentMethod);
            context.SaveChanges();
        }

        private static void AddSupplier(ApplicationDbContext context)
        {
            if (context.Supplier.Any())
            {
                return;
            }
            var supplier = new Supplier[]
            {
                new Supplier
                {
                    Name = "Coffee & Co",
                    Contact = "441414960568",
                    Email = "Coffee.co@gmail.com",
                    SupplierID = 34
                },

                new Supplier
                {
                    Name = "Wycombe food",
                    Contact = "441214960948",
                    Email = "Wycombe.food@gmail.com",
                    SupplierID = 35
                },

                new Supplier
                {
                    Name = "Aylesbury Tea",
                    Contact = "83",
                    Email = "Aylesbury.Tea@gmail.com",
                    SupplierID = 36
                }

    };
            context.Supplier.AddRange(supplier);
            context.SaveChanges();
        }
}
} 