﻿namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Building an Exponent Method
            Console.WriteLine(GetPow(4, 3));
            
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++ )
            {
                result = result * baseNum;
            }

            return result;
        }

    }
}