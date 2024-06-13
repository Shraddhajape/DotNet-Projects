using System;
class program
{
    public static void Main(string[] args)
    {
        // First Pattern
        // * * * * * 
        //  * * * *
        //   * * *
        //    * *
        //     *
        for(int i=5;i>=1;i--){     // i=5 for i = 4 
          for(int j=1;j<=5-i;j++){  //j = 1 ! <=0 not space  for j = 1 <= 1(5-4) that is 1 space then j = 2 ! <= 1
            Console.Write(" ");
          }
          for(int j=1;j<=i;j++){ //j = 1 <= 5 print 1 star then j = 2 <=5 print 2nd star 
            Console.Write("*" + " "); 
          }
          Console.WriteLine();
        }

        Console.WriteLine("------------------------------------------");

        // Second pattern
         
        //     * 
        //    * *
        //   * * *
        //  * * * *
        // * * * * *
        //  * * * *
        //   * * *
        //    * *
        //     *
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 3; j >= i - 1; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= 5 - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*" + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("------------------------------------------");

        // Third pattern
        for(int i = 1 ; i<=4 ; i++){
            for(int j = i;j<=4;j++){
                Console.Write(" ");
            }
            for(int j = 1; j <= i; j++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("------------------------------------------");


        //Fourth pattern
        // *
        // * *
        // * * *
        // * * * *
        // * * * * *
        // * * * *
        // * * *
        // * *
        // *
        for(int i=1;i<=5;i++){
            for(int j=1;j<=i;j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for(int i =4 ; i>=1 ; i--){
            for(int j=1;j<=i;j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}