using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("THIS PROGRAM CALCULATES STUDENT'S AVERAGE GRADE");

        Console.Write("Enter student's name: ");

        string studentName = Console.ReadLine();

        Console.Write("Enter number of grades: ");
        int numberOfGrades = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= numberOfGrades; i++)

        {
            Console.Write("Please enter grade number " + i + ": ");

            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine(studentName + "'s average grade is " + (sum / numberOfGrades));
    }
}