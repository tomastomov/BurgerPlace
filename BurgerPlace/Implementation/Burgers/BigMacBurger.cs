using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Ingredients;
using BurgerPlace.Implementation.Ingredients.Meats;
using System.Collections.Generic;
using System.Linq;

namespace BurgerPlace.Implementation.Burgers
{
    public class BigMacBurger : IBurger
    {
        private readonly IList<IIngredient> ingredients;
        private readonly IIngredientFactory ingredientFactory;
        public BigMacBurger(IIngredientFactory ingredientFactory, ICollection<IIngredient> additionalIngredients = null)
        {
            this.ingredientFactory = ingredientFactory;
            var ingredients = new List<IIngredient>() {ingredientFactory.Create<BeefMeatIngredient>(2), ingredientFactory.Create<TomatoIngredient>(2), ingredientFactory.Create<CheeseIngredient>(3)};
            ingredients.AddRange(additionalIngredients);
            this.ingredients = ingredients;
        }
        public decimal Price => Ingredients.Sum(ingredient => ingredient.Product.Price * ingredient.Quantity);

        public IReadOnlyCollection<IIngredient> Ingredients => ingredients.ToList();
    }
}