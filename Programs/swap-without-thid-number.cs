using System;
class program{
    public static void Main(string[] args){
        // SWAP TWO NUMBERS WITHOUT THIRD VARIABLE
        int a , b ;
        Console.WriteLine("ENTER TWO NUMBERS TO SWAP :: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("SWAPPED NUMBERS ARE :: "+ a + " & "+b);

    }
}