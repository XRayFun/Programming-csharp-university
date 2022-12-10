using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication8
{
    class Program
    {
        public static void Sum(Object arr)
        {
            string PR10 = Thread.CurrentThread.Name.ToString();
            int[] new_arr = (int[])arr;
            int summa = 0;
            for (int i = 0; i < new_arr.Length; i++)
            {
                summa += new_arr[i];
            }
            Console.WriteLine("Имя потока: " + PR10 + " Сумма массива: " + summa);
        }
        public static void Min(Object arr)
        {
            string PR10 = Thread.CurrentThread.Name.ToString();
            int[] new_arr = (int[])arr;
            int minimum = new_arr[0];
            for (int i = 1; i < new_arr.Length; i++)
            {
                if (minimum > new_arr[i])
                {
                    minimum = new_arr[i];
                }
            }
            Console.WriteLine("Имя потока: " + PR10 + " Минимальный элемент: " + minimum);
        }
        public static void Max(Object arr)
        {
            string PR10 = Thread.CurrentThread.Name.ToString();
            int[] new_arr = (int[])arr;
            int maximum = new_arr[0];
            for (int i = 1; i < new_arr.Length; i++)
            {
                if (maximum < new_arr[i])
                {
                    maximum = new_arr[i];
                }
            }
            Console.WriteLine("Имя потока: " + PR10 + " Максимальный элемент: " + maximum);
        }
        static void Main(string[] args)
        {
            int[] matrix1 = new int[] { 19, 10, -3, -66, 5 };
            int[] matrix2 = new int[] { 5, -4, 0, -3 };
            int[] matrix3 = new int[] { 0, 6, -7, -7, 3, 10 };
            Thread PR10_Summa = new Thread(new ParameterizedThreadStart(Sum));
            PR10_Summa.Name = "PR10_Summa";
            Thread PR10_Minimum = new Thread(new ParameterizedThreadStart(Min));
            PR10_Minimum.Name = "PR10_Minimum";
            Thread PR10_Maximum = new Thread(new ParameterizedThreadStart(Max));
            PR10_Maximum.Name = "PR10_Maximum";
            PR10_Summa.Start(matrix1);
            PR10_Maximum.Start(matrix2);
            PR10_Minimum.Start(matrix3);
            PR10_Summa.Join();
            PR10_Maximum.Join();
            PR10_Minimum.Join();
            Console.ReadKey();
        }
    }
}
