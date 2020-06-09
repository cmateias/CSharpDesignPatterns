using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderEPad = new OrderEPad();
            
            var waiter = new Waiter();
            var waiterDrinksCommand = new WaiterDrinksCommand(waiter);
            var waiterDrinksSlot = 0;
            var waiterFoodsCommand = new WaiterFoodCommand(waiter);
            var wwaiterFoodsSlot = 1;
            var waiterPaymentCommand = new WaiterPaymentCommand(waiter);
            var waiterPaymentSlot = 2;

            var chef = new Chef();
            var chefDessertsCommand = new ChefDessertsCommand(chef);
            var chefDessertsSlot = 3;
            var chefStartersCommand = new ChefStartersCommand(chef);
            var chefStartersSlot = 4;
            var chefMainsCommand = new ChefMainsCommand(chef);
            var chefMainsSlot = 5;

            orderEPad.SetCommand(waiterDrinksSlot ,waiterDrinksCommand);
            orderEPad.SetCommand(wwaiterFoodsSlot, waiterFoodsCommand);
            orderEPad.SetCommand(waiterPaymentSlot, waiterPaymentCommand);
            orderEPad.SetCommand(chefDessertsSlot, chefDessertsCommand);
            orderEPad.SetCommand(chefStartersSlot, chefStartersCommand);
            orderEPad.SetCommand(chefMainsSlot, chefMainsCommand);

            Console.WriteLine("Drinks Order: " + orderEPad.OnTrigger(waiterDrinksSlot));
            Console.WriteLine("\n");

            Console.WriteLine("Food Order: " + orderEPad.OnTrigger(wwaiterFoodsSlot));
            Console.WriteLine("\n");

            Console.WriteLine("Starters preparation: " + orderEPad.OnTrigger(chefStartersSlot));
            Console.WriteLine("\n");

            Console.WriteLine("Mains preparation: " + orderEPad.OnTrigger(chefMainsSlot));
            Console.WriteLine("\n");

            Console.WriteLine("Dessert preparation: " + orderEPad.OnTrigger(chefDessertsSlot));
            Console.WriteLine("\n");

            Console.WriteLine("Take payment: " + orderEPad.OnTrigger(waiterPaymentSlot));
            Console.WriteLine("\n");
        }
    }
}
