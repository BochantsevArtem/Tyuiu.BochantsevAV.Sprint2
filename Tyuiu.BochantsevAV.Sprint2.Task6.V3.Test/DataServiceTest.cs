using Tyuiu.BochantsevAV.Sprint2.Task6.V3.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDayName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1));
        }
    }
}
