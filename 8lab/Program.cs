using System;

namespace _8lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите Числитель:");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите Знаменатель:");
                    double y = double.Parse(Console.ReadLine());
                    double a;
                    a = x / y;
                    Console.WriteLine("Целая часть равна:");
                    Console.WriteLine($"{a:F0}") ;
                    if (y == 0)
                    {
                        throw new Exception("Знаменатель не должен быть равен 0");
                    }
                } 
                while(true);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}