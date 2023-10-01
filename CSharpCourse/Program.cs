using System;

namespace Lesson3
{
    class Program
    {
        static void Main()
        {
            //task2

        }
        static void Main3()
        {  //task3
            double a= int.Parse(Console.ReadLine());
            double b= int.Parse(Console.ReadLine());
            double result = a / b;
            Console.WriteLine(result);


        }
        static void Main2()
        {
            //task1
            int a =int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            bool result=a == b?true:false;
            Console.WriteLine(result);
        }
    }

}
