using BurgerPlace.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Products
{
    public class Cheese : IProduct
    {
        public Cheese()
        {
            Id = Guid.NewGuid().ToString();
        }
        public decimal Price => 2.60m;

        public string Id { get; private set; }

        public override string ToString()
        {
            return nameof(Cheese);
        }
    }
}
