using Tyuiu.BilousEYu.Sprint3.Task1.V20.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTeGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0;
            int startValue = 1; 
            int stopValue = 16;
            
             double res = ds.GetSumSeries(startValue, stopValue);
            
            double wait = 51191.405;
            
            Assert.AreEqual(wait, res);
        }
    }
}