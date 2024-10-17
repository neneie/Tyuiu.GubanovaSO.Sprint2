using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GubanovaSO.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x >= -1) && (y >= -1 && y <= 1) || (y >= 0 && y <= 1) && (y == x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
