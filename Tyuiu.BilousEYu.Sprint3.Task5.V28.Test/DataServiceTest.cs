using Tyuiu.BilousEYu.Sprint3.Task5.V28.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 12;
            Assert.AreEqual(-349.648, ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}