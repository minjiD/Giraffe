namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Return Statements
            //Console.WriteLine(cube(5));

            int cubeNumber = cube(5);
            Console.WriteLine(cubeNumber);

            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            
            return result;
        }
    }
}