﻿using DesignPatternsSample.工厂模式.简单工厂;
using DesignPatternsSample.工厂模式.简单工厂.披萨;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSample.工厂模式.工厂模式.Store
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType) =>
            pizzaType switch//享元模式
            {
                PizzaType.Cheese => new ChicagoCheese(),
                PizzaType.Pepperoni => new ChicagoPepperoni(),
                PizzaType.Clam => new ChicagoClam(),
                PizzaType.Veggie => new ChicagoVeggie()
            };
    }
}
