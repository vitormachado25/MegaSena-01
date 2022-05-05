using System;

namespace MegaSena_01
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------- MEGA - SENA ----------------");

            Console.WriteLine(" 01 - 02 - 03 - 04 - 05 - 06 - 07 - 08 - 09 - 10");
            Console.WriteLine(" 11 - 12 - 13 - 14 - 15 - 16 - 17 - 18 - 19 - 20");
            Console.WriteLine(" 21 - 22 - 23 - 24 - 25 - 26 - 27 - 28 - 29 - 30");
            Console.WriteLine(" 31 - 32 - 33 - 34 - 35 - 36 - 37 - 38 - 39 - 40");
            Console.WriteLine(" 41 - 42 - 43 - 44 - 45 - 46 - 47 - 48 - 49 - 50");
            Console.WriteLine(" 51 - 52 - 53 - 54 - 55 - 56 - 57 - 58 - 59 - 60");

            Console.WriteLine("Escolha e digite 6 números para apostar!");


            int[] betNumbers = new int[] { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };




            Random numbers = new Random();
            int numbersDrawn1 = numbers.Next(0, 1);
            int numbersDrawn2 = numbers.Next(0, 60);
            int numbersDrawn3 = numbers.Next(0, 60);
            int numbersDrawn4 = numbers.Next(0, 60);
            int numbersDrawn5 = numbers.Next(0, 60);
            int numbersDrawn6 = numbers.Next(0, 60);


            int numbersTyping1 = int.Parse(Console.ReadLine());
            int numbersTyping2 = int.Parse(Console.ReadLine());
            int numbersTyping3 = int.Parse(Console.ReadLine());
            int numbersTyping4 = int.Parse(Console.ReadLine());
            int numbersTyping5 = int.Parse(Console.ReadLine());
            int numbersTyping6 = int.Parse(Console.ReadLine());


            foreach (int numbersBet in betNumbers)
            {
                if (numbersTyping1 == numbersBet)
                {
                }

                if (numbersTyping2 == numbersBet)
                {
                }

                if (numbersTyping3 == numbersBet)
                {
                }

                if (numbersTyping4 == numbersBet)
                {
                }

                if (numbersTyping5 == numbersBet)
                {
                }

                if (numbersTyping6 == numbersBet)
                {
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");

                    Console.WriteLine($" {numbersDrawn1} - {numbersDrawn2} - {numbersDrawn3} - {numbersDrawn4} - {numbersDrawn5} - {numbersDrawn6}");

                }
            }
            Console.WriteLine();
            Console.WriteLine();

            if ((numbersTyping1 == numbersDrawn1) || (numbersTyping1 == numbersDrawn2) || (numbersTyping1 == numbersDrawn3))
            {
                Console.WriteLine("Você acertou um número!");
            }

            if((numbersTyping1 == numbersDrawn4 ) || (numbersTyping1 == numbersDrawn5) || (numbersTyping1 == numbersDrawn6))
            {
                
            }

        }
    }
} 


