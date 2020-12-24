using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Ingredients;
using BurgerPlace.Implementation.Ingredients.Meats;
using System.Collections.Generic;
using System.Linq;

namespace BurgerPlace.Implementation.Burgers
{
    public class ChickenBurger : IBurger
    {
        private readonly IList<IIngredient> ingredients;
        private readonly IIngredientFactory ingredientFactory;
        public ChickenBurger(IIngredientFactory ingredientFactory, ICollection<IIngredient> additionalIngredients = null)
        {
            this.ingredientFactory = ingredientFactory;
            var ingredients = new List<IIngredient>() {ingredientFactory.Create<ChickenMeatIngredient>(1), ingredientFactory.Create<TomatoIngredient>(1), ingredientFactory.Create<CheeseIngredient>(2) };
            ingredients.AddRange(additionalIngredients);
            this.ingredients = ingredients;
        }
        public decimal Price => Ingredients.Sum(ingredient => ingredient.Product.Price * ingredient.Quantity);

        public IReadOnlyCollection<IIngredient> Ingredients => ingredients.ToList();
    }
}