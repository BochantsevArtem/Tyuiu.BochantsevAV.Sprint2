using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool result =
               // Верхние части фигуры
               (y >= 3 && y <= 4 && x >= 3 && x <= 5) ||
               (y >= 3 && y <= 4 && x >= 9 && x <= 12) ||

               // Центральная часть
               (y == 5 && x >= 3 && x <= 12) ||
               (y >= 6 && y <= 7 && x >= 3 && x <= 13) ||
               (y == 8 && x >= 6 && x <= 13) ||

               // Нижние части фигуры
               (y >= 9 && y <= 10 &&
                   ((x >= 6 && x <= 7) || (x >= 11 && x <= 12))) ||
               (y == 11 &&
                   ((x >= 3 && x <= 7) || (x >= 11 && x <= 12))) ||
               (y == 12 &&
                   (x == 7 || (x >= 11 && x <= 12)));

            return result;
        }
    }
}
