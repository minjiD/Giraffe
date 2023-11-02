namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }

    }
}