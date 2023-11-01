namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Loops
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            //Do While Loops
            int idx = 6;
            do
            {
                Console.WriteLine(idx);
                idx++;
            } while(idx <= 5);

            Console.ReadLine();
        }

    }
}