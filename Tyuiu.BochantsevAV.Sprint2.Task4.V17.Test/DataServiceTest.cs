using Tyuiu.BochantsevAV.Sprint2.Task4.V17.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(23, 0);

            Assert.AreEqual(1.0, result, 0.001);
            
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(22, 4);

            double expected = 4 + 12.0 / (22 * 22);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
