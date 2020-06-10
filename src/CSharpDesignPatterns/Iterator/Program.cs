using System;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var starterMenu = new StarterMenu();
            var mainsMenu = new MainsMenu();
            var cocktailsMenu = new CocktailsMenu();

            var waiter = new Waiter(starterMenu, mainsMenu, cocktailsMenu);
            Console.WriteLine(waiter.PrintMenu());
            Console.WriteLine("---------------------------------------------------");
        }
    }
}