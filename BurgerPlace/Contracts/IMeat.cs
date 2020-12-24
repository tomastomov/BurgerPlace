using BurgerPlace.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerPlace.Contracts
{
    public interface IMeat
    {
        MeatType MeatType { get; }
    }
}
