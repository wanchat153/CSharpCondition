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
            if (age < 18)
            {
                Console.WriteLine("False");
            }else if (age >= 18)
            {
                Console.WriteLine("True");
            }
            Console.WriteLine("Bye");
        }
    }
}
