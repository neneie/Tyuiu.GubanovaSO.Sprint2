using Tyuiu.GubanovaSO.Sprint2.Task2.V6.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            while (true)
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Введите x:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите y:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            }
        }
    }
}
