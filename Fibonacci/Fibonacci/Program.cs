using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //費式數列的前兩項為 1、1，之後的每一項為前兩項之和
            //  使用者輸入個數=陣列的大小

            Console.WriteLine("請輸入個數：");
            int input = Convert.ToInt16(Console.ReadLine());
            int[] ar = new int[input + 1];//因給定ar[0] = 0
            ar[0] = 0;
            ar[1] = 1;
            //ar[2] = 1;
            //ar[3] = 2;
            //ar[4] = 3;
            //ar[5] = 5;
            //ar[6] = 8;

            //ar[2] = ar[0] + ar[1];
            //ar[3] = ar[1] + ar[2];
            //ar[input] = ar[input - 1] + ar[input - 2];

            for (int i = 2; i < input + 1; i++)
            {
                ar[i] = ar[i - 1] + ar[i - 2];
                //ar[2]=ar[1]+ar[0];
                //ar[2]=1    +0; ==> ar[2 ]==> 1

                //ar[3]=ar[2]+ar[1];
                //ar[3]=    1+  1; ==> ar[2] ==> 2

                //ar[4]=ar[3]+ar[2];
                //ar[4]=    2+  1; ==> ar[4] ==> 3
                Console.WriteLine($"ar[{i}] = ar[{i - 1}] + ar[{i - 2}] ==> {ar[i]}");
            }

            string result = "";
            for (int i = 1; i <= input; i++)
            {
                result += ar[i].ToString() + "、";
            }
            Console.WriteLine(result.TrimEnd('、'));
        }
    }
}
