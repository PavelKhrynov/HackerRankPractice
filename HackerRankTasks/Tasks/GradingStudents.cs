using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        HackerLand University has the following grading policy:
        * Every student receives a  in the inclusive range from 0 to 100.
        * Any grade less than 40 is a failing grade.
        Sam is a professor at the university and likes to round each student's grade according to these rules:

        If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
        If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
    */
    internal class GradingStudents
    {
        /// <summary>
        /// Round the list of grades
        /// </summary>
        /// <param name="grades">List of grades</param>
        /// <returns>List of rounded grades</returns>
        public static List<int> StartTask(List<int> grades)
        {
            var result = new List<int>();

            for (int i = 0; i < grades.Count; i++) 
            {
                var grade = grades[i];
                
                if (grade < 38)
                {
                    result.Add(grade);
                }
                else
                {
                    int reminder = grade % 5;
                    if (reminder < 3)
                    {
                        result.Add(grade);
                    }
                    else
                    {
                        result.Add((grade / 5) * 5 + 5);
                    }
                }
            }

            return result;
        }
    }
}
