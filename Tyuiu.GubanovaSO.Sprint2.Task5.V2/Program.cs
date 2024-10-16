using Tyuiu.GubanovaSO.Sprint2.Task5.V2.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((num < 1) || (num > 12))
            {
                res = "Введеное значение неверно!";
            }
            else
            {
                res = "Сезон: " + ds.FindMonthSeason(num);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
        }
    }
}
