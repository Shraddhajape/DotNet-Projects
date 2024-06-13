using System;
class hello{
    public static void Main(string[] args){
        Console.WriteLine("ENTER LENGTH AND BREADTH OF RECTANGLE :: ");
        int l , b ;
        l = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        double area = l * b;
        Console.WriteLine("AREA OF RECTANGLE :: "+area);
    }
}
