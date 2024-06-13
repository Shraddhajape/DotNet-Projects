using System;
namespace swap{
    class Swap{
        static void Main(string[] args){
            Console.WriteLine("Enter Two Number to Swap:: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp ;
            temp = a;
            a=b;
            b=temp;
            Console.WriteLine("Two numbers after swapping are ::" + a + " "+b);
        }
    }
}