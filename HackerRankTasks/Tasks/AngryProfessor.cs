using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class AngryProfessor
    {
        public static string StartTask(int k, List<int> a)
        {
            int inTimeCount = a.Count(x => x <= 0);
            return inTimeCount < k ? "YES" : "NO";
        }
    }
}
