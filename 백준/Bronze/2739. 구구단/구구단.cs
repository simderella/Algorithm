using System;

namespace for문1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n*i}");
            }
        }
    }
}