namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string charecterName = "Tom";
            int charecterAge = 25;

            Console.WriteLine("There once was a man named " + charecterName);
            Console.WriteLine("He was " + charecterAge + " years old");

            charecterName = "Mike";
            Console.WriteLine("He really liked the name " + charecterName);
            Console.WriteLine("But didn't like being " + charecterAge);


            Console.ReadLine();
        }
    }
}