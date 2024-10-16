using Tyuiu.GubanovaSO.Sprint2.Task3.V26.Lib;
namespace Tyuiu.GubanovaSO.Sprint2.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");  

            Console.WriteLine("Введите переменную X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(x);
            Console.WriteLine("Y=" + res);
        }
    }
}
