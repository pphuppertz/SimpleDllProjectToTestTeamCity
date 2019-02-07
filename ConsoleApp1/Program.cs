using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDllProjectToTestTeamCity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person
            {
                Name = "Peter",
                BirthDate = new DateTime(1957, 12, 24)
            };

            Console.WriteLine($" I am now {me.AgeInDays} days old.");
            Console.ReadKey();
        }
    }
}
