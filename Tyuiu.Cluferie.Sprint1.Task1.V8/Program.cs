
using Tyuiu.Cluferie.Sprint1.Task1.V8.Lib;

//Задание
//Написат програму, которая вычисляем выражение (X * Pie) / A
namespace Tyuiu.Cluferie.Sprint1.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*  (X * Pie) / A                                                                          *");


            double X, Y;
            Console.WriteLine("Введите значение Х:");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("*******************************************************************************************");


            Console.WriteLine(ds.Calculate(X, Y));

            Console.ReadLine();
        }
    }
}