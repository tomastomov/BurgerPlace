using BurgerPlace.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts.Builders
{
    public interface IBurgerBuilder<T> where T : IBurger
    {
        IBurgerBuilder<T> WithAdditionalTomato(int quantity);
        IBurgerBuilder<T> WithAdditionalCheese(int quantity);
        IBurgerBuilder<T> WithAdditionalMeat<K>(int quantity) where K : IMeat, IIngredient;
        T Build();
    }
}
