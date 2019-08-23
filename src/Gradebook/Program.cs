using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jack's Grade Book");

             while(true)
             { 
                 Console.WriteLine("Enter a grade or Enter a lowercase q to quit");
                var ginput = Console.ReadLine();
                    if(ginput == "q")
                        {
                            break;
                        }
                try
                {
                    var grade = double.Parse(ginput);
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
             }



           var stats = book.GetStats();

           Console.WriteLine($"The lowest grade is {stats.Low}");
           Console.WriteLine($"The highest grade is {stats.High}");
           Console.WriteLine($"The average grade is {stats.Average:N1}");
           Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
