using System.Collections;

namespace Iterator
{
    internal class CocktailsMenu : IMenu
    {
        private readonly ArrayList _cocktailsMenuItems;

        public CocktailsMenu()
        {
            _cocktailsMenuItems = new ArrayList();

            AddItem("Mojito", "White rum cocktail", 5.5);
            AddItem("Old fashioned", "Whisky cocktail", 5.5);
            AddItem("GT", "Gin and tonic", 5.5);
        }

        public IIterator CreateIterator()
        {
            return new CocktailsMenuIterator(_cocktailsMenuItems);
        }

        public void AddItem(string name, string description,
            double price)
        {
            var menuItem = new MenuItem(name, description,
                price);

            _cocktailsMenuItems.Add(menuItem);
        }
    }
}