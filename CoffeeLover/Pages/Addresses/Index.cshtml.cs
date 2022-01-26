#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoffeeLover.Data;
using CoffeeLover.Models;

namespace CoffeeLover.Pages.Addresses
{
    public class IndexModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public IndexModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Address> Address { get;set; }

        public async Task OnGetAsync()
        {
            Address = await _context.Address.ToListAsync();
        }
    }
}
