using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    /*
        Lisa just got a new math workbook.
        A workbook contains exercise problems, grouped into chapters.
        Lisa believes a problem to be special if its index (within a chapter) is the same as the page number where it's located.
        The format of Lisa's book is as follows:
        - There are n chapters in Lisa's workbook, numbered from 1 to n.
        - The i chapter has arr[i] problems, numbered from 1 to arr[i].
        - Each page can hold up to k problems. Only a chapter's last page of exercises may contain fewer than k problems.
        - Each new chapter starts on a new page, so a page will never contain problems from more than one chapter.
        - The page number indexing starts at 1.
        Given the details for Lisa's workbook, can you count its number of special problems?
    */
    internal class LisasWorkbook
    {
        /// <summary>
        /// Count number of problems
        /// </summary>
        /// <param name="n">Number of chapters</param>
        /// <param name="k">Maximum number of problem per page</param>
        /// <param name="arr">Number of problems in each chapter</param>
        /// <returns>Number of problems</returns>
        public static int SolveProblem(int n, int k, List<int> arr)
        {
            int numberOfSpecialProblems = 0;

            int pageNumber = 1;
            for (int i = 0; i < arr.Count; i++)
            {
                int chapterProblems = arr[i];
                for (int problemIdWithinChapter = 1; problemIdWithinChapter <= chapterProblems; problemIdWithinChapter++)
                {
                    // если id проблемы совпадает со страницей, то особая проблема +1
                    if(problemIdWithinChapter == pageNumber)
                    {
                        numberOfSpecialProblems++;
                    }
                    // если это последняя влезающая на страницу проблема, то страница +1
                    if (problemIdWithinChapter % k == 0)
                    {
                        pageNumber++;
                    }
                }
                // по завершению прохода по проблемам, если их общее число не помещается целиком на занятых страницах, то есть ещё одна
                if (chapterProblems % k != 0)
                {
                    pageNumber++;
                }
            }

            return numberOfSpecialProblems;
        }
    }
}
