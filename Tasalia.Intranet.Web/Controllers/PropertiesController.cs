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
    public class PropertiesController : Controller
    {
        private readonly TasaliaContext _context;

        public PropertiesController()
        {
            _context = new TasaliaContext();
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            var tasaliaContext = _context.Property.Include(c => c.City).Include(c => c.FileType).Include(c => c.PostalZone);
            return View(await tasaliaContext.ToListAsync());
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property
                .Include(c => c.City)
                .Include(c => c.FileType)
                .Include(c => c.PostalZone)
                .FirstOrDefaultAsync(m => m.PropertyId == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewData["CityId"] = new SelectList(_context.City, "CityId", "CityId");
            ViewData["FileTypeId"] = new SelectList(_context.FileType, "FileTypeId", "FileTypeId");
            ViewData["PostalZoneId"] = new SelectList(_context.PostalZone, "PostalZoneId", "PostalZoneId");
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyId,ProcessGuid,ExternalId,Year,CreateDate,UpdateDate,PostalZoneId,CityId,FileTypeId,Latitude,Longitude")] Property @property)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CityId"] = new SelectList(_context.City, "CityId", "CityId", @property.CityId);
            ViewData["FileTypeId"] = new SelectList(_context.FileType, "FileTypeId", "FileTypeId", @property.FileTypeId);
            ViewData["PostalZoneId"] = new SelectList(_context.PostalZone, "PostalZoneId", "PostalZoneId", @property.PostalZoneId);
            return View(@property);
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.City, "CityId", "CityId", @property.CityId);
            ViewData["FileTypeId"] = new SelectList(_context.FileType, "FileTypeId", "FileTypeId", @property.FileTypeId);
            ViewData["PostalZoneId"] = new SelectList(_context.PostalZone, "PostalZoneId", "PostalZoneId", @property.PostalZoneId);
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyId,ProcessGuid,ExternalId,Year,CreateDate,UpdateDate,PostalZoneId,CityId,FileTypeId,Latitude,Longitude")] Property @property)
        {
            if (id != @property.PropertyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyId))
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
            ViewData["CityId"] = new SelectList(_context.City, "CityId", "CityId", @property.CityId);
            ViewData["FileTypeId"] = new SelectList(_context.FileType, "FileTypeId", "FileTypeId", @property.FileTypeId);
            ViewData["PostalZoneId"] = new SelectList(_context.PostalZone, "PostalZoneId", "PostalZoneId", @property.PostalZoneId);
            return View(@property);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property
                .Include(c => c.City)
                .Include(c => c.FileType)
                .Include(c => c.PostalZone)
                .FirstOrDefaultAsync(m => m.PropertyId == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @property = await _context.Property.FindAsync(id);
            _context.Property.Remove(@property);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
            return _context.Property.Any(e => e.PropertyId == id);
        }
    }
}
