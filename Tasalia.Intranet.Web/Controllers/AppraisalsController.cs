using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tasalia.Intranet.DataBase.Models;

namespace Tasalia.Intranet.Web.Controllers
{
    public class AppraisalsController : Controller
    {
        private readonly TasaliaContext _context;

        public AppraisalsController()
        {
            _context = new TasaliaContext();
        }

        // GET: Appraisals
        public async Task<IActionResult> Index()
        {
            var tasaliaContext = _context.Appraisal.Include(a => a.Deputation).Include(a => a.Property);
            return View(await tasaliaContext.ToListAsync());
        }

        // GET: Appraisals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appraisal = await _context.Appraisal
                .Include(a => a.Deputation)
                .Include(a => a.Property)
                .FirstOrDefaultAsync(m => m.AppraisalId == id);
            if (appraisal == null)
            {
                return NotFound();
            }

            return View(appraisal);
        }

        // GET: Appraisals/Create
        public IActionResult Create()
        {
            ViewData["DeputationId"] = new SelectList(_context.Deputation, "DeputationId", "DeputationId");
            ViewData["PropertyId"] = new SelectList(_context.Property, "PropertyId", "PropertyId");
            return View();
        }

        // POST: Appraisals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppraisalId,ProcessGuid,Number,PropertyId,Supplement,DeputationId,CreateDate,UpdateDate")] Appraisal appraisal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appraisal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeputationId"] = new SelectList(_context.Deputation, "DeputationId", "DeputationId", appraisal.DeputationId);
            ViewData["PropertyId"] = new SelectList(_context.Property, "PropertyId", "PropertyId", appraisal.PropertyId);
            return View(appraisal);
        }

        // GET: Appraisals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appraisal = await _context.Appraisal.FindAsync(id);
            if (appraisal == null)
            {
                return NotFound();
            }
            ViewData["DeputationId"] = new SelectList(_context.Deputation, "DeputationId", "DeputationId", appraisal.DeputationId);
            ViewData["PropertyId"] = new SelectList(_context.Property, "PropertyId", "PropertyId", appraisal.PropertyId);
            return View(appraisal);
        }

        // POST: Appraisals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppraisalId,ProcessGuid,Number,PropertyId,Supplement,DeputationId,CreateDate,UpdateDate")] Appraisal appraisal)
        {
            if (id != appraisal.AppraisalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appraisal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppraisalExists(appraisal.AppraisalId))
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
            ViewData["DeputationId"] = new SelectList(_context.Deputation, "DeputationId", "DeputationId", appraisal.DeputationId);
            ViewData["PropertyId"] = new SelectList(_context.Property, "PropertyId", "PropertyId", appraisal.PropertyId);
            return View(appraisal);
        }

        // GET: Appraisals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appraisal = await _context.Appraisal
                .Include(a => a.Deputation)
                .Include(a => a.Property)
                .FirstOrDefaultAsync(m => m.AppraisalId == id);
            if (appraisal == null)
            {
                return NotFound();
            }

            return View(appraisal);
        }

        // POST: Appraisals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appraisal = await _context.Appraisal.FindAsync(id);
            _context.Appraisal.Remove(appraisal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppraisalExists(int id)
        {
            return _context.Appraisal.Any(e => e.AppraisalId == id);
        }
    }
}
