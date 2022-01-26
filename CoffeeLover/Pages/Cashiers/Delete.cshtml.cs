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

namespace CoffeeLover.Pages.Cashiers
{
    public class DeleteModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public DeleteModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cashier Cashier { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cashier = await _context.Cashier.FirstOrDefaultAsync(m => m.StaffID == id);

            if (Cashier == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cashier = await _context.Cashier.FindAsync(id);

            if (Cashier != null)
            {
                _context.Cashier.Remove(Cashier);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
