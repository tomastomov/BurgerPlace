using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Ingredients
{
    public class CheeseIngredient : IIngredient
    {
        private readonly IProductFactory productFactory;
        public CheeseIngredient(int quantity, IProductFactory productFactory)
        {
            this.productFactory = productFactory;
            this.Product = productFactory.Create<Cheese>();
            this.Quantity = quantity;
        }

        public IProduct Product { get; private set; }

        public int Quantity { get; private set; }
    }
}
