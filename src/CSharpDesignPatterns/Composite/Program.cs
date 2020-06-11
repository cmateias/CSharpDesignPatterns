using System;

namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var starterMenu = new Menu("STARTERS MENU", "Starters");
            var mainsMenu = new Menu("MAINS MENU", "Mains");
            var cocktailsMenu = new Menu("COCKTAILS MENU", "Drinks");
            var mocktailsMenu = new Menu("MOCKTAILS MENU", "Mocktails");

            var allMenus = new Menu("ALL MENUS", "All menus combined");

            //add the menus to the All Menus menu
            allMenus.Add(starterMenu);
            allMenus.Add(mainsMenu);
            allMenus.Add(cocktailsMenu);

            starterMenu.Add(new MenuItem("Garlic Bread", "Pizza bread with garlic", 3.5));
            starterMenu.Add(new MenuItem("Garlic Mushrooms", "Fried mushrooms with garlic", 5.5));
            starterMenu.Add(new MenuItem("Falafel", "Falafel served with salad", 3.5));

            mainsMenu.Add(new MenuItem("Pizza Pepperoni", "Pizza with salami", 6.5));
            mainsMenu.Add(new MenuItem("Chicken Wraps", "Fajita chicken wraps", 8.5));
            mainsMenu.Add(new MenuItem("Burrito", "Pulled Pork burrito", 7.5));

            cocktailsMenu.Add(new MenuItem("Mojito", "White rum cocktail", 5.5));
            cocktailsMenu.Add(new MenuItem("Old fashioned", "Whisky cocktail", 5.5));
            cocktailsMenu.Add(new MenuItem("GT", "Gin and tonic", 5.5));

            cocktailsMenu.Add(mocktailsMenu);


            mocktailsMenu.Add(new MenuItem("Beyond Mojito", "Alcohol free rum cocktail", 5.5));
            mocktailsMenu.Add(new MenuItem("Beyond  Old fashioned", "Alcohol free whisky cocktail", 5.5));
            mocktailsMenu.Add(new MenuItem("Beyond  GT", "Alcohol free gin and tonic", 5.5));

            var waiter = new Waiter(allMenus);

            Console.WriteLine(waiter.PrintMenu());
        }
    }
}