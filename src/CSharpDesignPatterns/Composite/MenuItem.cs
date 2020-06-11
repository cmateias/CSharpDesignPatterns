using System.Text;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override double Price { get; set; }

        public override string Print()
        {
            var printOutPut = new StringBuilder();
            printOutPut.Append("\t" + Name);

            printOutPut.Append(", £" + Price + "\n");
            printOutPut.Append("\t\t--" + Description + "\n");

            return printOutPut.ToString();
        }
    }
}