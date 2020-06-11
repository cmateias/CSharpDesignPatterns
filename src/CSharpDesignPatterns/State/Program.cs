using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderEPad = new OrderEPad(2);
            Console.WriteLine("First order complete steps:");
            Console.WriteLine(orderEPad.Order());
            Console.WriteLine(orderEPad.Pay());
            Console.WriteLine(orderEPad.CollectOrder());

            Console.WriteLine(orderEPad.OrderStateInfo());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Second order going straight to collection:");
            Console.WriteLine(orderEPad.CollectOrder());

            Console.WriteLine(orderEPad.OrderStateInfo());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Third order going to payment before ordering:");
            Console.WriteLine(orderEPad.Pay());
            Console.WriteLine(orderEPad.CollectOrder());

            Console.WriteLine(orderEPad.OrderStateInfo());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Fourth order complete steps:");
            Console.WriteLine(orderEPad.Order());
            Console.WriteLine(orderEPad.Pay());
            Console.WriteLine(orderEPad.CollectOrder());

            Console.WriteLine(orderEPad.OrderStateInfo());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Fifth order when no sold out:");
            Console.WriteLine(orderEPad.Order());
            Console.WriteLine(orderEPad.Pay());
            Console.WriteLine(orderEPad.CollectOrder());

            Console.WriteLine(orderEPad.OrderStateInfo());
        }
    }
}
