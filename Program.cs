using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Grade Calculator");
                Console.Write("Enter your score (0-100) or type 'exit' to quit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                }

                if (int.TryParse(input, out int grade))
                {
                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Score must be between 0 and 100.");
                    }
                    else if (grade >= 90)
                    {
                        Console.WriteLine("Your grade is: A");
                    }
                    else if (grade >= 80)
                    {
                        Console.WriteLine("Your grade is: B");
                    }
                    else if (grade >= 70)
                    {
                        Console.WriteLine("Your grade is: C");
                    }
                    else if (grade >= 60)
                    {
                        Console.WriteLine("Your grade is: D");
                    }
                    else
                    {
                        Console.WriteLine("Your grade is: F");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical (score) value between 0 and 100.");
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
