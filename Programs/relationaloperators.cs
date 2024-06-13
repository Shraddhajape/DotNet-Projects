using System;
namespace hello{
    class Application {
        public static void Main(string[] args){
            
            // // CHECK FOR THE POSITIVE AND NEGATIVE NUMBERS

            // int num;
            // Console.WriteLine("ENTER NUMBER TO CHECK FOR POSITIVE, NEGATIVE OR NOT. :: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // if(num > 0){
            //     Console.WriteLine("POSITIVE NUMBER.");
            // }
            // else if(num < 0){
            //     Console.WriteLine("NEGATIVE NUMBER.");
            // }
            // else{
            
            //     Console.WriteLine("NUMBER IS ZERO.");
            // }

            //MARRIAGE CERTIFICATE ISSUE OR NOT
            int age ;
            string gender;
            Console.WriteLine("ENTER AGE :: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER GENDER :: ");
            gender = Console.ReadLine();
            Console.WriteLine("******************************************************");
            if(age >= 0){
                if((gender == "male") && (age >= 21)){
                Console.WriteLine("Marriage certificate can be issued..");
                }
                else if((gender == "male") && (age < 21)){
                    Console.WriteLine("Marriage certificate can not be issued..");
                }
                else if((gender == "female") && (age >=18)){
                    Console.WriteLine("Marriage certificate can be issued..");
                }
                else if((gender == "female") && (age < 18)){
                    Console.WriteLine("Marriage certificate can not be issued..");
                }
            }
            else{
                Console.WriteLine("Entered age is Invalid Age.");
            }

        }
    }
}