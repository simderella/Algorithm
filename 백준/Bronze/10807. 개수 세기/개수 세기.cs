namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); //첫째 줄에 정수의 개수 N(1 ≤ N ≤ 100)이 주어진다.
            string[] y = Console.ReadLine().Split(); //둘째 줄에는 정수가 공백으로 구분되어져있다.
            int z = 0; //배열y에 있는 숫자와 i가 동일 할 경우 카운팅
            int v = int.Parse(Console.ReadLine()); //셋째 줄에는 찾으려고 하는 정수 v가 주어진다.

            for (int i = 0; i < y.Length; i++)
            {
                if(v == int.Parse(y[i]))
                {
                    z++;
                }
            }
            Console.WriteLine(z);

        }
    }
}