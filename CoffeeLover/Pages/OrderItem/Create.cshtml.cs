#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoffeeLover.Data;
using CoffeeLover.Models;

namespace CoffeeLover.Pages.OrderItem
{
    public class CreateModel : PageModel
    {
        private readonly CoffeeLover.Data.ApplicationDbContext _context;

        public CreateModel(CoffeeLover.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public OrderItems OrderItems { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderItems.Add(OrderItems);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
