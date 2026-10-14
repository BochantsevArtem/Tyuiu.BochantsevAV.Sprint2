using Tyuiu.BochantsevAV.Sprint2.Task5.V15.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бочанцев А.В | ИИПБ-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил Бочанцев Артем Викторович | ИИПБ-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является       *");
            Console.WriteLine("* k-й день не високосного года, в котором 1 января понедельник.           *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine();

            Console.Write("Введите номер дня k (1–365) -> ");

            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                Console.ReadKey();
                return;
            }

            try
            {
                string result = ds.FindDayName(k);

                Console.WriteLine();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine();

                Console.WriteLine($"{k}-й день года — {result}.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
