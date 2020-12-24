using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Builders;
using BurgerPlace.Contracts.Enums;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Builders
{
    public class BurgerBuilder<T> : IBurgerBuilder<T> where T : IBurger
    {
        private readonly IIngredientFactory ingredientFactory;
        private readonly IBurgerFactory burgerFactory;
        private readonly ICollection<IIngredient> additionalIngredients;
        public BurgerBuilder(IBurgerFactory factory, IIngredientFactory ingredientFactory)
        {
            this.burgerFactory = factory;
            this.ingredientFactory = ingredientFactory;
            this.additionalIngredients = new List<IIngredient>();
        }
        public T Build()
        {
            return burgerFactory.Create<T>(additionalIngredients);
        }

        public IBurgerBuilder<T> WithAdditionalCheese(int quantity)
        {
            this.additionalIngredients.Add(this.ingredientFactory.Create<CheeseIngredient>(quantity));
            return this;
        }

        public IBurgerBuilder<T> WithAdditionalMeat<K>(int quantity) where K : IMeat, IIngredient
        {
            this.additionalIngredients.Add(this.ingredientFactory.Create<K>(quantity));
            return this;
        }

        public IBurgerBuilder<T> WithAdditionalTomato(int quantity)
        {
            this.additionalIngredients.Add(this.ingredientFactory.Create<TomatoIngredient>(quantity));
            return this;
        }
    }
}
