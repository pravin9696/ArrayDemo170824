using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo170824
{
    class class1
    {
       public int a;
       public float b;
       public double c;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            float[]f=new float[5];

            string[]ss=new string[5];
            //step1 create array
            class1[] c1 = new class1[5];//array of ref variables

            //// c1[0] = new class1();
            // if (c1[0]==null)
            // {
            //     Console.WriteLine("c1[0] containing null");
            // }
            // else
            // {
            //     Console.WriteLine("c1[0] not containing null...");
            // }

            // class1 q = new class1();
            // q.a = 100;

            //step2 create object for each element of array
            for (int i = 0; i < c1.Length; i++)
            {
                c1[i] = new class1();
            }

            c1[0].a = 100;
            Console.WriteLine("c1[0].a=" + c1[0].a);


            Console.ReadKey();

        }
    }
}
