using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            // String inputs from user for the dates
            string entryOne, entryTwo;
            

            DateTime dateOne, dateTwo;
            dateOne = new DateTime(1990, 11, 23);
            dateTwo = new DateTime(1990,11,22);

            /*
            // This is the beginning where people enter in the dates to find the difference
            Console.WriteLine("Write dates in yyyy/mm/dd format.");
            Console.WriteLine("");
            Console.WriteLine("Please enter date one.");

            //This converts what the user inputs into the DateTime
            entryOne = Console.ReadLine();
            dateOne = DateTime.Parse(entryOne);


            Console.WriteLine("Please enter date two.");
            entryTwo = Console.ReadLine();
            dateTwo = DateTime.Parse(entryTwo);
            */

            Console.WriteLine("The first date is {0} ", dateOne);
            Console.WriteLine("The second date is {0} ", dateTwo);

            // What I have is starting date and the ending date. 
            // I need the time span between the two dates
            var timeDifference = dateTwo - dateOne;
            
                
            //-----------------------------------------

            // 
            // What I need is the hours, minutes, seconds between the two dates
            
            Console.WriteLine(Math.Abs(timeDifference.TotalHours));
            Console.WriteLine(Math.Abs(timeDifference.TotalMinutes));
            Console.WriteLine(Math.Abs(timeDifference.TotalSeconds));



        }

    }
}
