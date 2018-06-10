using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)

        {
            string entryOne, entryTwo;
            // This is the beginning where people enter in the dates to find the difference 
            
            Console.WriteLine("Write dates in yyyy/mm/dd format.");
            Console.WriteLine("");
            Console.WriteLine("Please enter date one.");
            //This converts what the user inputs into the DateTime
            entryOne = Console.ReadLine();
            DateTime dateOne = DateTime.Parse(entryOne);


            Console.WriteLine("Please enter date two.");
            entryTwo = Console.ReadLine();
            DateTime dateTwo = DateTime.Parse(entryTwo);

            Console.WriteLine(dateOne);
            Console.WriteLine(dateTwo);
        }

    }
}
