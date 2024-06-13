using System;
namespace hello{
    class interpolation{
        static void Main(string[] args){
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string fullname = $"My full name is: {name} {surname}";

            Console.WriteLine(fullname);

        
        }
    }
}