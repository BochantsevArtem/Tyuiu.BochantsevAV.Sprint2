using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task4V17
    {
        public double Calculate(double x, double y)
        {
            if (x == 0)
            {
                throw new ArgumentException("x не должен быть равен нулю.");
            }

            if (y < 0)
            {
                throw new ArgumentException("y не должен быть отрицательным.");
            }

            double z = (x - 22 > Math.Sqrt(y))
                ? Math.Pow(6 + 2 / (x * x), y)
                : y + 12 / (x * x);

            return z;
        }
    }
}
