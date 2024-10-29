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
            
            string text = "have a nice time";
            char item = 'e';
            int count = ds.GetCharCount(text, item);

            Assert.AreEqual(3, count);
        }
    }
}