namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2d Arrays
            int[,] numberGrid = {
                { 1, 2},
                { 3, 4},
                { 5, 6}
            };

            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[0, 0]);
            
            Console.ReadLine();
        }

    }
}