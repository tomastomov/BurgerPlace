using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Products.Meats
{
    public class BeefMeat : IProduct, IMeat
    {
        public BeefMeat()
        {
            Id = Guid.NewGuid().ToString();
        }
        public MeatType MeatType => MeatType.Beef;

        public decimal Price => 35m;

        public string Id { get; private set; }

        public override string ToString()
        {
            return nameof(BeefMeat);
        }
    }
}
