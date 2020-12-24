using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts.Factories
{
    public interface IIngredientFactory
    {
        IIngredient Create<T>(int quantity) where T : IIngredient;
    }
}
