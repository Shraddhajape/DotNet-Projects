using System;
namespace hello{
    class logical{
        public static void Main(string[] args){
            Console.WriteLine("LOGICAL OPERATORS");
            Console.WriteLine("Enter First Operator::");
            bool op1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Second Operator::");
            bool op2 = Convert.ToBoolean(Console.ReadLine());


            // LOGICAL AND OPERATOR
            // The logical AND operator (&&) returns true if both operands are true, otherwise it returns false.
            if(op1 && op2){
                Console.WriteLine("AND OUTPUT IS TRUE.");
            } else {
                Console.WriteLine("AND OUTPUT IS FALSE.");
            }

            // LOGICAL OR OPERATOR
            // The logical OR operator (||) returns true if at least one of the operands is true, otherwise it returns false.
            if(op1 || op2){
                Console.WriteLine("OR OUTPUT IS TRUE.");
            } else {
                Console.WriteLine("OR OUTPUT IS FALSE.");
            }

            // LOGICAL NOT OPERATOR
            // The logical NOT operator (!) returns true if the operand is false, and returns false if the operand is true.
            if(!op1){
                Console.WriteLine("LOGICAL NOT FOR OPERAND 1 IS: TRUE");
            } else {
                Console.WriteLine("LOGICAL NOT FOR OPERAND 1 IS: FALSE");
            }

            // You can also demonstrate the NOT operator for the second operand if desired.
            if(!op2){
                Console.WriteLine("LOGICAL NOT FOR OPERAND 2 IS: TRUE");
            } else {
                Console.WriteLine("LOGICAL NOT FOR OPERAND 2 IS: FALSE");
            }

        }
    }
}