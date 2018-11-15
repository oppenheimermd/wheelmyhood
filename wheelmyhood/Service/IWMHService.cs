using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelMyHood.Models;

namespace WheelMyHood.Service
{
    // ReSharper disable once InconsistentNaming
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

        /// <summary>
        /// Returns a list collection of <see cref="Region"/> for our dropdown control used
        /// in view
        /// </summary>
        /// <returns></returns>
        Task<List<Region>> GetRegionsDropList();

        /// <summary>
        /// Get a specific instance of a <see cref="Region"/> entity
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        Task<Region> GetRegionAsync(string regionCode);

        /// <summary>
        /// Get's pageable List of cities <see cref="City"/> includes <see cref="Region"/>
        /// </summary>
        /// <param name="count"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        Task<IEnumerable<City>> GetCitiesAsync(int count, int skip = 0);

        /// <summary>
        /// Returns a <see cref="City"/> entity
        /// </summary>
        /// <param name="cityCode"></param>
        /// <returns></returns>
        Task<City> GetCityAsync(string cityCode);


        //  Create / Update

        /// <summary>
        /// Add a <see cref="City"/> <see cref="Region"/>
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        Task SaveRegionAsync(Region region);

        /// <summary>
        /// Edit <see cref="Region"/> entity
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        Task<bool> UpdateRegionAsync(Region region);

        /// <summary>
        /// Add <see cref="City"/> to database
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        Task SaveCityAsync(City city);

        /// <summary>
        /// Edit <see cref="City"/> entity
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        Task<bool> UpdateCityAsync(City city);
    }
}
