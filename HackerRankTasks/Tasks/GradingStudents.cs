using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class GradingStudents
    {
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
