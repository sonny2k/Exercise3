using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThenElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Problem2(n);
            Console.WriteLine("input a: ");
            int a =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Problem3(a, b, c);
            Console.WriteLine("Check your grade here: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Problem4(grade);
        }

        //input: n
        //output: Is Odd if n % 2 =1
        //output: Is Even if m % 2 = 0
        static void Problem2(int n)
        {
            if (IsOdd(n))
                Console.WriteLine("{0} is odd number", n);
            if (IsEven(n))
                Console.WriteLine("{0} is even number", n);
        }

        static bool IsOdd(int n)
        {
            return n % 2 == 1;
        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        //input: a,b,c
        //output: FindMaximum if  max > the others
        //output: FindMedium if med < max && med > min
        //output: FindMinimum if min < the others
      

        static int FindMaximum(int a , int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine("{0} is max between {1}, {2}, {3}", max, a, b, c);
            return max;
        }

        // set: a, b, c
        // criteria: a < med < c
        // action: med = b
        static int FindMedium(int a, int b, int c)
        {
            //return a + b + c = FindMaximum(a,b,c) - FindMinimum(a,b,c)
            int med = a;
            if (a < b && b < c)
                med = b;
            if (a > b && b > c)
                med = b;
            if (a > c && c > b)
                med = c;
            if (a < c && c < b)
                med = c;
            Console.WriteLine("{0} is medium between {1}, {2}, {3}", med, a, b, c);
            return med;
           
        }

        static int FindMinimum(int a, int b, int c)
        {
            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            Console.WriteLine("{0} is minimum between {1}, {2}, {3}", min, a, b, c);
            return min;
        }

        static void Problem3(int a, int b, int c)
        {
            FindMaximum(a, b, c);
            FindMedium(a, b, c);
            FindMinimum(a, b, c);
        }

        static void Problem4(int grade)
        {
            A(grade);
            B(grade);
            C(grade);
            D(grade);
            F(grade);
        }

        static int A(int grade)
        {
            int grade1 = 90;
            int grade2 = 100;
            if (grade > grade1 && grade <= grade2)
                Console.WriteLine("A");
                return grade;
        }

        static int B(int grade)
        {
            int grade3 = 90;
            int grade4 = 80;
            if (grade > grade4 && grade <= grade3)
                Console.WriteLine("B");
                return grade;   
        }

        static int C(int grade)
        {
            int grade5 = 80;
            int grade6 = 70;
            if (grade > grade6 && grade <= grade5)
                Console.WriteLine("C");
            return grade;
        }

        static int D(int grade)
        {
            int grade7 = 70;
            int grade8 = 60;
            if (grade > grade8 && grade <= grade7)
                Console.WriteLine("D");
            return grade;
        }

        static int F(int grade)
        {
            int grade9 = 60;
            int grade10 = 0;
            if (grade > grade10 && grade <= grade9)
                Console.WriteLine("F");
            return grade;
        }
    }
}
