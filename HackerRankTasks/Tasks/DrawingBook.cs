using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        A teacher asks the class to open their books to a page number.
        A student can either start turning pages from the front of the book or from the back of the book.
        They always turn pages one at a time.
        When they open the book, page 1 is always on the right side.
        When they flip page 1, they see pages 2 and 3.
        Each page except the last page will always be printed on both sides.
        The last page may only be printed on the front, given the length of the book.
        If the book is n pages long, and a student wants to turn to page p, what is the minimum number of pages to turn?
        They can start at the beginning or the end of the book.
    */
    internal class DrawingBook
    {
        /// <summary>
        /// Count numbers of page turn to be on needed page
        /// </summary>
        /// <param name="n">Page number n book</param>
        /// <param name="p">Page to find</param>
        /// <returns>Number of page turn</returns>
        public static int SolveProblem(int n, int p)
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
