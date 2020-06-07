using System;

namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var restaurantData = new RestaurantData();
            var headChefInfo = new HeadChefInfo(restaurantData);
            var waiterInfo = new WaiterInfo(restaurantData);
            var bartenderInfo = new BartenderInfo(restaurantData);
            var hostInfo = new HostInfo(restaurantData);

            restaurantData.SetExpectedClients("87");

            Console.WriteLine("Head Chef is informed: " + headChefInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("Waiter is informed: " + waiterInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("Bartender is informed: " + bartenderInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("Host is informed: " + hostInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Cancellations occured and Host is off sick");
            
            restaurantData.RemoveObserver(hostInfo);
            restaurantData.SetExpectedClients("44");
            Console.WriteLine("Head Chef is informed: " + headChefInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("Waiter is informed: " + waiterInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("Bartender is informed: " + bartenderInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("Host is informed: " + hostInfo.Inform());
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");

            Console.ReadKey();
        }
    }
}