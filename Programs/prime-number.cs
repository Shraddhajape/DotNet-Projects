using System;
class prime{
    public static void Main(string[] args){
        int min = 1;
        int max = 100;
        for (int i = min; i <= max; i++) {
            int count = 0;  // Reset count for each i
            for (int j = 1; j <= i; j++) {
                if (i % j == 0) {
                    count++;
                }

            }
            if (count == 2) {  // Only primes have exactly 2 divisors: 1 and itself
                Console.Write(i +" ");
            }
        }
    }
}