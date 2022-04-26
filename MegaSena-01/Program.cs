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

            var numbersChosen = 0 ;

            var letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int[] betNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 };


            Console.WriteLine("Escolha e digite 6 números para apostar!");
            int numbersTyping = int.Parse(Console.ReadLine());
            Console.WriteLine($" {numbersTyping}");

            foreach(int numbersBet in betNumbers)
            {
                if(numbersTyping == numbersBet)
                {

                }
            }

            if (numbersTyping == letras)
            {
                Console.WriteLine("Não digite letras!!");
            }
            if (!(numbersTyping === betNumbers))
            {
            }
            if (numbersTyping == 2)
            {
            }
            if (numbersTyping == 3)
            {
            }
            if (numbersTyping == 4)
            {
            }
            if (numbersTyping == 5)
            {
            }
            if (numbersTyping == 6)
            {
            }
            if (numbersTyping == 7)
            {
            }
            if (numbersTyping == 8)
            {
            }
            if (numbersTyping == 9)
            {
            }
            if (numbersTyping == 10)
            {
            }
            if (numbersTyping == 11)
            {
            }
            if (numbersTyping == 12)
            {
            }
            if (numbersTyping == 13)
            {
            }
            if (numbersTyping == 14)
            {
            }
            if (numbersTyping == 15)
            {
            }
            if (numbersTyping == 16)
            {
            }
            if (numbersTyping == 17)
            {
            }
            if (numbersTyping == 18)
            {
            }
            if (numbersTyping == 19)
            {
            }
            if (numbersTyping == 20)
            {
            }
            if (numbersTyping == 21)
            {
            }
            if (numbersTyping == 22)
            {
            }
            if (numbersTyping == 23)
            {
            }
            if (numbersTyping == 24)
            {
            }
            if (numbersTyping == 25)
            {
            }
            if (numbersTyping == 26)
            {
            }
            if (numbersTyping == 27)
            {
            }
            if (numbersTyping == 28)
            {
            }
            if (numbersTyping == 29)
            {
            }
            if (numbersTyping == 30)
            {
            }
            if (numbersTyping == 31)
            {
            }
            if (numbersTyping == 32)
            {
            }
            if (numbersTyping == 33)
            {
            }
            if (numbersTyping == 34)
            {
            }
            if (numbersTyping == 35)
            {
            }
            if (numbersTyping == 36)
            {
            }
            if (numbersTyping == 37)
            {
            }
            if (numbersTyping == 38)
            {
            }
            if (numbersTyping == 39)
            {
            }
            if (numbersTyping == 40)
            {
            }
            if (numbersTyping == 41)
            {
            }
            if (numbersTyping == 42)
            {
            }
            if (numbersTyping == 43)
            {
            }
            if (numbersTyping == 44)
            {
            }
            if (numbersTyping == 45)
            {
            }
            if (numbersTyping == 46)
            {
            }
            if (numbersTyping == 47)
            {
            }
            if (numbersTyping == 48)
            {
            }
            if (numbersTyping == 49)
            {
            }
            if (numbersTyping == 50)
            {
            }
            if (numbersTyping == 51)
            {
            }
            if (numbersTyping == 52)
            {
            }
            if (numbersTyping == 53)
            {
            }
            if (numbersTyping == 54)
            {
            }
            if (numbersTyping == 55)
            {
            }
            if (numbersTyping == 56)
            {
            }
            if (numbersTyping == 57)
            {
            }
            if (numbersTyping == 58)
            {
            }
            if (numbersTyping == 59)
            {
            }
            if (numbersTyping == 60)
            {
            }

            Random numbers = new Random();
            int numbersDrawn1 = numbers.Next(1, 60);
            int numbersDrawn2 = numbers.Next(1, 60);
            int numbersDrawn3 = numbers.Next(1, 60);
            int numbersDrawn4 = numbers.Next(1, 60);
            int numbersDrawn5 = numbers.Next(1, 60);
            int numbersDrawn6 = numbers.Next(1, 60);


            Console.WriteLine("");
        }

    }

}
