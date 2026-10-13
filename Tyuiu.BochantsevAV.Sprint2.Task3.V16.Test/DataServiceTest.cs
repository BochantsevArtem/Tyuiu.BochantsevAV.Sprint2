using Tyuiu.BochantsevAV.Sprint2.Task3.V16.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {

            DataService ds = new DataService();

            double result = ds.Calculate(2);

            Assert.AreEqual(29.0, result, 0.001);

        }


        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(0);

            Assert.AreEqual(10.0 / 12.0, result, 0.001);
        }

        public void ValidCondition3()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(1);

            Assert.AreEqual(128.0, result, 0.001);
        }

        public void ValidCondition4()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(-21);

            Assert.AreEqual(-230.95238095, result, 0.001);
        }
    }
}