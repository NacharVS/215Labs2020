using System;
using System.Threading;
using System.Threading.Tasks;

namespace _215Labs2020
{
    class Program
    {
        static void Factorial(int n)
        {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                    Console.WriteLine($"Факториал {i} равен :  {result}");
                    Thread.Sleep(1000);
                }
        }
        static async void FactorialAsync(int n)
        {
                await Task.Run(() => Factorial(n));
        }
        static void Main(string[] args)
        {
                FactorialAsync(5);
                int x = int.Parse(Console.ReadLine());
                for (int i = 0; i < x; i++)
                {
                    Console.Write(i + " ");
                }
                Console.ReadLine();
        }
        
    
    }
}
