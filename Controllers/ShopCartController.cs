using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class ShopCartController : Controller {

        private readonly IAllCars _allCars;
        private readonly ShopCart _shopCart;
        
        public ShopCartController(IAllCars carRep, ShopCart shopCart) {
            _allCars = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index() {
            var items = _shopCart.GetShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id) {
            var item = _allCars.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null) {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
