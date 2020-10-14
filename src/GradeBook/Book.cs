using System;
using System.Collections.Generic;

namespace GradeBook{
    public class Book{

        public Book(string name)
        {
            grades = new List<double>();
            Name = name; 
        }
        
        public void AddGrade(double grade)
        {
            if (grade <=100 && grade>=0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            
        }
         public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            


            /* var index = 0;
              // difference between do-while and while is that do-while will run at least once because we're checking the condition at the end...
                while (index < grades.Count )
                {
                    result.Low = Math.Min(grades[index], result.Low);
                    result.High = Math.Max(grades[index], result.High);
                    result.Average += grades[index];
                    index++;
                };
              */
            /*  for (var index = 0; index < grades.Count; index++)
                {
                   // if (grades[index] <= 50)
                   // {
                   //     break; for breaking out of the loop, skipping the loop completely and continuing with the opertation
                   //     continue; for skipping just one iteration;
                   //     goto done; go to line with label "done:"
                   // }

                    result.Low = Math.Min(grades[index], result.Low);
                    result.High = Math.Max(grades[index], result.High);
                    result.Average += grades[index];
                  //index++; remove index++ from the execution because it's moved to the for loop above
                };*/


            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
                result.Average /= grades.Count;
                
            
                switch(result.Average)
                {
                    case var d when d>=90.0:
                    result.Letter = 'A';
                    break;

                    case var d when d>=80.0:
                    result.Letter = 'B';
                    break;

                    case var d when d>=70.0:
                    result.Letter = 'C';
                    break;

                    case var d when d>=60.0:
                    result.Letter = 'D';
                    break;

                    default:
                    result.Letter = 'F';
                    break;
            }

            return result;

        }
        private List<double> grades;

        public string Name{
            get;
            set; //currently Type tests doesent work due to setting this prop to private
        }
        // public string Name //These two properties are the same
        // {
        //     get
        //     {
        //         return name;
        //     }
        //     set
        //     {
        //
        //          name = value;
        //         
        //     }
        // }

        // private string name;

    }
}