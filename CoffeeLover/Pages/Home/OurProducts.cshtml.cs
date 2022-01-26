using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoffeeLover.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoffeeLover.Pages.Home
{
    public class ExploreModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public ExploreModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
