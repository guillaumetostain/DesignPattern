﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BuilderPattern
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Coke());
            return meal;
        }
    }
}