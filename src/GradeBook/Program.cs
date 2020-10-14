using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program{
    
        static void Main(string[] args)
        {
            var book = new Book("Arman's Grade Book");


          //  var done = false;
            while(true)
            {
                Console.WriteLine("Enter the grade or enter letter 'q' to quit");
                var input = Console.ReadLine(); 

                if (input == "q")
                {
                    break;
                    //       done = true;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex) //catching Error from double.Parse(ARGEXC) or AddGrade(FORMEXC)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            /*    finally
                {
                    Console.WriteLine("*********");
                }*/
            }

            
            

            var stats = book.GetStatistics();

            Console.WriteLine($"for the book named ' {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");


        }
    }
}
