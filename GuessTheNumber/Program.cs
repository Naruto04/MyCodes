using System;
using System.Security.Cryptography;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t<<<-Guess The Number You Have Four Chances->>>");
            Random A = new Random();
            var radno = A.Next(1, 10);

            int i = 1;
            while (i <= 4)
            {
                int flag = 0;

                Console.WriteLine("<<<-Enter no->>>");
                var input = Console.ReadLine();
                var input1 = Convert.ToInt32(input);
                if (input1 == radno)
                {
                    Console.WriteLine("\t\t\t\t<<<-You Guessed The Correct->>>");
                    Console.WriteLine("\t\t\t\t*****YOU WON THE GAME*****");
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t<<<-You Guessed Wrong->>>");

                }
                var chance = (4 - i);
                Console.WriteLine("\t\t\t\t<<<-You Have {0} Chances Left->>>", chance);
                if (chance == 0 && flag == 0)
                {
                    Console.WriteLine("\t\t\t\t<<<-You Lost The Game->>>");
                }
                //Console.WriteLine(A);
                //Console.WriteLine(radno);
                i += 1;


            }
        }

    }
}