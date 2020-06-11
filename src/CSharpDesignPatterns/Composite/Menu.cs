using System.Collections;
using System.Text;

namespace Composite
{
    public class Menu : MenuComponent
    {
        private string description;
        private readonly ArrayList menuComponents = new ArrayList();
        private string name;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override string Description
        {
            get => description;
            set => description = value;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent) menuComponents[i];
        }

        public override ArrayList GetMenu()
        {
            return menuComponents;
        }

        public override int Count()
        {
            return menuComponents.Count;
        }

        public override string Print()
        {
            var menuPrint = new StringBuilder();
            menuPrint.Append("\n" + name);
            menuPrint.Append(", " + description + "\n");
            menuPrint.Append("-------------------------\n");

            foreach (MenuComponent menuComponent in menuComponents) menuPrint.Append(menuComponent.Print());

            return menuPrint.ToString();
        }
    }
}
