using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task3.V16.Lib
{
    public class DataService : ISprint2Task3V16
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x + Math.Pow((x + 1) / (x - 1), 3);
            }
            else if (x == 0)
            {
                y = (2 * x * x - Math.Cos(x * x) + 10)
                    / (5 * x * x - Math.Sin(x * x) + 12);
            }
            else if (x > -20 && x < 2)
            {
                y = Math.Pow(1 + 1 / (x * x), 7);
            }
            else if (x < -20)
            {
                y = x + 10 * x - 1 / x;
            }
            else
            {
                throw new ArgumentException(
                    "Функция не определена при x = -20.");
            }

            return y;
        }
    }
}
