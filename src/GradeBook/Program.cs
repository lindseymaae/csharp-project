﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gradebook 1");
            book.AddGrade(89.1);
            book.AddGrade(77.5);
            book.AddGrade(80.5); 

            var stats = book.GetStatistics();    

            Console.WriteLine($"The average grade is {stats.Average:N1}"); //N1 makes it so that there is only one number after the decimal when returned
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
        }
    }
}