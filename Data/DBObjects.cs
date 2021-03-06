﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data {
    public class DBObjects {

        private static Dictionary<string, Category> category;
        
        public static void Initial(AppDBContent content) {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
                content.AddRange(
                    new Car {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img = "/img/tesla.jpg",
                        Price = 40000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/ford.jpg",
                        Price = 25000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный и вместительный автомобиль",
                        Img = "/img/bmw.jpg",
                        Price = 45000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Mercedes C Class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Красивый и привлекательный автомобиль",
                        Img = "/img/mercedes.jpg",
                        Price = 55000,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Классический красивый автомобиль",
                        Img = "/img/nissan.jpg",
                        Price = 20000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car {
                        Name = "Audi R8",
                        ShortDesc = "Быстрый и резкий",
                        LongDesc = "Спортивный и мощный автомобиль",
                        Img = "/img/audi.jpg",
                        Price = 28000,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Jaguar I-PACE",
                        ShortDesc = "Большой и комфортный",
                        LongDesc = "Вместительный семейный автомобиль",
                        Img = "/img/jaguar.jpg",
                        Price = 57000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car {
                        Name = "Lamborghini Aventador",
                        ShortDesc = "Элитный и быстрый",
                        LongDesc = "Роскошный и стильный автомобиль",
                        Img = "/img/lamborghini.jpg",
                        Price = 90000,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Porshe 911",
                        ShortDesc = "Спортивный и эллегантный",
                        LongDesc = "Миниатюрный и отзывчивый автомобиль",
                        Img = "/img/porshe.jpg",
                        Price = 75000,
                        IsFavourite = true,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car {
                        Name = "Volvo XC40",
                        ShortDesc = "Семейный и вместительный",
                        LongDesc = "Лучший автомобиль для городской жизни",
                        Img = "/img/volvo.jpg",
                        Price = 62000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Электромобили"]
                    }
                );

            content.SaveChanges();
        }

        public static Dictionary<string, Category> Categories {
            get {
                if (category == null) {
                    var list = new Category[] {
                        new Category { CategoryName = "Электромобили", Desc = "Машины с электродвигателем" },
                        new Category { CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var el in list)
                        category.Add(el.CategoryName, el);
                }

                return category;
            }
        }
    }
}
