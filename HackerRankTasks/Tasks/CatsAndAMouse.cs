using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Two cats and a mouse are at various positions on a line.
        You will be given their starting positions.
        Your task is to determine which cat will reach the mouse first, assuming the mouse does not move and the cats travel at equal speed.
        If the cats arrive at the same time, the mouse will be allowed to move and it will escape while they fight.
     */
    internal class CatsAndAMouse
    {
        /// <summary>
        /// Determine who is the winner of Cats and Mouse fight
        /// </summary>
        /// <param name="cat1Position">First cat position</param>
        /// <param name="cat2Position">Second cat position</param>
        /// <param name="mousePosition">Mouse position</param>
        /// <returns>Winner of the fight as string</returns>
        public static string SolveProblem(int cat1Position, int cat2Position, int mousePosition)
        {
            int cat1Path = Math.Abs(cat1Position - mousePosition);
            int cat2Path = Math.Abs(cat2Position - mousePosition);

            return cat1Path == cat2Path ? "Mouse C" : (cat1Path < cat2Path ? "Cat A" : "Cat B");
        }
    }
}
