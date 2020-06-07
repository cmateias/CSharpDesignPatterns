using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Head Chef info");
            Staff headChef = new HeadChef();

            Console.WriteLine(headChef.Performing());
            Console.WriteLine(headChef.Scheduling());

            Console.WriteLine("\n");
            Console.WriteLine("Sous Chef info");
            Staff sousChef = new SousChef();

            Console.WriteLine(sousChef.Performing());
            Console.WriteLine(sousChef.Scheduling());

            Console.WriteLine("\n");
            Console.WriteLine("Waiter info");
            Staff waiter = new Waiter();

            Console.WriteLine(waiter.Performing());
            Console.WriteLine(waiter.Scheduling());

            Console.WriteLine("\n");
            Console.WriteLine("Bartender info");
            Staff bartender = new Bartender();

            Console.WriteLine(bartender.Performing());
            Console.WriteLine(bartender.Scheduling());

            Console.WriteLine("\n");
            Console.WriteLine("Host info");
            Staff host = new Host();

            Console.WriteLine(host.Performing());
            Console.WriteLine(host.Scheduling());

            Console.WriteLine("\n");
          
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Everyone's schedule changes to on call temporary");

            headChef.WorkingSchedule = new OnCallSchedule();
            Console.WriteLine("Head Chef's schedule: " + headChef.Scheduling());
            Console.WriteLine("\n");

            sousChef.WorkingSchedule = new OnCallSchedule();
            Console.WriteLine("Sous Chef's schedule: " + sousChef.Scheduling());
            Console.WriteLine("\n");
            
            waiter.WorkingSchedule = new OnCallSchedule();
            Console.WriteLine("Waiter's schedule: " + waiter.Scheduling());
            Console.WriteLine("\n");
            
            bartender.WorkingSchedule = new OnCallSchedule();
            Console.WriteLine("Bartender's schedule: " + bartender.Scheduling());
            Console.WriteLine("\n");
            
            host.WorkingSchedule = new OnCallSchedule();
            Console.WriteLine("Host's schedule: " + host.Scheduling());
            Console.WriteLine("\n");

        }
    }
}
