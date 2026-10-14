using Tyuiu.BochantsevAV.Sprint2.Task7.V6.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1.5));
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 0.5));
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 0));
            Assert.IsFalse(ds.CheckDotInShadedArea(3, 1));
        }
    }
}
