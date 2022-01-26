using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoffeeLover.Models;

namespace CoffeeLover.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CoffeeLover.Models.Address> Address { get; set; }
        public DbSet<CoffeeLover.Models.Cashier> Cashier { get; set; }
        public DbSet<CoffeeLover.Models.Customer> Customer { get; set; }
        public DbSet<CoffeeLover.Models.Customer_Payment_Method> Customer_Payment_Method { get; set; }
        public DbSet<CoffeeLover.Models.Order> Order { get; set; }
        public DbSet<CoffeeLover.Models.OrderItems> OrderItems { get; set; }
        public DbSet<CoffeeLover.Models.Products> Products { get; set; }
        public DbSet<CoffeeLover.Models.Supplier> Supplier { get; set; }
    }
}