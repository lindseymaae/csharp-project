using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Gradebook 1");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                   break;
                }
                try 
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            
           
            var stats = book.GetStatistics();    
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The average grade is {stats.Average}"); //N1 makes it so that there is only one number after the decimal when returned
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            Console.WriteLine($"The lowest grade is: {stats.Low}");
           
        }
    }
}
