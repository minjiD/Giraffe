namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getters & Setters
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "AA");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // rating : G, PG, PG-13, R, NR

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }

    }
}