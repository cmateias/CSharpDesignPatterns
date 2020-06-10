using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var waiter = new HeadWaiter();
            var kitchenStaffAdapter = new WaitingStaffAdapter(waiter);

            Console.WriteLine("Can the Head Waiter adapt?");
            Console.WriteLine("Can Cook: " + kitchenStaffAdapter.Cook());
            Console.WriteLine("Can Take Order: " + kitchenStaffAdapter.TakeOrder());
            Console.WriteLine("\n");


            var chef = new HeadChef();
            var waitingStaffAdapter = new KitchenStaffAdapter(chef);

            Console.WriteLine("Can the Head Chef adapt?");
            Console.WriteLine("Can Serve: " + waitingStaffAdapter.Serve());
            Console.WriteLine("Can Take Order: " + waitingStaffAdapter.TakeOrder());

            Console.WriteLine("---------------------------------------------------");
        }
    }
}