
using Tyuiu.Cluferie.Sprint1.Task4.V24.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        {
            DataService ds = new DataService();


            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("*******************************************************************************************");

            int X, y;
            Console.WriteLine("Введите значение Х:");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("       ln x y (/ x + √ 2 y ^ 2) = " + ds.Calculate(X, y));
            Console.ReadKey();
        }
    }
}