using Tyuiu.BilousEYu.Sprint3.Task2.V16.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            
            int value = 2;
            int stopValue = 5;
            int startValue = 1;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 14400;
            Assert.AreEqual(wait, res);
        }
    }
}