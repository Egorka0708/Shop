using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class SearchController : Controller {

        private readonly IAllCars _allCars;

        public SearchController(IAllCars iAllCars) {
            _allCars = iAllCars;
        }

        [Route("Search/Result/{symbols}")]
        public ViewResult Result(string symbols) {
            IEnumerable<Car> cars = null;
            if (string.IsNullOrEmpty(symbols))
                cars = _allCars.Cars.OrderBy(i => i.Id);
            else {
                cars = _allCars.Cars.Where(i => i.Name.Contains(symbols, StringComparison.OrdinalIgnoreCase)).OrderBy(i => i.Id);
            }

            var carObj = new CarsListViewModel {
                AllCars = cars
            };

            ViewBag.Title = "Результат поиска по: " + symbols;
            return View(carObj);
        }
    }
}