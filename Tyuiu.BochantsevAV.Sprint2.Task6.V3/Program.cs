using Tyuiu.BochantsevAV.Sprint2.Task6.V3.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                 *");
            Console.WriteLine("* Тема: Получение результата из switch                                      *");
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #3                                                                *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                            *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.               *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine();

            Console.Write("Введите номер дня недели (1–7) -> ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: необходимо ввести целое число.");
                Console.ReadKey();
                return;
            }

            string result = ds.FindDayName(number);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine();

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
