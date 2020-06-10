using System;

namespace Iterator
{
    public class MainsMenu : IMenu
    {
        private static readonly int maximumItems = 6;
        private readonly MenuItem[] _mainMenuItems;
        private int _numberOfItems;

        public MainsMenu()
        {
            _mainMenuItems = new MenuItem[maximumItems];

            AddItem("Pizza Pepperoni", "Pizza with salami", 6.5);
            AddItem("Chicken Wraps", "Fajita chicked wraps", 8.5);
            AddItem("Burrito", "Pulled Pork burrito", 7.5);
        }

        public IIterator CreateIterator()
        {
            return new MainsMenuIterator(_mainMenuItems);
        }

        public void AddItem(string name, string description,
            double price)
        {
            var menuItem = new MenuItem(name, description,
                price);
            if (_numberOfItems >= maximumItems)
            {
                Console.WriteLine("The maximum limit of menu item has been reached");
            }
            else
            {
                _mainMenuItems[_numberOfItems] = menuItem;
                _numberOfItems += 1;
            }
        }
    }
}