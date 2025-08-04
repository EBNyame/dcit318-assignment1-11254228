using System;

namespace MultiTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select a Task:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void GradeCalculator()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Grade Calculator");
                Console.Write("Enter your numerical grade (0-100) or type 'back' to return to the menu: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "back") break;

                if (int.TryParse(input, out int grade))
                {
                    if (grade < 0 || grade > 100)
                        Console.WriteLine("Grade must be between 0 and 100.");
                    else if (grade >= 90)
                        Console.WriteLine("Your grade is: A");
                    else if (grade >= 80)
                        Console.WriteLine("Your grade is: B");
                    else if (grade >= 70)
                        Console.WriteLine("Your grade is: C");
                    else if (grade >= 60)
                        Console.WriteLine("Your grade is: D");
                    else
                        Console.WriteLine("Your grade is: F");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical value between 0 and 100.");
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        static void TicketPriceCalculator()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ticket Price Calculator");
                Console.Write("Enter your age or type 'back' to return to the menu: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "back") break;

                if (int.TryParse(input, out int age))
                {
                    if (age <= 12 || age >= 65)
                        Console.WriteLine("Your ticket price is: GHC7");
                    else
                        Console.WriteLine("Your ticket price is: GHC10");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        static void TriangleTypeIdentifier()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Triangle Type Identifier");
                Console.WriteLine("Enter the lengths of the three sides of the triangle.");
                Console.WriteLine("Type 'back' at any time to return to the menu.");

                double side1 = GetTriangleSide("Side 1");
                if (side1 == -1) break;

                double side2 = GetTriangleSide("Side 2");
                if (side2 == -1) break;

                double side3 = GetTriangleSide("Side 3");
                if (side3 == -1) break;

                // Identify Triangle Type
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("The triangle is Equilateral.");
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    Console.WriteLine("The triangle is Isosceles.");
                else
                    Console.WriteLine("The triangle is Scalene.");

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        static double GetTriangleSide(string sideName)
        {
            while (true)
            {
                Console.Write($"{sideName}: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "back") return -1;

                if (double.TryParse(input, out double side) && side > 0)
                    return side;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number or 'back'.");
            }
        }
    }
}
