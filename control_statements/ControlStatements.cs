using System;

class Program
{
    static void Main123()
    {
        // Declaration and initialization of variables
        int numberOfStudents = 5;
        double totalScore = 0;

        // Iteration statement to process each student
        for (int i = 1; i <= numberOfStudents; i++)
        {
            // Declaration statement for storing the student's score
            double studentScore;

            // Prompt user for input using expression statement
            Console.Write($"Enter score for student {i}: ");
            
            // Expression statement to read input and assign it to the variable
            // Note: Input validation is not included for simplicity
            studentScore = Convert.ToDouble(Console.ReadLine());

            // Accumulate scores using expression statement
            totalScore += studentScore;

            // Selection statement to apply grading system
            if (studentScore >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (studentScore >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (studentScore >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // Jump statement to break out of the loop if a specific condition is met
            if (studentScore < 60)
            {
                Console.WriteLine("Student failed. Breaking out of loop.");
                break;
            }
        }

        // Expression statement to calculate and display the average score
        double averageScore = totalScore / numberOfStudents;
        Console.WriteLine($"Average Score: {averageScore}");
    }
}
