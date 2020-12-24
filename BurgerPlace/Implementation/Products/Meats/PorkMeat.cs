using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Implementation.Products.Meats
{
    public class PorkMeat : IProduct, IMeat
    {
        public PorkMeat()
        {
            Id = Guid.NewGuid().ToString();
        }
        public MeatType MeatType => MeatType.Pork;

        public decimal Price => 35m;

        public string Id { get; private set; }

        public override string ToString()
        {
            return nameof(PorkMeat);
        }
    }
}
