namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = -30;
            double gpa = 3.2; //float, double, decimal
            bool isFemale = true;

            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academies"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy")); //값이 없으면 -1 return
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8, 3));

            Console.ReadLine();
        }
    }
}