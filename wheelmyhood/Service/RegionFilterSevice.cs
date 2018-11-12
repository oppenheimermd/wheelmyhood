using Microsoft.Extensions.Caching.Memory;
using WheelMyHood.Models;
using System.Collections.Generic;

namespace WheelMyHood.Service
{
    public interface ICityService
    {
        List<CityTmp> ReadAll();
    }

    public class RegionFilterSevice : ICityService
    {
        private readonly IMemoryCache _cache;

        public RegionFilterSevice(IMemoryCache cache)
        {
            _cache = cache;
        }

        public List<CityTmp> ReadAll()
        {
            if (_cache.Get("CityTmpList") != null) return _cache.Get<List<CityTmp>>("CityTmpList");
            List<CityTmp> cities = new List<CityTmp>{
                new CityTmp {City = "Aachen", Country = "Germany", Region = "Europe"},
                new CityTmp {City = "Aberdeen", Country = "United Kingdom", Region = "Europe"},
                new CityTmp {City = "Amsterdam", Country = "Netherlands", Region = "Europe"},
                new CityTmp {City = "Athens", Country = "Greece", Region = "Europe"},
                new CityTmp {City = "Aveiro", Country = "Pourtagal", Region = "Europe"},
                new CityTmp {City = "Barcelona", Country = "Spain", Region = "Europe"},
                new CityTmp {City = "Berlin", Country = "Germany", Region = "Europe"},
                new CityTmp {City = "Bordeaux", Country = "France", Region = "Europe"},
                new CityTmp {City = "Bournemouth", Country = "United Kingdom", Region = "Europe"},
                new CityTmp {City = "Brighton", Country = "United Kingdom", Region = "Europe"},
                new CityTmp {City = "Budapest", Country = "Hungary", Region = "Europe"},
                new CityTmp {City = "London", Country = "United Kingdom", Region = "Europe"},
                new CityTmp {City = "Utrecht", Country = "Netherlands", Region = "Europe"},
                new CityTmp {City = "Paris", Country = "France", Region = "Europe"},
                new CityTmp {City = "Milan", Country = "Italy", Region = "Europe"},
                new CityTmp {City = "Rome", Country = "Italy", Region = "Europe"},
                new CityTmp {City = "Washington DC", Country = "United States", Region = "North America"},
                new CityTmp {City = "St. Louis, Missouri", Country = "United States", Region = "North America"},
                new CityTmp {City = "Seattle, Washington", Country = "United States", Region = "North America"},
                new CityTmp {City = "San Francisco, California", Country = "United States", Region = "North America"},
                new CityTmp {City = "San Diego, California", Country = "United States", Region = "North America"},
                new CityTmp {City = "Salt Lake City, Utah", Country = "United States", Region = "North America"},
                new CityTmp {City = "Rochester, New York", Country = "United States", Region = "North America"},
                new CityTmp {City = "Richmond, Virgina", Country = "United States", Region = "North America"},
                new CityTmp {City = "Philadelphia, Pennsylvania", Country = "United States", Region = "North America"},
                new CityTmp {City = "Pittsburgh, Pennsylvania", Country = "United States", Region = "North America"},
                new CityTmp {City = "Nashville, Tennessee", Country = "United States", Region = "North America"},
                new CityTmp {City = "Miami, Flordia", Country = "United States", Region = "North America"},
                new CityTmp {City = "Los Angeles, California", Country = "United States", Region = "North America"},
                new CityTmp {City = "Las Vegas, Nevada", Country = "United States", Region = "North America"},
                new CityTmp {City = "Houston, Texas", Country = "United States", Region = "North America"},
                new CityTmp {City = "Grand Rapids, Michigan", Country = "United States", Region = "North America"},
                new CityTmp {City = "Fort Lauderdale", Country = "United States", Region = "North America"},
                new CityTmp {City = "Detroit, Michigan", Country = "United States", Region = "North America"},
                new CityTmp {City = "Denver, Colorado", Country = "United States", Region = "North America"},
                new CityTmp {City = "Chicago, Illinois", Country = "United States", Region = "North America"},
                new CityTmp {City = "Boston, Massachusetts", Country = "United States", Region = "North America"},
                new CityTmp {City = "Atlanta, Geogia", Country = "United States", Region = "North America"},
                new CityTmp {City = "Bogota", Country = "Colombia", Region = "SouthAmerica"},
                new CityTmp {City = "Buenos Aires", Country = "Argentia", Region = "SouthAmerica"},
                new CityTmp {City = "Mexico City", Country = "", Region = "SouthAmerica"},
                new CityTmp {City = "Montreal", Country = "Canada", Region = "North America"},
                new CityTmp {City = "Ottawa", Country = "Canada", Region = "North America"},
                new CityTmp {City = "Toronto", Country = "Canada", Region = "North America"},
                new CityTmp {City = "Vancouver", Country = "Canada", Region = "North America"},
                new CityTmp {City = "Victoria", Country = "Canada", Region = "North America"},
                new CityTmp {City = "Perth", Country = "Australia", Region = "Oceania"},
                new CityTmp {City = "Melbourne", Country = "Australia", Region = "Oceania"},
                new CityTmp {City = "Sydney", Country = "Australia", Region = "Oceania"},
                new CityTmp {City = "Auckland", Country = "New Zealand", Region = "Oceania"},
                new CityTmp {City = "Queenstown", Country = "New Zealand", Region = "Oceania"},
                new CityTmp {City = "Hong Kong", Country = "Hong Kong", Region = "Asia"},
                new CityTmp {City = "New Delhi", Country = "India", Region = "Asia"},
                new CityTmp {City = "Shenzhen", Country = "China", Region = "Asia"},
                new CityTmp {City = "Singapore", Country = "Singapore", Region = "Asia"},
                new CityTmp {City = "Taipei", Country = "Taiwan", Region = "Asia"},
                new CityTmp {City = "Tokoyo", Country = "Japan", Region = "Asia"}
            };
            _cache.Set("CityTmpList", cities);
            return _cache.Get<List<CityTmp>>("CityTmpList");
        }
    }
}
