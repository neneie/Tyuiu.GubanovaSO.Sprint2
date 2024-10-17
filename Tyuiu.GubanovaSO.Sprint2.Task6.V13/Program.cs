using Tyuiu.GubanovaSO.Sprint2.Task6.V13.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите год: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int g = Convert.ToInt32(Console.ReadLine());

            if ((n % 4 != 0) && ((n % 100 != 0) && (n % 400 != 0)))
            {
                Console.WriteLine("Год не является високосным");
            }


            int daysInMonth;
            if (m == 2)
            {
                daysInMonth = 29;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                daysInMonth = 30;
            }
            else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                daysInMonth = 31;
            }
            else
            {
                daysInMonth = 0;
            }

            int NextDay, NextMonth, NextYear;

            if (g == daysInMonth)
            {
                if (m == 12)
                {
                    NextDay = 1;
                    NextMonth = 1;
                    NextYear = n + 1;
                }
                else
                {
                    NextDay = 1;
                    NextMonth = m + 1;
                    NextYear = n;
                }
            }
            else
            {
                NextDay = g + 1;
                NextMonth = m;
                NextYear = n;
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine(NextDay + "." + NextMonth + "." + NextYear);
        }
    }
}
