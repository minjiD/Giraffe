namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(5 + 8); //13
            Console.WriteLine(5 - 8); //-3
            Console.WriteLine(5 * 8); //40
            Console.WriteLine(5 / 8); //0
            Console.WriteLine(5 % 2); //1
            Console.WriteLine((4 + 2) * 3); //18
            Console.WriteLine(5.0 + 8.1); //13.1
            Console.WriteLine(5 / 2.0); //2.5

            int num = 6;
            num++; //7
            //num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3.8, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}