using System;
class hello{
    public static void Main(string[] args){
        Console.WriteLine("======================================================");
        Console.WriteLine("*************** WELCOME TO ATM SERVICE ***************");
        Console.WriteLine("======================================================");
        Console.WriteLine("ENTER YOUR PIN :: ");
        int pin = Convert.ToInt32(Console.ReadLine());
        int choice;
        if(pin != 0){
            Console.WriteLine("======================================================");
            Console.WriteLine(" 1] CHECK BALANCE");
            Console.WriteLine(" 2] CASH DEPOSITE");
            Console.WriteLine(" 3] CASH WINTRAWAL");
            Console.WriteLine(" 4] QUIT/EXIT");
            Console.WriteLine("ENTER CHOICE TO PERFORM TRANSACTIONS :: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("**** WELCOME TO ATM SERVICE : CHECK YOUR BALANCE ****");
                    Console.WriteLine("YOUR BALANCE IS : Rs 1000 /~");
                    Console.WriteLine("Thank You ! Visit Again !! :)") ;
                    break;
                case 2:
                    Console.WriteLine("CASH DEPOSITE");
                    break;
                case 3:
                    Console.WriteLine("CASH WINTRAWAL");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("PLEASE ENTER VALID CHOICE FOR TRANSACTIONS.");
                    break;
            }

        }
        else{
            Console.WriteLine("PLEASE ENTER A VALID PIN..");
        }

    }
}