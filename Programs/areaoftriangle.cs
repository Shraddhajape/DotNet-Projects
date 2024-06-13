using System;
class hello{
    public static void Main(string[] args){
        Console.WriteLine("ENTER HEIGHT AND LENGTH OF TRIANGLE :: ");
        int l , b ;
        l = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        double area = 0.5 * l * b;
        Console.WriteLine("AREA OF TRIANGLE :: "+area);
    }
}