using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var bartenderOrder = new BartenderOrderProcess();
            var chefOrder = new ChefOrderProcess();

            Console.WriteLine("Bartender:");
            Console.WriteLine(bartenderOrder.PrepareOrder());
            Console.WriteLine("\n");

            Console.WriteLine("Chef:");
            Console.WriteLine(chefOrder.PrepareOrder());

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
