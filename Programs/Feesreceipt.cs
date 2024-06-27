using System;

class Hello
{
    string name = "";
    string branch = "";
    string prn = "";
    int year = 0;
    int total = 0;
    int entrance_fees = 0;
    int exam_fees = 0;
    int library_fees = 0;
    int hostel_fees = 0;
    int laboratory_fees = 0;
    int project_fees = 0;
    public void Display()
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("*** SANJIVANI COLLEGE OF ENGINEERING, KOPARGOAN ***");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("              ~ Academic Fees Receipt ~            ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("NAME :: " + name);
        Console.WriteLine("PRN :: " + prn);
        Console.WriteLine("Branch :: " + branch);
        Console.WriteLine("Year / Semester :: " + year);
        Console.WriteLine("Entrance fees ::" + entrance_fees);
        Console.WriteLine("Exam fees ::" + exam_fees);
        Console.WriteLine("Library fees ::" + library_fees);
        Console.WriteLine("Hostel fees ::" + hostel_fees);
        Console.WriteLine("Laboratory fees ::" + laboratory_fees);
        Console.WriteLine("Project fees ::" + project_fees);
        Console.WriteLine("---------------------------------------------------");

        Console.WriteLine("Total :: Rs." + total);
        Console.WriteLine("---------------------------------------------------");

    }

    // Method to add data
    public void AddData()
    {
        Console.WriteLine("******* ADD DATA TO GENERATE FEE RECEIPT *******");
        Console.WriteLine("---------------------------------------------------");
        Console.Write("NAME :: ");
        name = Console.ReadLine();
        Console.Write("Branch :: ");
        branch = Console.ReadLine();
        Console.Write("PRN :: ");
        prn = Console.ReadLine();
        Console.Write("Year / Semester :: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entrance Fess :: ");
        entrance_fees = Convert.ToInt32(Console.ReadLine());
        Console.Write("Exam Fess :: ");
        exam_fees = Convert.ToInt32(Console.ReadLine());
        Console.Write("Library Fees :: ");
        library_fees = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hostel Fees :: ");
        hostel_fees = Convert.ToInt32(Console.ReadLine());
        Console.Write("Laboratory Fees :: ");
        laboratory_fees = Convert.ToInt32(Console.ReadLine());
        Console.Write("Project Fees :: ");
        project_fees = Convert.ToInt32(Console.ReadLine());
        total = entrance_fees + exam_fees + library_fees + hostel_fees + project_fees + laboratory_fees;


    }

    public static void Main(string[] args)
    {
        Hello program = new Hello();
        char ch;

        do
        {
            Console.WriteLine("WELCOME TO SANJIVANI COEK's ACCOUNT SYSTEM..!!");
            Console.WriteLine("1. View Receipt.");
            Console.WriteLine("2. Add Receipt Data.");
            Console.WriteLine("3. Exit.");
            Console.WriteLine("Enter your choice (1-3) :");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (!string.IsNullOrEmpty(program.name))
                    {
                        Console.WriteLine("THIS IS YOUR FEE RECEIPT.");
                        program.Display();
                    }
                    else
                    {
                        Console.WriteLine("First add data to generate receipt");
                    }
                    break;
                case 2:
                    program.AddData();
                    break;
                case 3:
                    Console.WriteLine("Thank You!!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice Entered.");
                    break;
            }

            if (choice == 3) break;

            Console.WriteLine("Do you want to continue? If Yes, press 'Y' or 'y', else 'N' or 'n' :: ");
            ch = Convert.ToChar(Console.ReadLine());

        } while (ch == 'Y' || ch == 'y');
    }
}
