using System.Text;

namespace Iterator
{
    public class Waiter
    {
        private readonly IMenu _cocktailsMenu;
        private readonly IMenu _mainsMenu;

        private readonly IMenu _starterMenu;

        public Waiter(IMenu starterMenu,
            IMenu mainsMenu, IMenu cocktailsMenu)
        {
            _starterMenu = starterMenu;
            _mainsMenu = mainsMenu;
            _cocktailsMenu = cocktailsMenu;
        }

        public string PrintMenu()
        {
            var sb = new StringBuilder();

            var starterMenuIterator = _starterMenu.CreateIterator();
            var mainsMenuIterator = _mainsMenu.CreateIterator();
            var cocktailsMenuIterator = _cocktailsMenu.CreateIterator();
            sb.Append("MENU\n----\nSTARTERS\n");
            sb.Append(PrintMenu(starterMenuIterator));
            sb.Append("\nMAINS\n");
            sb.Append(PrintMenu(mainsMenuIterator));
            sb.Append("\nCOCKTAILS\n");
            sb.Append(PrintMenu(cocktailsMenuIterator));

            return sb.ToString();
        }

        public string PrintMenu(IIterator iterator)
        {
            var menu = new StringBuilder();
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem) iterator.Next();

                menu.Append(menuItem.Name + ", ");
                menu.Append(menuItem.Price + " -- ");
                menu.Append(menuItem.Description + "\n");
            }

            return menu.ToString();
        }
    }
}