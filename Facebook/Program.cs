using System;
using System.Collections.Generic;
namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<--You Just Added The Picture-->>> ");
            var list = new List<string>();
           
            while (true)
            {
                Console.WriteLine("Enter the Names");
                var input = Console.ReadLine();
                list.Add(input);
                if (input == "")
                {
                    list.RemoveAt(list.Count - 1);
                    if (list.Count> 2) 
                    {
                         var othercount = list.Count - 2;
                         Console.WriteLine("{0} and {1} and other {2} Liked Your Post", list[0], list[1],othercount);
                    }
                    else if (list.Count == 1)
                    {
                        Console.WriteLine("{0} Liked Your Post", list[0]);

                    }
                    else if (list.Count == 2)
                    {
                        Console.WriteLine("{0} and {1} Liked Your Post", list[0], list[1]);

                    }
                    break;
                }


            }



        }
    }
}
