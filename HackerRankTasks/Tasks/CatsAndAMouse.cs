using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class CatsAndAMouse
    {
        public static string StartTask(int cat1Position, int cat2Position, int mousePosition)
        {
            int cat1Path = Math.Abs(cat1Position - mousePosition);
            int cat2Path = Math.Abs(cat2Position - mousePosition);

            return cat1Path == cat2Path ? "Mouse C" : (cat1Path < cat2Path ? "Cat A" : "Cat B");
        }
    }
}
