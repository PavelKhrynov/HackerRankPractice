using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.MediumTasks
{
    /*
        An arcade game player wants to climb to the top of the leaderboard and track their ranking.
        The game uses Dense Ranking, so its leaderboard works like this:
        * The player with the highest score is ranked number 1 on the leaderboard.
        * Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following ranking number.
    */
    internal class ClimbingTheLeadboard
    {
        /// <summary>
        /// Calculate rank of each new player score
        /// </summary>
        /// <param name="ranked">Initial leadboard in descending order</param>
        /// <param name="player">List of score for each player attempt in ascending order</param>
        /// <returns>List of ranks for each player attempt</returns>
        public static List<int> StartTask(List<int> ranked, List<int> player)
        {
            var result = new List<int>();

            // Какой ранг будет у каждого уникального счета в таблице
            var ranksFroRankedScore = new Dictionary<int, int>();
            // Какой ранг будет у каждого нового счета в таблице
            var rankForPlayerScore = new Dictionary<int, int>();

            int rankedCount = ranked.Count;
            int playerCount = player.Count;
            int playerIterator = playerCount - 1;
            int rankedIterator = 0;
            int rankedRank = 1; // первый ранг = 1, а не 0 по условиям

            // Будем проходить по 2м массивам сразу
            // Массив текущего счёта проходим с конца, а массив таблицы рангов с начала, таким образом каждый будем проходить по уменьшению значений
            while (playerIterator >= 0 || rankedIterator < rankedCount)
            {
                // Если итератор выходит за пределы массива, то можно указать значение как 0
                int rankedScore = rankedIterator < rankedCount ? ranked[rankedIterator] : 0;
                int playerScore = playerIterator >= 0 ? player[playerIterator] : 0;

                // Выставляем текущий ранг в таблице рекондов для счета, без учета новых значений.
                // Берём только уникальный счёт, нет смысла повторяться - ранг для них будет один
                if (!ranksFroRankedScore.ContainsKey(rankedScore))
                {
                    ranksFroRankedScore[rankedScore] = rankedRank;
                    // сразу увеличим ранг для следующей итерации
                    rankedRank++;
                }

                // Ранг для нового счёта выставляем тоже для уникальных значений и так же если он больше или равен текущему обрабатываемогу счёту в таблице
                // Потому что если новый счет больше, то он сдвинет прошлый и станет его ранга, а если равен, то просто станет его ранга
                if (!rankForPlayerScore.ContainsKey(playerScore) && playerScore >= rankedScore)
                {
                    rankForPlayerScore[playerScore] = ranksFroRankedScore[rankedScore];
                }

                // Итераторы увеличиваются по такому принципу
                // Пока значение в одном массиве больше, перебираем его, пока не сравняемся, потом перебираем второй, пока снова не сравняемся
                // Если значения одинаковые, то можно двигать оба итератора
                // Так пройдём оба массива, т.е. сделаем n + m итераций
                if (playerScore >= rankedScore)
                {
                    playerIterator--;
                }
                if (rankedScore >= playerScore)
                {
                    rankedIterator++;
                }
            }

            // Пройдем по массиву всех новых значений и посмотрим какой у них будет ранг, здесь уже могут быть повторы
            for (int i = 0; i < player.Count; i++)
            {
                int playerScore = player[i];
                int playerScoreRank = rankForPlayerScore[playerScore];
                result.Add(playerScoreRank);
            }

            return result;
        }
    }
}
