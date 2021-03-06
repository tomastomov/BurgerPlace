﻿using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Enums;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Products.Meats;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Ingredients.Meats
{
    public class BeefMeatIngredient : IIngredient, IMeat
    {
        private readonly IProductFactory productFactory;
        public BeefMeatIngredient(int quantity, IProductFactory productFactory)
        {
            this.productFactory = productFactory;
            this.Product = productFactory.Create<BeefMeat>();
            this.Quantity = quantity;
        }

        public IProduct Product { get; private set; }

        public int Quantity { get; private set; }

        public MeatType MeatType => MeatType.Beef;
    }
}
