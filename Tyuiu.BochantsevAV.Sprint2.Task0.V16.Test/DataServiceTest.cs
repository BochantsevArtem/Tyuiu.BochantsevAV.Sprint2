using Tyuiu.BochantsevAV.Sprint2.Task0.V16.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            bool[] result = ds.GetCompareOperations(1025, 275);

            bool[] expected =
            {
                true,
                false,
                true,
                false,
                true,
                false
            };

           
          CollectionAssert.AreEqual(expected, result);
        }
    }
}
