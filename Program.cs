namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methods
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom",12);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}