using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Waiter Info:");
            SkillsRole waiterSkills = new Waiting();
            waiterSkills = new Entertaining(waiterSkills);
            waiterSkills = new Bartending(waiterSkills);

            Console.WriteLine("Description: " + waiterSkills.GetDescription());
            Console.WriteLine("Skills: " + waiterSkills.CanDo());
            Console.WriteLine("\n");

            Console.WriteLine("Chef Info:");
            SkillsRole chefSkills = new Cheffing();
            chefSkills = new Entertaining(chefSkills);

            Console.WriteLine("Description: " + chefSkills.GetDescription());
            Console.WriteLine("Skills: " + chefSkills.CanDo());
            Console.WriteLine("\n");

            Console.WriteLine("Host Info:");
            SkillsRole hostSkills = new Hosting();
            hostSkills = new Singing(hostSkills);
            hostSkills = new Bartending(hostSkills);

            Console.WriteLine("Description: " + hostSkills.GetDescription());
            Console.WriteLine("Skills: " + hostSkills.CanDo());
            Console.WriteLine("\n");

            Console.WriteLine("---------------------------------------------------");
        }
    }
}