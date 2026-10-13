using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[]
           {
                (a + c < b + d) | (c > d),
                (a != b) & (c <= d),
                (a < b) || (c == d),
                (a > b) && (c < d),
                !(a + c >= b + d),
                (a > b) ^ (c > d)
           };

            return result;
        }
    }
}
