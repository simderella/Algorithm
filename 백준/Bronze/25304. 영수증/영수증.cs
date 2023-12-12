using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalprice = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int price = 0;

            for (int i = 0; i < num; i++)
            {
                string[] arr = Console.ReadLine().Split();
                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);

                price += a * b;
            }

            if (totalprice == price) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}