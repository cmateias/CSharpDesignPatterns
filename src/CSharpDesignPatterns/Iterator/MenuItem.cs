namespace Iterator
{
    public class MenuItem
    {
        public MenuItem(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}