namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If Statements
            bool isFemale = false;
            bool isTall = true;

            if (isFemale && isTall)
            {
                Console.WriteLine("You are a tall female");
            } 
            else if (isFemale && !isTall) {
                Console.WriteLine("You are a short female");
            }
            else if (!isFemale && isTall)
            {
                Console.WriteLine("You are not a female but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not female or not tall or both");
            }

            Console.ReadLine();
        }

    }
}