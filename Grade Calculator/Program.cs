using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade between 0 and 100: ");
        
        // Read the input from the user and convert it to an integer
        int grade;
        bool isValidInput = int.TryParse(Console.ReadLine(), out grade);

        // Check if the input is a valid integer and within the specified range
        if (isValidInput && grade >= 0 && grade <= 100)
        {
            // Determine the letter grade based on the numerical grade
            string letterGrade;
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Display the corresponding letter grade
            Console.WriteLine("The letter grade is: " + letterGrade);
        }
        else
        {
            // Display an error message if the input is not valid
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
        }
    }
}
