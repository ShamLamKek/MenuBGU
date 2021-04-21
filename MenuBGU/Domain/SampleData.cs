using MenuBGU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuBGU.Domain
{
    public class SampleData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Foods.Any())
            {
                context.Foods.AddRange(
                    new Food
                    {
                        Name = "Салат картофельный с языком",
                        Price = 59,
                        Code = 0879, 
                        Category = "ColdPlatters"
                    },
                    new Food
                    {
                        Name = "Салат \"Люсьен\"",
                        Price = 39,
                        Code = 0772,
                        Category = "ColdPlatters"
                    },
                    new Food
                    {
                        Name = "Щи \"Русские\" с фрикадельками, сметаной",
                        Price = 45,
                        Code = 07789, 
                        Category= "Starters"
                    },
                      new Food
                      {
                          Name = "Лапша домашняя",
                          Price = 26,
                          Code = 0843,
                          Category = "Starters"
                      },
                    new Food
                    {
                        Name = "Горбуша под маринадом",
                        Price = 96,
                        Code = 2238,
                        Category="MainDishes"
                    },
                    new Food
                    {
                        Name = "Отбивная куриная с грибами",
                        Price = 90,
                        Code = 0356,
                        Category = "MainDishes"
                    },
                    new Food
                    {
                        Name = "Лапша \"Удон\" со свининой",
                        Price = 96,
                        Code = 09107,
                        Category = "MainDishes"
                    },
                    new Food
                    {
                        Name = "Печень жареная",
                        Price = 59,
                        Code = 0659,
                        Category = "MainDishes"
                    },
                    new Food
                    {
                        Name = "Биточки \"По-селянски\"",
                        Price = 63,
                        Code = 10486,
                        Category = "MainDishes"
                    },
                    new Food
                    {
                        Name = "Зразы картофельные с грибами",
                        Price = 32,
                        Code = 6496,
                        Category = "MainDishes"
                    },
                    new Food
                    {
                        Name = "Хашаны отварные с маслом",
                        Price = 59,
                        Code = 6074,
                        Category = "MainDishes"
                    },
                    new Food
                    {
                        Name = "Каша гречневая с маслом, молоком",
                        Price = 22,
                        Code = 08082,
                        Category = "MainDishes"
                    },
                    new Food
                        {
                            Name = "Картофельное пюре",
                            Price = 25,
                            Code = 0014, 
                            Category="SideDishes"
                        },
                        new Food
                        {
                            Name = "Гарнир гречневый",
                            Price = 18,
                            Code = 0041,
                            Category = "SideDishes"
                        },
                        new Food
                        {
                            Name = "Макароны отварные",
                            Price = 15,
                            Code = 0359,
                            Category = "SideDishes"
                        },
                        new Food
                        {
                            Name = "Рагу овощное с цукини",
                            Price = 48,
                            Code = 1826,
                            Category = "SideDishes"
                        },
                        new Food
                        {
                            Name = "Соус с томатом, сметаной",
                            Price = 8,
                            Code = 0016,
                            Category = "SideDishes"
                        },
                        new Food
                        {
                            Name = "Напиток из облепихи",
                            Price = 20,
                            Code = 2210,
                            Category= "Beverages"
                        },
                        new Food
                        {
                            Name = "Чай (Гринфилд, Липтон, Ахмат, Хилвей)",
                            Price = 6,
                            Code = 09988,
                            Category = "Beverages"
                        },
                        new Food
                        {
                            Name = "Чай (Ява, Гита, Тесс, Царский добрыня, Зеленый Лондон)",
                            Price = 3,
                            Code = 09987,
                            Category = "Beverages"
                        },
                        new Food
                        {
                            Name = "Чай \"Макчай\"",
                            Price = 15,
                            Code = 0215,
                            Category = "Beverages"
                        },
                        new Food
                        {
                            Name = "Кофе черный",
                            Price = 20,
                            Code = 0203,
                            Category = "Beverages"
                        },
                        new Food
                        {
                            Name = "Маккофе капучино",
                            Price = 30,
                            Code = 07136,
                            Category = "Beverages"
                        },
                        new Food
                        {
                            Name = "Кофе 3 в 1",
                            Price = 20,
                            Code = 1883,
                            Category = "Beverages"
                        },
                        new Food
                        {
                            Name = "Кофейный напиток 3 в 1",
                            Price = 15,
                            Code = 11011,
                            Category = "Beverages"
                        },
                            new Food
                            {
                                Name = "Пирожок \"Закусочный\"",
                                Price = 45,
                                Code = 1547,
                                Category="BakeryProducts"
                            },
                            new Food
                            {
                                Name = "Расстегай из горбуши",
                                Price = 40,
                                Code = 6474,
                                Category = "BakeryProducts"
                            },
                             new Food
                             {
                                 Name = "Ватрушка с повидлом",
                                 Price = 18,
                                 Code = 0902,
                                 Category = "BakeryProducts"
                             },
                              new Food
                              {
                                  Name = "Рожок песочный с сахаром",
                                  Price = 9,
                                  Code = 10820,
                                  Category = "BakeryProducts"
                              },
                               new Food
                               {
                                   Name = "Слойка со сгущенкой",
                                   Price = 25,
                                   Code = 0397,
                                   Category = "BakeryProducts"
                               },
                             new Food
                             {
                                 Name = "Батон",
                                 Price = 3,
                                 Code = 0825,
                                 Category = "BakeryProducts"
                             }
                            );
                        context.SaveChanges();
                    }
                }
            }
        }
    

