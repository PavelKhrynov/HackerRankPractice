using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        A child is playing a cloud hopping game.
        In this game, there are sequentially numbered clouds that can be thunderheads or cumulus clouds.
        The character must jump from cloud to cloud until it reaches the start again.
        There is an array of clouds, c and an energy level e = 100.
        The character starts from c[0] and uses 1 unit of energy to make a jump of size k to cloud c[(i + k) % n]. If it lands on a thundercloud, c[i] = 1, its energy (e) decreases by 2 additional units.
        The game ends when the character lands back on cloud 0.
        Given the values of n, k, and the configuration of the clouds as an array c, determine the final value of e after the game ends.
     */
    internal class JumpingontheCloudsRevisited
    {
        public static int SolveProblem(int[] c, int k)
        {
            int n = c.Length;
            int energy = 100;
            int index = 0;

            energy -= 1 + (c[index] == 1 ? 2 : 0);
            index = (index + k) % n;

            while (energy > 0 && index != 0)
            {
                energy -= 1 + (c[index] == 1 ? 2 :0);
                index = (index + k) % n;
            }

            return energy;
        }
    }
}
