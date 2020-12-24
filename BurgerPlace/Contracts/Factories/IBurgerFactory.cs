using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts.Factories
{
    public interface IBurgerFactory
    {
        T Create<T>(ICollection<IIngredient> additionalIngredients = null) where T : IBurger;
        IBurger CreateCheeseBurger();
        IBurger CreateBigMacBurger();
        IBurger CreateChickenBurger();
    }
}
