using BurgerPlace.Contracts.Factories;
using BurgerPlace.Contracts;
using BurgerPlace.Implementation.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Factories
{
    public class ProductFactory : IProductFactory
    {
        public IProduct Create<T>() where T : IProduct
        {
            return (IProduct)Activator.CreateInstance(typeof(T));
        }
    }
}
