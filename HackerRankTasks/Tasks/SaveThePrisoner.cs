using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        A jail has a number of prisoners and a number of treats to pass out to them.
        Their jailer decides the fairest way to divide the treats is to seat the prisoners around a circular table in sequentially numbered chairs.
        A chair number will be drawn from a hat.
        Beginning with the prisoner in that chair, one candy will be handed to each prisoner sequentially around the table until all have been distributed.
        The jailer is playing a little joke, though.
        The last piece of candy looks like all the others, but it tastes awful.
        Determine the chair number occupied by the prisoner who will receive that candy.
    */
    internal class SaveThePrisoner
    {
        public static int SolveProblem(int n, int m, int s)
        {
            // отбросим полные циклы - нас это не волнует
            int shiftWithoutCicle = m - ((m - 1) / n) * n;

            // получаем финальную позицию (-1, потому что первый в позиции тоже берет себе конфету)
            int finalPosition = s + shiftWithoutCicle - 1;
            // делаем коректировку в случае выхода за границы
            if (finalPosition > n)
            {
                finalPosition = 0 + (finalPosition - n);
            }

            return finalPosition;
        }
    }
}
