using System;
class hello{
    public static void Main(string[] args){
        int[,] array1 = new int[3,3];
        int[,] array2 = new int[3,3];
        Console.WriteLine("ENTER 3x3 ARRAY 1 ELEMENTS :: ");
        for(int i = 0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                array1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("ENTER 3x3 ARRAY 2 ELEMENTS :: ");
        for(int i = 0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                array2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("ADDITION MATRIX OF TWO MATRICES :: ");
        for(int i=0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                Console.Write((array1[i,j] + array2[i,j] + " \t"));
            }
            Console.WriteLine();
        }
        Console.WriteLine("SUBSTRACTION MATRIX OF TWO MATRICES :: ");
        for(int i=0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                Console.Write((array1[i,j] - array2[i,j] + " \t"));
            }
            Console.WriteLine();
        }
        Console.WriteLine("MULTIPLICATION MATRIX OF TWO MATRICES :: ");
        for(int i=0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                Console.Write((array1[i,j] * array2[i,j] + " \t"));
            }
            Console.WriteLine();
        }
        Console.WriteLine("DIVISION MATRIX OF TWO MATRICES :: ");
        for(int i=0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                Console.Write((array1[i,j] / array2[i,j] + " \t"));
            }
            Console.WriteLine();
        }
        Console.WriteLine("MODULUS MATRIX OF TWO MATRICES :: ");
        for(int i=0 ; i < 3 ; i++){
            for(int j=0 ; j < 3 ; j++){
                Console.Write((array1[i,j] % array2[i,j] + " \t"));
            }
            Console.WriteLine();
        }
    }
}