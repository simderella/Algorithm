namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            if(x > y)
            {
                Console.WriteLine(">");
            }
            else if(y > x)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}