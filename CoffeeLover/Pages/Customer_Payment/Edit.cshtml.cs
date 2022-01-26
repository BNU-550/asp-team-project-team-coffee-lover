#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoffeeLover.Data;
using CoffeeLover.Models;

namespace CoffeeLover.Pages.Customer_Payment
{
    public class EditModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public EditModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customer_Payment_Method).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer_Payment_MethodExists(Customer_Payment_Method.PaymentMethodCode))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Customer_Payment_MethodExists(int id)
        {
            return _context.Customer_Payment_Method.Any(e => e.PaymentMethodCode == id);
        }
    }
}
