using Tyuiu.BilousEYu.Sprint3.Task7.V17.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 13.95;
            valueWaitArray[1] = 9.99;
            valueWaitArray[2] = 6.02;
            valueWaitArray[3] = 2.11;
            valueWaitArray[4] = -2.02;
            valueWaitArray[5] = -6.00;
            valueWaitArray[6] = -9.99;
            valueWaitArray[7] = -13.98;
            valueWaitArray[8] = -17.97;
            valueWaitArray[9] = -21.95;
            valueWaitArray[10] = -25.91;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);         
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}