namespace Iterator
{
    public class MainsMenuIterator : IIterator
    {
        private readonly MenuItem[] _mainsMenuItems;
        private int _position;

        public MainsMenuIterator(MenuItem[] mainsMenuItems)
        {
            _mainsMenuItems = mainsMenuItems;
        }

        public bool HasNext()
        {
            if (_position >= _mainsMenuItems.Length || _mainsMenuItems[_position] == null)
                return false;
            return true;
        }

        public object Next()
        {
            var menuItem = _mainsMenuItems[_position];
            _position += 1;
            return menuItem;
        }
    }
}