using Autofac;
using BurgerPlace.Contracts;
using BurgerPlace.Contracts.Builders;
using BurgerPlace.Contracts.Factories;
using BurgerPlace.Implementation.Builders;
using BurgerPlace.Implementation.Burgers;
using BurgerPlace.Implementation.Factories;
using BurgerPlace.Implementation.Ingredients.Meats;
using System;
using System.Linq;
using System.Text;

namespace MrDonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ProductFactory>().As<IProductFactory>();
            builder.RegisterType<BurgerFactory>().As<IBurgerFactory>();
            builder.RegisterType<IngredientFactory>().As<IIngredientFactory>();

            var container = builder.Build();

            using var scope = container.BeginLifetimeScope();

            Console.WriteLine("Choose your burger please");

            var command = Console.ReadLine();

            var burgersBuilder = new BurgerBuilder<BigMacBurger>(scope.Resolve<IBurgerFactory>(), scope.Resolve<IIngredientFactory>());

            var burger1 = burgersBuilder.Build();

            Console.WriteLine(burger1.Price);

            burgersBuilder.WithAdditionalCheese(1);
            burgersBuilder.WithAdditionalTomato(2);
            burgersBuilder.WithAdditionalMeat<PorkMeatIngredient>(1);

            var burger = burgersBuilder.Build();

            Console.WriteLine(burger.Price);
        }
    }
}
