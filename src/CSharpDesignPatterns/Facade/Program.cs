using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var headWaiter = new HeadWaiter("Alice");
            var headChef = new HeadChef("John");
            var waiter = new Waiter("Mike");
            var sousChef = new SousChef("Jane");

            var tableService = new TableServiceFacade(headWaiter, headChef, waiter, sousChef);

            Console.WriteLine("Starting Table Service");
            Console.WriteLine(tableService.BeginService());

            Console.WriteLine("\n");

            Console.WriteLine("Ending Table Service");
            Console.WriteLine(tableService.EndService());

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
