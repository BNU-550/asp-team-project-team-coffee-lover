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

namespace CoffeeLover.Pages.OrderItem
{
    public class EditModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public EditModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OrderItems OrderItems { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderItems = await _context.OrderItems.FirstOrDefaultAsync(m => m.OrderID == id);

            if (OrderItems == null)
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

            _context.Attach(OrderItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemsExists(OrderItems.OrderID))
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

        private bool OrderItemsExists(int id)
        {
            return _context.OrderItems.Any(e => e.OrderID == id);
        }
    }
}
