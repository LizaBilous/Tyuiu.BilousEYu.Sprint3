using Tyuiu.BilousEYu.Sprint3.Task3.V26.Lib;
namespace Tyuiu.BilousEYu.Sprint3.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            
            string value = "have a nice time";
            char item = 'e';
            int res = ds.GetCharCount(value, item);

            Assert.AreEqual(3, res);
        }
    }
}