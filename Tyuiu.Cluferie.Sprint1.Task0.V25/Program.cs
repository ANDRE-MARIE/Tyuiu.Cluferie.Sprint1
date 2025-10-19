
using Tyuiu.Cluferie.Sprint1.Task0.V25.Lib;

internal class Program
{
   
    
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*                                                                                         *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*  (30 / 6 - 4 ) * 3                                                                            *");
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}