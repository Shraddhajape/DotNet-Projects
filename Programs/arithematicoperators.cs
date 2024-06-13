using System;
namespace Operators{
    class operators{
        static void Main(string[] args){
            Console.WriteLine("Enter First Number :: ");
            String aa = Console.ReadLine();
            Console.WriteLine("Enter Second Number :: ");
            String bb = Console.ReadLine();
            int a = Convert.ToInt32(aa);
            int b = Convert.ToInt32(bb);
            Console.WriteLine("Addition of "+a+ " and "+b+" is : " + (a+b));
            Console.WriteLine("Substraction of "+a+ " and "+b+" is : " + (a-b));
            Console.WriteLine("Multiplication of "+a+ " and "+b+" is : " + (a*b));
            Console.WriteLine("Division of "+a+ " and "+b+" is : " + (a/b));
            Console.WriteLine("Modulo Division of "+a+ " and "+b+" is : " + (a%b));

        }
    }
}