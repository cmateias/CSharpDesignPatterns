using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Waiter
    {
        MenuComponent _menus;

        public Waiter(MenuComponent menus)
        {
            _menus = menus;
        }

        public string PrintMenu()
        {
            return _menus.Print();
        }
	}
}
