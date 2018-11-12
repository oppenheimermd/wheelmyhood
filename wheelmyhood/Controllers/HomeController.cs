using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WheelMyHood.Models;

namespace WheelMyHood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Cities"] = GetDemoCities().OrderBy(x => x.City).ToList();
            return View();
        }

        private List<CityTmp> GetDemoCities()
        {
            List<CityTmp> _cities = new List<CityTmp>{
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
                new CityTmp {City = "Bogota", Country = "Colombia", Region = "South America"},
                new CityTmp {City = "Buenos Aires", Country = "Argentia", Region = "South America"},
                new CityTmp {City = "Mexico City", Country = "Mexico", Region = "South America"},
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

            foreach (var c in _cities)
            {
                //  stringBuilder.ToString().Trim('-')
                c.Region = Regex.Replace(c.Region, " ", "-").ToLower();
            }

            return _cities;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
