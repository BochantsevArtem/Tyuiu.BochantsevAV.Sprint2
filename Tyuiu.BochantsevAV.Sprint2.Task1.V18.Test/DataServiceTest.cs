using Tyuiu.BochantsevAV.Sprint2.Task1.V18.Lib;
namespace Tyuiu.BochantsevAV.Sprint2.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            bool[] result = ds.GetLogicOperations(155, 696, 242, 541);

            bool[] expected =
            {
                true,
                true,
                true,
                false,
                true,
                false
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
