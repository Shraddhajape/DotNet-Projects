using System;
namespace hello{
    class min_max{
        static void Main(string[] args){
           
            int x = Convert.ToInt32(args[0]);
            int y = Convert.ToInt32(args[1]);
            int min = Math.Min(x, y);
            int max = Math.Max(x, y);
            Console.WriteLine("Max is :: "+max);
            Console.WriteLine("Min is :: "+min); 
        }
    }
}