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

namespace CoffeeLover.Pages.Customer_Payment_methods
{
    public class IndexModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public IndexModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer_Payment_Method> Customer_Payment_Method { get;set; }

        public async Task OnGetAsync()
        {
            Customer_Payment_Method = await _context.Customer_Payment_Method.ToListAsync();
        }
    }
}
