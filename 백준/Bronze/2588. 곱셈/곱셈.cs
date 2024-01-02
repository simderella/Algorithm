namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[2])); //(int)Char.GetNumericValue() 일의자리 숫자를 Char 형식으로 변환
            Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[1]));
            Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[0]));
            Console.WriteLine(int.Parse(a) * int.Parse(b));
        }
    }
}