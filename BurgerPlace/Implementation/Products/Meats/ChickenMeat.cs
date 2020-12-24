using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Products.Meats
{
    public class ChickenMeat : IProduct, IMeat
    {
        public ChickenMeat()
        {
            Id = Guid.NewGuid().ToString();
        }
        public MeatType MeatType => MeatType.Chicken;

        public decimal Price => 10m;

        public string Id { get; private set; }

        public override string ToString()
        {
            return nameof(ChickenMeat);
        }
    }
}
