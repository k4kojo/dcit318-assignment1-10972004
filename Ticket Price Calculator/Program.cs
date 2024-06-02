using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        
        // Read the input from the user and convert it to an integer
        int age;
        bool isValidInput = int.TryParse(Console.ReadLine(), out age);

        // Check if the input is a valid integer
        if (isValidInput && age >= 0)
        {
            // Determine the ticket price based on the age
            int ticketPrice;
            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7;
            }
            else
            {
                ticketPrice = 10;
            }

            // Display the ticket price
            Console.WriteLine("The ticket price is: GHC " + ticketPrice);
        }
        else
        {
            // Display an error message if the input is not valid
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
