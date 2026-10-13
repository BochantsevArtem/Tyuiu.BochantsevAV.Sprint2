using Tyuiu.BochantsevAV.Sprint2.Task2.V12.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");


            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine();

            Console.Write("Введите координату X -> ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y -> ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            if (result)
            {
                Console.WriteLine($"Точка ({x}; {y}) находится в закрашенной области.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}; {y}) не находится в закрашенной области.");
            }

            Console.ReadKey();



        }
    }
}
