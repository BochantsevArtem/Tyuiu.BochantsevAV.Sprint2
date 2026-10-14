using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double distanceSquared = x * x + y * y;

            return y >= 0 &&
                   distanceSquared <= 4 &&
                   distanceSquared >= 1;
        }
    }
}
