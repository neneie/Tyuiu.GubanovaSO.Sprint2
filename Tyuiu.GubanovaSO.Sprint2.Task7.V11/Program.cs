using Tyuiu.GubanovaSO.Sprint2.Task7.V11.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Введите x =                                                              *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите y =                                                              *");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);
        }
    }
}
