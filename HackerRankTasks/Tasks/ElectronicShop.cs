using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks.Tasks
{
    internal class ElectronicShop
    {
        public static int StartTask(int[] keyboards, int[] drives, int b)
        {
            // сортируем списки цен товаров по возрастанию
            var sortedKeyboards = keyboards.OrderBy(x => x).ToList();
            var sortedDrivers = drives.OrderBy(x => x).ToList();

            // проходим по каждому списку с конца в поисках наибольшей комбинации
            int currentHighestPossiblePrice = -1;
            for (int i = sortedKeyboards.Count - 1; i >= 0; i--)
            {
                int keyboardPrice = sortedKeyboards[i];
                // если цена первого товара уже больше бюджета, то нет смысла идти во второй цикл
                if (keyboardPrice > b)
                {
                    continue;
                }
                for (int j = sortedDrivers.Count - 1; j >= 0; j--)
                {
                    int driverPrice = sortedDrivers[j];
                    int totalPrice = keyboardPrice + driverPrice;
                    // общая цена ниже прошлой самой больше - заканчиваем с этой итарацией первого товара
                    if (totalPrice <= currentHighestPossiblePrice)
                    {
                        break;
                    }
                    // общая цена больше бюджета - переключаемся на следующую итерацию второго товара без присвоения наибольшего значения
                    if (totalPrice > b)
                    {
                        continue;
                    }
                    currentHighestPossiblePrice = totalPrice;
                }
            }

            return currentHighestPossiblePrice;
        }
    }
}
