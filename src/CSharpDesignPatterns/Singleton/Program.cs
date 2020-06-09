using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuEnquiry1 = new MenuEnquiry();

            Console.WriteLine("First Enquiry");
            Console.WriteLine("Inquiry Starter Items: " + menuEnquiry1.GetStarterItems());
            Console.WriteLine("Inquiry Main Items: " + menuEnquiry1.GetMainItems());
            Console.WriteLine("\n");

            var menuEnquiry2 = new MenuEnquiry();

            Console.WriteLine("Second Enquiry");
            Console.WriteLine("Inquiry Starter Items: " + menuEnquiry2.GetStarterItems());
            Console.WriteLine("Inquiry Main Items: " + menuEnquiry2.GetMainItems());
            Console.WriteLine("\n");

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
