using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GubanovaSO.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[] x1 = { 6, 7, 8 };
            int[] x2 = { 3, 4, 5 };
            int[] x3 = { 3, 4, 5, 6 };
            int[] x4 = { 11, 12 };
            int[] x5 = { 10, 11, 12 };

            int[] y1 = { 3, 4 };
            int[] y2 = { 8, 9, 10 };
            int[] y3 = { 5, 6, 7 };


            if (((y >= 3) & (y <= 12)) & ((x <= 12) & (x >= 3)) & !((x1.Contains(x)) & (y1.Contains(y))) & !((x2.Contains(x)) & (y2.Contains(y))) & !((x3.Contains(x)) & (y == 12)) & !((x4.Contains(x)) & (y == 12)) & !((x5.Contains(x)) & (y2.Contains(y))) & !((x4.Contains(x)) & (y3.Contains(y))) & !((x5.Contains(x)) & (y1.Contains(y))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
