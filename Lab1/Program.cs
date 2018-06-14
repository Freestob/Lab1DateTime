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
            /*
#if DEBUG
            dateOne = new DateTime(1990, 11, 23);
            dateTwo = new DateTime(1990, 11, 22);
#else
*/
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

            dateOne = GetDateInput();
            dateTwo = GetDateInput();

//#endif


            Console.WriteLine("The first date is {0} ", dateOne);
            Console.WriteLine("The second date is {0} ", dateTwo);

            // What I have is starting date and the ending date. 
            // I need the time span between the two dates
            var timeDifference = dateTwo - dateOne;


            //-----------------------------------------

            // 
            // What I need is the hours, minutes, seconds between the two dates

            Console.WriteLine("The total hours between the dates are " + Math.Abs(timeDifference.TotalHours));
            Console.WriteLine("The total minutes between the dates are " + Math.Abs(timeDifference.TotalMinutes));
            Console.WriteLine("The total seconds between the dates are " + Math.Abs(timeDifference.TotalSeconds));

        }

        static DateTime GetDateInput()
        {
            string userInput;
            DateTime entryDate;

            Console.WriteLine("Please enter a date.");
            userInput = Console.ReadLine();
            bool success = DateTime.TryParse(userInput, out entryDate);

            if(success ==true)
            {
                return entryDate;
            }
            else
            {
                Console.WriteLine("Hey, write a valid date.");
                return GetDateInput();
            }



        }

    }
}
