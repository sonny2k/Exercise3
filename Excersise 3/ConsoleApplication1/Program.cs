using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input day: ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            CountDays(days, month, year);
            
        }

        static void CountDays(int days, int month, int year)
        {
            int sumday = 0;
            int day = 0;
            switch(month){
                case 1:
                    day++;
                    sumday = days + day;
                    Console.WriteLine("days from 1/1: " + sumday);
                    break;
                case 2:
                    day = day + 31;
                    sumday = days + day;
                    Console.WriteLine("days from 1/1: " + sumday);
                    break;
                case 3:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 4:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 5:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 6:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 7:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 8:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 9:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 10:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 11:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30 + 31;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                case 12:
                    if ((year % 400) == 0)
                    {
                        day = day + 29 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    else
                    {
                        day = day + 28 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30;
                        sumday = days + day;
                        Console.WriteLine("days from 1/1: " + sumday);
                    }
                    break;
                default:
                    Console.WriteLine("you typed the month wrong!");
                    break;
            }   
        }
    }
}
