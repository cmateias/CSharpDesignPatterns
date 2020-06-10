using System.Collections;

namespace Iterator
{
    public class CocktailsMenuIterator : IIterator
    {
        private readonly ArrayList _cocktailsMenuItems = new ArrayList();
        private int position;

        public CocktailsMenuIterator(ArrayList cocktailsMenuItems)
        {
            _cocktailsMenuItems = cocktailsMenuItems;
        }

        public bool HasNext()
        {
            if (position >= _cocktailsMenuItems.Count || _cocktailsMenuItems[position] == null)
                return false;
            return true;
        }

        public object Next()
        {
            var menuItem = (MenuItem) _cocktailsMenuItems[position];
            position += 1;
            return menuItem;
        }
    }
}