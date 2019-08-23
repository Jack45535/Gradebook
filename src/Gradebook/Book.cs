using System;
using System.Collections.Generic;

namespace Gradebook 
{
   public class Book 
    {
        public Book(string name)
            {
               grades = new List<double>(); 
               Name = name;
            }

        public void AddGrade(double grade)
            {
                if(grade<=100 && grade >= 0)
                {

                    grades.Add(grade);
                }

            }
        public Stats GetStats ()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

      
            for(var index = 0; index < grades.Count; index += 1)
                {
                    result.High = Math.Max(grades[index], result.High);
                    result.Low = Math.Min(grades[index], result.Low);
                    result.Average += grades[index];
                }
                
                result.Average /= grades.Count;

                switch(result.Average)
                    {
                        case var x when x >= 90.0:
                        result.Letter = 'A' ;
                        break;
                        
                        case var x when x >= 80.0:
                        result.Letter = 'B' ;
                        break;
                        
                        case var x when x >= 70.0:
                        result.Letter = 'C' ;
                        break;
                        
                        case var x when x >= 60.0:
                        result.Letter = 'D' ;
                        break;
                        
                        default:
                        result.Letter = 'F' ;
                        break;
                        
                    }

                return result;
        }

       private List<double> grades;      
        public string Name;
    }

}