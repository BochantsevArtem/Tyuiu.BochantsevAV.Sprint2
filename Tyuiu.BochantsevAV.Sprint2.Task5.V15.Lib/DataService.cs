using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BochantsevAV.Sprint2.Task5.V15.Lib

{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentException(
                    "Номер дня должен быть от 1 до 365.");
            }

            int day = k % 7;

            switch (day)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 0:
                    return "Воскресенье";
                default:
                    return "Ошибка";
            }
        }

    }
}