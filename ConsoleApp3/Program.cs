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
            //for (int i = 0; i <= 123; i++) {

            //}
            //Ex.2
            //for (int i = 0; i<100; i++) { 
            //    if (i % 2 != 0) {
            //        Console.WriteLine(i);
            //    }
            //}

            //Ex.3


            //Ex.4
            //int num1 = 8;
            //int num2;
            //double dobutok = 1;
            //double suma = 0;

            //Console.WriteLine("Enter 8 nums: ");
            //for (int i = 0; i < num1; i++)
            //{
            //    num2 = int.Parse(Console.ReadLine());

            //    dobutok *= num1;
            //    suma += num1;
            //}
            //Console.WriteLine($"Dobutok: {dobutok}");
            //Console.WriteLine($"Suma: {suma}");
            //Console.WriteLine($"Average: {suma / num1}");

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
            double sum = 0;
            double num;

            for (; ; ) { 
                num = int.Parse(Console.ReadLine());
                if (num == 0) {
                    break;
                }
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
