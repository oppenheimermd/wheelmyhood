using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WheelMyHood.Models;
using WheelMyHood.Service;

namespace WheelMyHood.Controllers
{
    public class RegionController : Controller
    {
        private readonly IWMHService _wmhService;

        public RegionController(IWMHService wmhService)
        {
            _wmhService = wmhService;
        }

        // GET: Regions
        public async Task<IActionResult> Index()
        {
            var regions = await _wmhService.GetRegionsAsync(12, 0);
            return View(regions.ToList());
        }

        // GET: Region/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Region/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegionCode,ContinentName")] Region region)
        {
            if (ModelState.IsValid)
            {
                await _wmhService.SaveRegionAsync(region);
                return RedirectToAction(nameof(Index));
            }
            return View(region);
        }
    }
}
