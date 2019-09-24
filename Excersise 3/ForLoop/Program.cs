using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Problem7(n);
        }


        static void Problem7(int n)
        {
            HorizontalLine(n, '*');
            HorizontalLine(n, 'A');
            VerticalLine(n);
            DiagonalLine(n);
            
            
        }


        static void HorizontalLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
        }

        static void VerticalLine (int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine("\n");
        }

        static void DiagonalLine (int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write('*');
                    else
                        Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }

        // first line n-1 spaces, 1 star
        // second line n-2 spaces, 1 star, 1 space, 1 star
        // third line n-3 spaces, 1 star, 3 spaces, 1 star
        // fourth line n-4 spaces, 1 star, 5 spaces, 1 star
        // last line 2n-1 stars

    }
}
