namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Methods & Classes
            //Console.WriteLine(Math.Sqrt(144));

            //UsefulTools tool = new UsefulTools(); // 정적 클래스 인스턴스 생성 X
            UsefulTools.SayHi("Mike");

            Console.ReadLine();
        }

    }
}