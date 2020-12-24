using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts
{
    public interface IProduct
    {
        decimal Price { get; }

        string Id { get; }
    }
}
