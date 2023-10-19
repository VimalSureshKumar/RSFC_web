using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RSFC_web.Data;
using RSFC_web.Models;

namespace RSFC_web.Controllers
{
    [Authorize]
    public class PlayersController : Controller
    {
        private readonly RSFC_webContext _context;

        public PlayersController(RSFC_webContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index()
        {
            var rSFC_webContext = _context.Player.Include(p => p.Coaches).Include(p => p.Positions).Include(p => p.Teams);
            return View(await rSFC_webContext.ToListAsync());
        }

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Player == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .Include(p => p.Coaches)
                .Include(p => p.Positions)
                .Include(p => p.Teams)
                .FirstOrDefaultAsync(m => m.PlayerId == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            ViewData["CoachId"] = new SelectList(_context.Coach, "CoachId", "Coach_Email");
            ViewData["PositionId"] = new SelectList(_context.Position, "PositionId", "Position_Name");
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "Team_Name");
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlayerId,Player_Name,Player_Gender,Player_Dob,Player_Phone_Number,Player_Email,CoachId,TeamId,PositionId")] Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoachId"] = new SelectList(_context.Coach, "CoachId", "Coach_Email", player.CoachId);
            ViewData["PositionId"] = new SelectList(_context.Position, "PositionId", "Position_Name", player.PositionId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "Team_Name", player.TeamId);
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Player == null)
            {
                return NotFound();
            }

            var player = await _context.Player.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            ViewData["CoachId"] = new SelectList(_context.Coach, "CoachId", "Coach_Email", player.CoachId);
            ViewData["PositionId"] = new SelectList(_context.Position, "PositionId", "Position_Name", player.PositionId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "Team_Name", player.TeamId);
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlayerId,Player_Name,Player_Gender,Player_Dob,Player_Phone_Number,Player_Email,CoachId,TeamId,PositionId")] Player player)
        {
            if (id != player.PlayerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.PlayerId))
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
            ViewData["CoachId"] = new SelectList(_context.Coach, "CoachId", "Coach_Email", player.CoachId);
            ViewData["PositionId"] = new SelectList(_context.Position, "PositionId", "Position_Name", player.PositionId);
            ViewData["TeamId"] = new SelectList(_context.Team, "TeamId", "Team_Name", player.TeamId);
            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Player == null)
            {
                return NotFound();
            }

            var player = await _context.Player
                .Include(p => p.Coaches)
                .Include(p => p.Positions)
                .Include(p => p.Teams)
                .FirstOrDefaultAsync(m => m.PlayerId == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Player == null)
            {
                return Problem("Entity set 'RSFC_webContext.Player'  is null.");
            }
            var player = await _context.Player.FindAsync(id);
            if (player != null)
            {
                _context.Player.Remove(player);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
          return (_context.Player?.Any(e => e.PlayerId == id)).GetValueOrDefault();
        }
    }
}
