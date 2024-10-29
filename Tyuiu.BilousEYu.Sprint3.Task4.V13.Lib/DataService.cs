using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BilousEYu.Sprint3.Task4.V13.Lib
{
    public class DataService : ISprint3Task4V13
    {
        public double Calculate(int startValue, int stopValue)
        {
            double mult = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                mult *= Math.Sin(x) / Math.Cos(x);
            }
            return Math.Round(mult, 3);
        }
    }
}
