using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class MenuEnquiry
    {
        public int GetStarterItems()
        {
            var menu = MenuSingleton.GetInstance();
            return menu.StarterItems;
        }

        public int GetMainItems()
        {
            var menu = MenuSingleton.GetInstance();
            return menu.MainItems;
        }
    }
}
