using BurgerPlace.Contracts.Factories;
using BurgerPlace.Contracts;
using BurgerPlace.Implementation.Burgers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Factories
{
    public class BurgerFactory : IBurgerFactory
    {
        private readonly IIngredientFactory ingredientFactory;
        public BurgerFactory(IIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public T Create<T>(ICollection<IIngredient> additionalIngredients = null) where T : IBurger
        {
            return (T)Activator.CreateInstance(typeof(T), new object[2] { ingredientFactory, additionalIngredients });
        }

        public IBurger CreateBigMacBurger()
        {
            return new BigMacBurger(ingredientFactory);
        }

        public IBurger CreateCheeseBurger()
        {
            return new CheeseBurger(ingredientFactory);
        }

        public IBurger CreateChickenBurger()
        {
            return new ChickenBurger(ingredientFactory);
        }
    }
}
