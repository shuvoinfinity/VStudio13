﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleRND
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] { };
            //int n, loc, temp;
            ////A[0] = -32768;
            //Console.WriteLine("Enter the number of Elements :");
            //n = Convert.ToInt16(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    A[i] = Convert.ToInt16(Console.ReadLine());
            //}
            //for (int k = 2; k < n; k++)
            //{
            //    temp = A[k];
            //    loc = k - 1;
            //    while (temp < A[loc])
            //    {
            //        A[loc + 1] = temp;
            //        loc--;
            //    }
            //}
            //Console.WriteLine("\n \n Sorted Elements are \n");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //Test2 myTest2 = new Test2();
            //myTest2.Speak("Shuvo");

            //Test1 test = new Test1();
            //test.Speak(1, "Mafu");
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var num = numbers.SkipWhile(n => n%3!=0);
            //foreach (var i in num)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arr = new int[5] { 23, 2, 3, 34, 6 }; //unsorted data set
            //selectsort(arr); //sorting process using selection sort
            //int i;
            //for (i = 0; i < arr.Length; i++)
            //    Console.Write(arr[i] + "\t"); //after sorting

            //FileStream fs1 = new FileStream("D:\\Yourfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(fs1);
            //writer.Write("Hello Welcome");
            //writer.Close();
            //FileStream fs2 = new FileStream("D:\\Yourfile.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //StreamReader reader = new StreamReader(fs2);
            //Console.WriteLine(reader.ReadToEnd());
            //reader.Close();
            test3.CreatFile();
            Console.ReadKey();
        }
    }
}
