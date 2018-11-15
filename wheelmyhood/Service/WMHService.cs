using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WheelMyHood.Data;
using WheelMyHood.Models;
//using ImageMagick;

namespace WheelMyHood.Service
{
    public class WMHService : IWMHService
    {
        private readonly WmhDbContext _wmhDbContext;
        //private readonly string _folder;


        public WMHService(WmhDbContext wmhDbContext, IHostingEnvironment env)
        {
            _wmhDbContext = wmhDbContext;
        }

        //  Queries
        public async Task<IEnumerable<Region>> GetRegionsAsync(int count, int skip = 0)
        {
            var regions = await _wmhDbContext.Regions
                .AsNoTracking()
                .Skip(skip)
                .Take(count).ToListAsync();

            return regions;
        }

        public async Task<List<Region>> GetRegionsDropList()
        {
            var regions = await _wmhDbContext.Regions.AsNoTracking().ToListAsync();
            return regions;
        }

        public async Task<Region> GetRegionAsync(string regionCode)
        {
            var region = await _wmhDbContext.Regions.FirstOrDefaultAsync(x => x.RegionCode == regionCode);
            return region;
        }

        public async Task<IEnumerable<City>> GetCitiesAsync(int count, int skip = 0)
        {
            var cities = await _wmhDbContext.Cities
                .Include(x => x.Region)
                .AsNoTracking()
                .Skip(skip)
                .Take(count).ToListAsync();

            return cities;
        }

        public async Task<City> GetCityAsync(string cityCode)
        {
            var city = await _wmhDbContext.Cities
                .Include(x => x.Region)
                .FirstOrDefaultAsync(x => x.CityCode == cityCode);
            return city;
        }

        //  Persistence

        public async Task SaveRegionAsync(Region region)
        {
            _wmhDbContext.Regions.Add(region);
            await _wmhDbContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateRegionAsync(Region region)
        {
            try
            {
                _wmhDbContext.Update(region);
                await _wmhDbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegionExists(region.RegionCode))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task SaveCityAsync(City city)
        {
            _wmhDbContext.Cities.Add(city);
            await _wmhDbContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateCityAsync(City city)
        {
            try
            {
                _wmhDbContext.Update(city);
                await _wmhDbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(city.CityCode))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }



        //  Helpers
        private bool RegionExists(string regionCode)
        {
            return _wmhDbContext.Regions.Any(x => x.RegionCode == regionCode);
        }

        private bool CityExists(string cityCode)
        {
            return _wmhDbContext.Cities.Any(x => x.CityCode == cityCode);
        }
    }
}
