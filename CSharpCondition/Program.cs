using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if else
            Console.WriteLine("Are you over 18?");
            Console.WriteLine("Enter Age :");
            int age = int.Parse(Console.ReadLine());
            int salary = 15000;

            //And = && OR = ||
            if (age <= 18 && salary == 15000)
            {
                Console.WriteLine("You age under 18. Salary you 15000");
            }
            else if ((age >= 18 && salary == 15000) || (age >= 20 && salary == 20000))
            {
                Console.WriteLine("You age over or 18 - 20. Salary you 15000 - 20000");
            }
            else if (age <= 0)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Bye");

            //Input end
            Console.ReadLine();
        }
    }
}
