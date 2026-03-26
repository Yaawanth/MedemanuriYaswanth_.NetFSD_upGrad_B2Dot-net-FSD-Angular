using System;

class Student
{
    // Method to calculate average
    public double CalculateAverage(int m1, int m2, int m3)
    {
        double avg = (m1 + m2 + m3) / 3.0;
        return avg;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int m1, m2, m3;

        Console.WriteLine("Enter three marks:");
        m1 = Convert.ToInt32(Console.ReadLine());
        m2 = Convert.ToInt32(Console.ReadLine());
        m3 = Convert.ToInt32(Console.ReadLine());

        // Create object
        Student s = new Student();

        // Call method
        double average = s.CalculateAverage(m1, m2, m3);

        string grade;

        if (average >= 80)
        {
            grade = "A";
        }
        else if (average >= 60)
        {
            grade = "B";
        }
        else if (average >= 50)
        {
            grade = "C";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine("Average = " + average);
        Console.WriteLine("Grade = " + grade);
    }
}
