using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[]
           {
                x + y == 1300,
                x - y != 750,
                y < x,
                x > x,
                x <= 1025,
                y >= x
           };

            return result;
        }
    }
}
