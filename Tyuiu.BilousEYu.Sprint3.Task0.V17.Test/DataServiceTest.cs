using Tyuiu.BilousEYu.Sprint3.Task0.V17.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;
            double wait = -0.709;

            Assert.AreEqual(wait, ds.GetSumSeries(startValue, stopValue));
        }
    }
}