using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts
{
    public interface IBurger
    {
        decimal Price { get; }

        IReadOnlyCollection<IIngredient> Ingredients { get; }
    }
}
