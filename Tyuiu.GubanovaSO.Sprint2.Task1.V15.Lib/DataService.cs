using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GubanovaSO.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15

    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (d > c);
            res[1] = (a < b) & (c > d + 200);
            res[2] = (c < d) || (a > b);
            res[3] = (a + 5 < b) && (d > c);
            res[4] = !res[0];
            res[5] = (c > d) ^ (b < a);

            return res;
            //True, False, False, False, False, True
            //a = 415, b = 616, c = 134, d = 127
        }

    }

}

