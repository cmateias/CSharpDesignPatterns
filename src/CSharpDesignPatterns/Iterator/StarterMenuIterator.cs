using System.Collections;

namespace Iterator
{
    public class StarterMenuIterator : IIterator
    {
        private int _position = 1;
        private readonly Hashtable _starterMenuItems = new Hashtable();

        public StarterMenuIterator(Hashtable starterMenuItems)
        {
            _starterMenuItems = starterMenuItems;
        }

        public bool HasNext()
        {
            return _position <= _starterMenuItems.Count ? true : false;
        }

        public object Next()
        {
            var menuItem = (MenuItem) _starterMenuItems[_position];
            _position += 1;
            return menuItem;
        }
    }
}