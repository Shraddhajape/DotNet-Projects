using System;
class program{
    public static void Main(string[] args){
        int num ;
        Console.WriteLine("ENTER NUMBER TO FIND FACTORIAL :: ");
        num  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("FACTIRIAL IS :: "+ factorial(num));
    }
    static int factorial(int num){
        if(num == 0 || num == 1){
            return 1; 
        }
        return num*factorial(num-1);
    }
}