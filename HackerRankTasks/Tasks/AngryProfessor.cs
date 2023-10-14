using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        A Discrete Mathematics professor has a class of students.
        Frustrated with their lack of discipline, the professor decides to cancel class if fewer than some number of students are present when class starts.
        Arrival times go from on time (arrivalTime <= 0) to arrived late (arrivalTime > 0).
    */
    internal class AngryProfessor
    {
        /// <summary>
        /// Determine if class canceled or not
        /// </summary>
        /// <param name="k">Minimum number of student to not cancel the class</param>
        /// <param name="a">List of arrival time of students</param>
        /// <returns>YES if class canceld otherwise NO</returns>
        public static string SolveProblem(int k, List<int> a)
        {
            int inTimeCount = a.Count(x => x <= 0);
            return inTimeCount < k ? "YES" : "NO";
        }
    }
}
