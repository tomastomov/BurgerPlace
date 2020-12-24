using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Factories
{
    public class IngredientFactory : IIngredientFactory
    {
        private readonly IProductFactory productFactory;
        public IngredientFactory(IProductFactory productFactory)
        {
            this.productFactory = productFactory;
        }
        public IIngredient Create<T>(int quantity) where T : IIngredient
        {
            return (IIngredient)Activator.CreateInstance(typeof(T), new object[2] { quantity, productFactory});
        }

    }
}
