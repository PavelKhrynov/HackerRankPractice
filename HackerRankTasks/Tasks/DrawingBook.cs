using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class DrawingBook
    {
        //n - число страниц в книге, p - искомая страница
        public static int StartTask(int n, int p)
        {
            // общее число пар страниц в книге
            int numberOfPagePairs = n / 2 + 1;
            // сколько надо сделать переворотов с начала книги до искомой страницы
            int frontPageTurning = p / 2;
            // какая по счёту будет пара страниц с искомой
            int frontPagePairNum = frontPageTurning + 1;
            // сколько переворотов надо сделать с конца книги
            int backPageTurning = numberOfPagePairs - frontPagePairNum;

            return Math.Min(frontPageTurning, backPageTurning);
        }
    }
}
