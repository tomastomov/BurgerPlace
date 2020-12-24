using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts.Factories
{
    public interface IProductFactory
    {
        IProduct Create<T>() where T : IProduct;
    }
}
