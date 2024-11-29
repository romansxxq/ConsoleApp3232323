using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex.1
            //int i = 14;
            //while (i <= 123)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Ex.2
            //int i = 0;
            //while (i < 100)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //Ex.3
            Console.Write("Enter numbers (N>0): ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0) {
                Console.WriteLine("N should be < 0");
                return;
            }

            int countNega = 0;
            int i = 0;

            while (i < N)
            {
                Console.Write("Enter num: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0) { 
                    countNega++;
                }
                i++;
            }
            Console.WriteLine($"Numbers negative: {countNega}");
            //Ex.4


            //Ex.5

            //for (int i = 100; i >= 1; i--) {
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            //Ex.6
            //int n = 5;
            //int num;
            //double dobutok = 1;

            //for (int i = 0; i < n; i++)
            //{
            //    num = int.Parse(Console.ReadLine());

            //    dobutok *= num;
            //}
            //Console.WriteLine(dobutok);

            //Ex.7
            //for (int i = 50; i > 1; i--)
            //{
            //    if (i % 4 == 0) { 
            //    Console.WriteLine(i);}
            //}
            //Ex.8
            //Console.WriteLine("Enter a num: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //Ex.9
            //Console.Write("Enter start: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter end: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("Parni Chysla: ");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("Neparni Chysla: ");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("Kratni 7: ");
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 7 == 0)
            //        Console.WriteLine(i);
            //}

            //Ex.10

            //Console.Write("Enter start: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter end: ");
            //int end = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = start; i <= end; i++) { 
            //    sum  += i;
            //}
            //Console.WriteLine(sum);

            //Ex.11
            //double sum = 0;
            //double num;

            //for (; ; ) { 
            //    num = int.Parse(Console.ReadLine());
            //    if (num == 0) {
            //        break;
            //    }
            //    sum += num;
            //}
            //Console.WriteLine(sum);
        }
    }
}
