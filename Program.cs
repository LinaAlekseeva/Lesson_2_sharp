using System;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("\r\nEnter the number of elements of the array:  ");
                var elements = int.Parse(Console.ReadLine());
                var massiv = new int[elements];
                for (var i = 0; i < massiv.Length; i++)
                {
                    Console.WriteLine("\n Enter {0} element of the array:  ", i + 1);
                    massiv[i] = int.Parse((Console.ReadLine()));
                }
                Console.WriteLine("\n Specify a way to order the array by entering the character (+) in ascending order, (-) in descending order:  ");
                var a = char.Parse(Console.ReadLine());
                var bAsc = (a == '+');
                //bool bIsSwap = true;

                Console.WriteLine("Data after sorting in ascending order: ");
                //while (bIsSwap == true)
                for (var bIsSwap = true; bIsSwap == true;)
                {
                    bIsSwap = false;
                    for (var i = 0; i < massiv.Length - 1; i++)
                    {
                        if (
                         //( bAsc && massiv[i] > massiv[i + 1]) ||
                         //(!bAsc && massiv[i] < massiv[i + 1])
                         bAsc ? (massiv[i] > massiv[i + 1]) : (massiv[i] < massiv[i + 1])
                        )
                        {
                            var tmp = massiv[i + 1];
                            massiv[i + 1] = massiv[i];
                            massiv[i] = tmp;


                            bIsSwap = true;
                        }

                    }
                }

                foreach (var p in massiv)
                {
                    Console.Write("{0} ", p);
                }

            }

        }

    }

}



















