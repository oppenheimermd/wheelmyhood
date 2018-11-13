using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelMyHood.Models;

namespace WheelMyHood.Service
{
    public interface IWMHService
    {
        //  Queries

        /// <summary>
        /// Get all <see cref="Region"/> by page count
        /// </summary>
        /// <param name="count"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        Task<IEnumerable<Region>> GetRegionsAsync(int count, int skip = 0);


        //  Create / Update

        /// <summary>
        /// Add a <see cref="City"/> <see cref="Region"/>
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        Task SaveRegionAsync(Region region);
    }
}
