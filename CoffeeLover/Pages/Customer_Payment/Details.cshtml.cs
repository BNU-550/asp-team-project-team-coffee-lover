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

namespace CoffeeLover.Pages.Customer_Payment
{
    public class DetailsModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public DetailsModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer_Payment_Method Customer_Payment_Method { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_Payment_Method = await _context.Customer_Payment_Method.FirstOrDefaultAsync(m => m.PaymentMethodCode == id);

            if (Customer_Payment_Method == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
