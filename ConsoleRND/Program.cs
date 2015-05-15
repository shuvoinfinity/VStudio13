using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

            Test1 test = new Test1();
            test.Speak(1, "Mafu");
            Console.ReadKey();
        }
     }
}
