using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            // String inputs from user for the dates and the DateTime structure.

            
            DateTime dateOne, dateTwo;

            // as the structures currently have no value, they get sent down to a different function to obtain value.

            Console.WriteLine("This program will calculate the difference in days, hours, and minutes between two dates that you enter." + "\n");
            

            dateOne = GetDateInput();
            dateTwo = GetDateInput();

            // This portion of the code calculates the difference in the two dates that the user entered an assigns them to
            // a new variable named timeDifference.

            var timeDifference = dateTwo - dateOne;


            // This portion writes timeDifference in days, hours, and minutes. It also is displayed in absolute values so 
            // the hours, minutes, and seconds are not negative, as that isn't really possible.

            Console.WriteLine("\n" + "The total days between the dates are " + Math.Abs(timeDifference.TotalDays));
            Console.WriteLine("\n" + "The total hours between the dates are " + Math.Abs(timeDifference.TotalHours));
            Console.WriteLine("\n" + "The total minutes between the dates are " + Math.Abs(timeDifference.TotalMinutes));

        }
        // This function is called upon to give dateOne and dateTwo values entered in by the user.

        static DateTime GetDateInput()
        {
            string userInput;
            DateTime entryDate;
            // Here it is requested by the user to enter in write a date for the program. It also checks to see if the user
            // entered in a valid date. If the user did not enter in a valid date it asks the user to do so until they enter
            // in a valid date.

            Console.WriteLine("\n" + "Please enter the dates in dd/mm/yyyy");
            userInput = Console.ReadLine();
            bool success = DateTime.TryParse(userInput, out entryDate);

            if (success == true)
            {
                return entryDate;
            }
            else
            {
                Console.WriteLine("Please write a valid date." + "\n");
                return GetDateInput();
            }



        }

    }
}
