using Tyuiu.BochantsevAV.Sprint2.Task5.V15.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDayName()
        {
            DataService ds = new DataService();

            string result = ds.FindDayName(1);

            Assert.AreEqual("Понедельник", result);
        }
    }
}
