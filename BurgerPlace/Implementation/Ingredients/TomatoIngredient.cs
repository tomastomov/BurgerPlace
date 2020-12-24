using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Ingredients
{
    public class TomatoIngredient : IIngredient
    {
        private readonly IProductFactory productFactory;
        public TomatoIngredient(int quantity, IProductFactory productFactory)
        {
            this.productFactory = productFactory;
            this.Product = productFactory.Create<Tomato>();
            this.Quantity = quantity;
        }

        public IProduct Product { get; private set; }

        public int Quantity { get; private set; }
    }
}
