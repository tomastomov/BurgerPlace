using BurgerPlace.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Products
{
    public class Tomato : IProduct
    {
        public Tomato()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; private set; }

        public decimal Price => 3.50m;

        public override string ToString()
        {
            return nameof(Tomato);
        }
    }
}
