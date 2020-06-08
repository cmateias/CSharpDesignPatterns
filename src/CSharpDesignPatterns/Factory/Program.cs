using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            var zoneA = new ZoneA();
            Console.WriteLine("Delegating the Head Waiter to Zone A");
            var zoneAStaffOne = zoneA.DelegateStaff(nameof(HeadWaiter));

            Console.WriteLine("Info: " + zoneAStaffOne.GetInfo());
            Console.WriteLine("Introducing: " + zoneAStaffOne.Introduce());
            Console.WriteLine("Retrieving Order: " + zoneAStaffOne.RetrieveOrder());
            Console.WriteLine("Serving Order: " + zoneAStaffOne.ServeOrder());
            Console.WriteLine("Getting Payment: " + zoneAStaffOne.GetPayment());
            Console.WriteLine("Saying Goodbye: " + zoneAStaffOne.SayGoodbye());
            Console.WriteLine("\n");

            Console.WriteLine("Delegating the Junior Waiter to Zone A");
            var zoneAStaffTwo = zoneA.DelegateStaff(nameof(JuniorWaiter));

            Console.WriteLine("Info: " + zoneAStaffTwo.GetInfo());
            Console.WriteLine("Introducing: " + zoneAStaffTwo.Introduce());
            Console.WriteLine("Retrieving Order: " + zoneAStaffTwo.RetrieveOrder());
            Console.WriteLine("Serving Order: " + zoneAStaffTwo.ServeOrder());
            Console.WriteLine("Getting Payment: " + zoneAStaffTwo.GetPayment());
            Console.WriteLine("Saying Goodbye: " + zoneAStaffTwo.SayGoodbye());
            Console.WriteLine("\n");

            var zoneB = new ZoneB();
            Console.WriteLine("Delegating the Waiter to Zone B");
            var zoneBStaffOne = zoneB.DelegateStaff(nameof(Waiter));
            
            Console.WriteLine("Info: " + zoneBStaffOne.GetInfo());
            Console.WriteLine("Introducing: " + zoneBStaffOne.Introduce());
            Console.WriteLine("Retrieving Order: " + zoneBStaffOne.RetrieveOrder());
            Console.WriteLine("Serving Order: " + zoneBStaffOne.ServeOrder());
            Console.WriteLine("Getting Payment: " + zoneBStaffOne.GetPayment());
            Console.WriteLine("Saying Goodbye: " + zoneBStaffOne.SayGoodbye());
            Console.WriteLine("\n");

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
