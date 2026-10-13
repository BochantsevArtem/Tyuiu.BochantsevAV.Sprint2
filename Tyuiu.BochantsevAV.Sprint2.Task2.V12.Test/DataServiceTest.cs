using Tyuiu.BochantsevAV.Sprint2.Task2.V12.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            bool result = ds.CheckDotInShadedArea(3, 3);

            Assert.IsTrue(result);
        }
    }
}
