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

        public async Task SaveRegionAsync(Region region)
        {
            _wmhDbContext.Regions.Add(region);
            await _wmhDbContext.SaveChangesAsync();
        }
    }
}
