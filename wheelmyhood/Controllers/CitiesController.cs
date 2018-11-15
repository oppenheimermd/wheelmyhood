using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheelMyHood.Data;
using WheelMyHood.Models;
using WheelMyHood.Service;

namespace wheelmyhood.Controllers
{
    public class CitiesController : Controller
    {
        private readonly WmhDbContext _context;
        private readonly IWMHService _wmhService;

        public CitiesController(IWMHService wmhService)
        {
            _wmhService = wmhService;
        }

        // GET: Cities
        public async Task<IActionResult> Index()
        {
            var cities = await _wmhService.GetCitiesAsync(12, 0);
            return View(cities);
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _wmhService.GetCityAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // GET: Cities/Create
        public async Task<IActionResult> Create()
        {
            var ddRegionList = await _wmhService.GetRegionsDropList();
            ViewData["ContinentCode"] = new SelectList(ddRegionList, "RegionCode", "ContinentName");
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CityCode,CityName,ContinentCode")] City city)
        {
            if (ModelState.IsValid)
            {
                await _wmhService.SaveCityAsync(city);
                return RedirectToAction(nameof(Index));
            }
            var ddRegionList = await _wmhService.GetRegionsDropList();
            ViewData["ContinentCode"] = new SelectList(ddRegionList, "RegionCode", "ContinentName");
            return View(city);
        }

        // GET: Cities/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _wmhService.GetCityAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            var ddRegionList = await _wmhService.GetRegionsDropList();
            ViewData["ContinentCode"] = new SelectList(ddRegionList, "RegionCode", "ContinentName");
            return View(city);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CityCode,CityName,ContinentCode")] City city)
        {
            if (id != city.CityCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _wmhService.UpdateCityAsync(city);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContinentCode"] = new SelectList(_context.Regions, "RegionCode", "RegionCode", city.ContinentCode);
            return View(city);
        }

        // GET: Cities/Delete/5
        /*public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .Include(c => c.Region)
                .FirstOrDefaultAsync(m => m.CityCode == id);
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var city = await _context.Cities.FindAsync(id);
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */
    }
}
