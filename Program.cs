﻿namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32("45"); //문자 X
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(num1 + num2);
            
            Console.ReadLine();
        }
    }
}