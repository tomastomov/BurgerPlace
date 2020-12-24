using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts
{
    public interface IIngredient
    {
        IProduct Product { get; }

        int Quantity { get; }
    }
}
