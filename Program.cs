namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Class Attributes
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
            
            Console.WriteLine(kashmir.title);

            Console.ReadLine();
        }

    }
}