#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoffeeLover.Data;
using CoffeeLover.Models;

namespace CoffeeLover.Pages
{
    public class CashiersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CashiersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cashiers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cashier.ToListAsync());
        }

        // GET: Cashiers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cashier = await _context.Cashier
                .FirstOrDefaultAsync(m => m.StaffID == id);
            if (cashier == null)
            {
                return NotFound();
            }

            return View(cashier);
        }

        // GET: Cashiers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cashiers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderItemsOrderID,OrderItemsProductsID,StaffID,FirstName,LastName,Email")] Cashier cashier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cashier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cashier);
        }

        // GET: Cashiers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cashier = await _context.Cashier.FindAsync(id);
            if (cashier == null)
            {
                return NotFound();
            }
            return View(cashier);
        }

        // POST: Cashiers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderItemsOrderID,OrderItemsProductsID,StaffID,FirstName,LastName,Email")] Cashier cashier)
        {
            if (id != cashier.StaffID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cashier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CashierExists(cashier.StaffID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cashier);
        }

        // GET: Cashiers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cashier = await _context.Cashier
                .FirstOrDefaultAsync(m => m.StaffID == id);
            if (cashier == null)
            {
                return NotFound();
            }

            return View(cashier);
        }

        // POST: Cashiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cashier = await _context.Cashier.FindAsync(id);
            _context.Cashier.Remove(cashier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CashierExists(int id)
        {
            return _context.Cashier.Any(e => e.StaffID == id);
        }
    }
}
