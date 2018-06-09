using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)

        {
            string dateOne, dateTwo;
            Console.WriteLine("Write dates in yyyy/mm/dd format.");
            Console.WriteLine("");
            Console.WriteLine("Please enter date one");
            dateOne = Console.ReadLine();

            Console.WriteLine("Please enter date two");
            dateTwo = Console.ReadLine();

            Console.WriteLine(dateOne);
            Console.WriteLine(dateTwo);
        }
    }
}
