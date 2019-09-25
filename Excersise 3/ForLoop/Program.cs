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
            Console.WriteLine("\n");
            Problem7(n);
        }


        static void Problem7(int n)
        {
            HorizontalLine(n, 'T');
            Console.WriteLine("\n");
            VerticalLine(n);
            Console.WriteLine("\n");
            DiagonalLine(n);
            Console.WriteLine("\n");
            IsoscelesTriangle(n, 'B');
            Console.WriteLine("\n");
            N(n, 'N');
            Console.WriteLine("\n");
            BackwardIsoscelesTriangle(n, 'O');
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
        static void IsoscelesTriangle(int n, char c)
        {
            //first line
            HorizontalLine(n - 1, ' '); HorizontalLine(1, c); Console.WriteLine();
            int a = 2, b = 1;
            for (int i = 0; i < n - 2; i++ )
            {
                HorizontalLine(n - a, ' '); HorizontalLine(1, c); a++;
                HorizontalLine(b, ' '); HorizontalLine(1, c); Console.WriteLine(); b = b + 2;
            }
            //last line
            HorizontalLine(2 * n - 1, c); Console.WriteLine();
        }

        static void N (int n, char c)
        {
            //first line
            HorizontalLine(1, '*'); HorizontalLine(n - 2, ' '); HorizontalLine(1, '*'); Console.WriteLine();
            //second line
            HorizontalLine(2, '*'); HorizontalLine(n - 3, ' ');  HorizontalLine(1, '*'); Console.WriteLine();
            int a = 4, b = 1;
            for (int i = 0; i < n - 3; i++ )
            {
                HorizontalLine(1, '*'); HorizontalLine(b, ' '); HorizontalLine(1, '*'); HorizontalLine(n - a, ' '); HorizontalLine(1, '*'); a++; b++;
                Console.WriteLine();
            }
            //last line
            HorizontalLine(1, '*'); HorizontalLine(n - 2, ' '); HorizontalLine(1, '*'); Console.WriteLine();
        }

        static void BackwardIsoscelesTriangle(int n, char c)
        {
            //first line
            HorizontalLine(2 * n - 1, c); Console.WriteLine();
            int a = 1, b = 1;
            for (int i = 0; i < n - 2; i++)
            {
                HorizontalLine(a, ' '); HorizontalLine(1, c); a++;
                HorizontalLine(2*n - 4 - b, ' '); HorizontalLine(1, c); HorizontalLine(a, ' '); Console.WriteLine(); b = b + 2;
            }
            //last line
            HorizontalLine(n - 1, ' '); HorizontalLine(1, c); Console.WriteLine();
        }
    }
}
