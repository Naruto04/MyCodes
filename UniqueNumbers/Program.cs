using System;
using System.Collections.Generic;

namespace UniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            int i = 0;
            while (i <= 5)
            {

                Console.WriteLine("<<<--Enter The Five Unique Numbers-->>>");
                var input = Console.ReadLine();
                var input1 = Convert.ToInt32(input);

                if (list.Contains(input1))
                {
                    Console.WriteLine("Error Already exist");
                }
                else
                {
                    list.Add(input1);
                    i += 1;
                    if (i == 5)
                    {
                        Console.WriteLine("Unique Numbers:-");
                        foreach (var content in list)
                        {
                            Console.WriteLine(content);
                        }
                        break;
                    }
                }



            }
        }
    }
}
