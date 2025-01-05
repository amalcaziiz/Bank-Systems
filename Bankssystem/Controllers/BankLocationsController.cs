using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bankssystem.Data;
using Bankssystem.Models;

namespace Bankssystem.Controllers
{
    public class BankLocationsController : Controller
    {
        private readonly WebDbContext _context;

        public BankLocationsController(WebDbContext context)
        {
            _context = context;
        }

        // GET: BankLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.TBL_BankLocation.ToListAsync());
        }

        // GET: BankLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankLocation = await _context.TBL_BankLocation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankLocation == null)
            {
                return NotFound();
            }

            return View(bankLocation);
        }

        // GET: BankLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BankLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BranchName,Address,PhoneNumber,EstablishedDate")] BankLocation bankLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankLocation);
        }

        // GET: BankLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankLocation = await _context.TBL_BankLocation.FindAsync(id);
            if (bankLocation == null)
            {
                return NotFound();
            }
            return View(bankLocation);
        }

        // POST: BankLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BranchName,Address,PhoneNumber,EstablishedDate")] BankLocation bankLocation)
        {
            if (id != bankLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankLocationExists(bankLocation.Id))
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
            return View(bankLocation);
        }

        // GET: BankLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankLocation = await _context.TBL_BankLocation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankLocation == null)
            {
                return NotFound();
            }

            return View(bankLocation);
        }

        // POST: BankLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bankLocation = await _context.TBL_BankLocation.FindAsync(id);
            if (bankLocation != null)
            {
                _context.TBL_BankLocation.Remove(bankLocation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankLocationExists(int id)
        {
            return _context.TBL_BankLocation.Any(e => e.Id == id);
        }
    }
}
