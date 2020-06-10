using System.Collections;

namespace Iterator
{
    public class StarterMenu : IMenu
    {
        private readonly Hashtable _starterItems = new Hashtable();

        public StarterMenu()
        {
            AddItem("Garlic Bread", "Pizza bread with garlic", 3.5, 1);
            AddItem("Garlic Mushrooms", "Fried mushrooms with garlic", 5.5, 2);
            AddItem("Falafel", "Falafel served with salad", 3.5, 3);
        }


        public IIterator CreateIterator()
        {
            return new StarterMenuIterator(_starterItems);
        }

        public void AddItem(string name, string description,
            double price, int index)
        {
            var menuItem = new MenuItem(name, description,
                price);
            _starterItems.Add(index, menuItem);
        }
    }
}