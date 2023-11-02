namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructors
            Book book1 = new Book("Harry Potter", "JK Rowling", 400); // calling constructor
            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700); // calling constructors
            Book book3 = new Book();

            book2.title = "The hobbit";

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }

    }
}