using Tyuiu.BochantsevAV.Sprint2.Task7.V6.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Вариант #6                                                                *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                            *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные             *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами    *");
            Console.WriteLine("* X,Y в заштрихованной области.                                             *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine();

            Console.Write("Введите X -> ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Ошибка: введите число.");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите Y -> ");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Ошибка: введите число.");
                Console.ReadKey();
                return;
            }

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            if (result)
            {
                Console.WriteLine($"Точка ({x}; {y}) находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}; {y}) не находится в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}
