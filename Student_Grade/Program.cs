using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO YOUR COMPUTE AVERAGE APP.\n");

        // Sleep for 1 seconds (100 milliseconds)
        Thread.Sleep(100);



        // Another example of using Thread.Sleep in a loop
        for (int i = 6; i > 1; i--)
        {
            Console.WriteLine($"Waiting in ... {i - 1}");
            Thread.Sleep(1000); // Sleep for 1 second (1000 milliseconds)
        }


        // Simulating a delay before asking for user input
        Thread.Sleep(100);
        Console.WriteLine("\nLet's get started with your student number");

        while (true)
        {
            Console.Write("(You must enter 4-2-3 code)");
            Console.Write("\nEnter your student number: ");
            string number = Console.ReadLine();

            if (System.Text.RegularExpressions.Regex.IsMatch(number, @"^\d{4}-\d{2}-\d{3}$"))
            {
                Console.WriteLine("\nHello! Kindly enter your grades:\n");

                // Sleep before asking for grades
                Thread.Sleep(100);
                float mathematics = ReadGrade("MATHEMATICS");
                Thread.Sleep(100);
                float science = ReadGrade("SCIENCE");
                Thread.Sleep(100);
                float history = ReadGrade("HISTORY");
                Thread.Sleep(100);
                float filipino = ReadGrade("FILIPINO");
                Thread.Sleep(100);
                float english = ReadGrade("ENGLISH");

                // Calculate and display average with a delay
                float average = (mathematics + science + history + filipino + english) / 5;
                Thread.Sleep(1000);

                float roundOffValue = (float)Math.Round(average);
                Console.WriteLine($"\nYour average is {average:F2} and the round off value is {roundOffValue}");

                // Determine pass or fail with a delay
                Thread.Sleep(1000);
                if (average >= 75)
                {
                    Console.WriteLine("\n_______________________________________");
                    Console.WriteLine("Congratulations! You passed! (*_*) ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n_______________________________________");
                    Console.WriteLine("Sorry, you failed! Try harder! (*,*)");
                
                }

                break;
            }
            else
            {
                Console.WriteLine("You entered an invalid student number! Please try again.");
            }
        }
    }

    // Method to read a grade from the user
    static float ReadGrade(string subject)
    {
        while (true)
        {
            Console.Write($"Enter your Grade in {subject}: ");
            string input = Console.ReadLine();

            // Try to parse the input
            if (float.TryParse(input, out float grade))
            {
                return grade;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadKey();
        }
    }
}