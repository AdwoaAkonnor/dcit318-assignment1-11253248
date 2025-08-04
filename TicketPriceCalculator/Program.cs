using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ticket Price Calculator!");
            Console.Write("Please enter your age: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                int price = CalculateTicketPrice(age);
                Console.WriteLine($"Your ticket price is: GH₵{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for age.");
            }
        }

        static int CalculateTicketPrice(int age)
        {
            if (age < 5)
                return 0; // Free for toddlers
            else if (age <= 17)
                return 10; // Discount for children/teens
            else if (age >= 60)
                return 8; // Senior discount
            else
                return 15; // Standard adult price
        }
    }
}
