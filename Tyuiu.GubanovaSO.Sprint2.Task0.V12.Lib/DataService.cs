using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GubanovaSO.Sprint2.Task0.V12.Lib
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 620;
            res[1] = x != y + 620;
            res[2] = x < y * 3;
            res[3] = x > y * 3; 
            res[4] = x <= y * 3;
            res[5] = x >= y * 3;

            return res;
        }
    }
}
