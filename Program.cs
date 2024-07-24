using System;
using System.Data;

namespace class_method_230724
{
    class Triangle
    { 
        int base1;
        int height;
        float area;
        public void acceptBase_Height()
        {
            Console.WriteLine("Enter base and height:");
            base1=int.Parse(Console.ReadLine());
            height=int.Parse(Console.ReadLine());

        }
        public void showArea()
        {
            area = 0.5f * base1 * height;
            Console.WriteLine("Area of Rectangle is :"+area);
        }

    }
    class myClass
    {
        public int x;
        public void show()
        {
            Console.WriteLine("this is show method");
            Console.WriteLine("value of ="+x);
        }
    }
   
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Array Assignment 4 
            //int[] arr = new int[6];
            //Console.WriteLine("Enter 5 elements :");
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("-----------------");
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    Console.Write(arr[i] + "\t");
            //}
            ////------element insert at specific possition

            //int index;
            //int value;
            //Console.WriteLine("Enter index and value:");
            //index = int.Parse(Console.ReadLine());
            //value = int.Parse(Console.ReadLine());
            //if (index < 0 || index > 5)
            //{
            //    Console.WriteLine("invalid index number!!!!");
            //}
            //else
            //{
            //    int i = 4;
            //    while (i != index - 1)
            //    {
            //        arr[i + 1] = arr[i];
            //        i--;
            //    }
            //    arr[index] = value;
            //    Console.WriteLine("-----------------");
            //    for (i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write(arr[i] + "\t");
            //    }
            //}
            #endregion


            //class 

            //myClass mcObj1 = new myClass();
            //mcObj1.x = 123;
            //mcObj1.show();


            //step1 :create object of class triangle

            //Triangle t1=new Triangle();
            ////step2: set values to member variables base1 and height using 
            ////        method acceptBase_Height()

            //t1.acceptBase_Height();

            ////step 3: calculate area of rectangle by calling method showArea()
            //t1.showArea();
            Console.ReadKey();
        }
    }
}

