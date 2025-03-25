
    {
        Console.WriteLine("THIS PROGRAM CALCULATES THE AVERAGE GRADE OF STUDENTS USING C#");


        Console.Write("Enter Student's Name: ");
        string studentName = Console.ReadLine();


        Console.Write("Enter Number of Grades: ");
        int numberOfGrades;

      
        while (!int.TryParse(Console.ReadLine(), out numberOfGrades) || numberOfGrades <= 0)
        {
            Console.Write("Invalid number, please enter a POSITIVE number: ");
        }

        double sum = 0;

        
        for (int i = 1; i <= numberOfGrades; i++) 
        {
            double grade;
            Console.Write("Please enter grade number " + i + ": ");

            
            while (!double.TryParse(Console.ReadLine(), out grade) || grade <= 0)
            {
                Console.Write("Invalid grade: please enter a POSITIVE number: ");
            }

            sum = sum + grade; 
        }

    Console.WriteLine(studentName + "'s average grade is " + (sum / numberOfGrades).ToString("F2"));
    }

