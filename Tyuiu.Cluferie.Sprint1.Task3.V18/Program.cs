

using Tyuiu.Cluferie.Sprint1.Task3.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
        Console.WriteLine("*******************************************************************************************");

        double a = 12;
        double b = 17;
        double c = 6;
        Console.WriteLine("Сторона А прамогльника = " + a);
        Console.WriteLine("Сторона B прамогльника = " + b);
        Console.WriteLine("Сторона B прамогльника = " + c);



        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                                               *");
        Console.WriteLine("*******************************************************************************************");

        Console.WriteLine("Внутри прямоугольника = " + ds.HowManySquares(a, b, c));
        Console.ReadLine();
    }
}
    
    
