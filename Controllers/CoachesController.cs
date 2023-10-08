using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RSFC_web.Data;
using RSFC_web.Models;

namespace RSFC_web.Controllers
{
    public class CoachesController : Controller
    {
        private readonly RSFC_webContext _context;

        public CoachesController(RSFC_webContext context)
        {
            _context = context;
        }

        // GET: Coaches
        public async Task<IActionResult> Index()
        {
              return _context.Coach != null ? 
                          View(await _context.Coach.ToListAsync()) :
                          Problem("Entity set 'RSFC_webContext.Coach'  is null.");
        }

        // GET: Coaches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach
                .FirstOrDefaultAsync(m => m.CoachId == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        // GET: Coaches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coaches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoachId,Coach_Name,Coach_Phone_Number,Coach_Email,Coach_Nationality")] Coach coach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coach);
        }

        // GET: Coaches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach.FindAsync(id);
            if (coach == null)
            {
                return NotFound();
            }
            return View(coach);
        }

        // POST: Coaches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoachId,Coach_Name,Coach_Phone_Number,Coach_Email,Coach_Nationality")] Coach coach)
        {
            if (id != coach.CoachId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachExists(coach.CoachId))
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
            return View(coach);
        }

        // GET: Coaches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Coach == null)
            {
                return NotFound();
            }

            var coach = await _context.Coach
                .FirstOrDefaultAsync(m => m.CoachId == id);
            if (coach == null)
            {
                return NotFound();
            }

            return View(coach);
        }

        // POST: Coaches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Coach == null)
            {
                return Problem("Entity set 'RSFC_webContext.Coach'  is null.");
            }
            var coach = await _context.Coach.FindAsync(id);
            if (coach != null)
            {
                _context.Coach.Remove(coach);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoachExists(int id)
        {
          return (_context.Coach?.Any(e => e.CoachId == id)).GetValueOrDefault();
        }
    }
}
