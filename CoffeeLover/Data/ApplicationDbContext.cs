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
    }
}