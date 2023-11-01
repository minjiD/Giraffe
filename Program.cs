namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Loops
            int[] luckyNumber = { 4, 8, 15, 16, 23, 42 };

            for(int i = 1; i <= luckyNumber.Length; i++)
            {
                Console.WriteLine(luckyNumber[i]);
            }
            
            Console.ReadLine();
        }

    }
}