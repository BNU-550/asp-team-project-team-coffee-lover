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
using Microsoft.AspNetCore.Authorization;

namespace CoffeeLover.Pages.Home
{
    [Authorize]
    public class MyAccountModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public MyAccountModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            string name = User.Identity.Name;


            Customer = await _context.Customer
                .Include (p => p.Address)
                .Include(p => p.FirstName)
                .FirstOrDefaultAsync(m => m.Email== name);


            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
