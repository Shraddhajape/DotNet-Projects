using System;
using System.Collections.Generic;

class Hotel
{
    public static void Main(string[] args)
    {
        Console.WriteLine("================================================");
        Console.WriteLine("************** SHRADDHA's HOTEL ****************");
        Console.WriteLine("================================================");
        Console.WriteLine();
        Console.WriteLine("+++++++++++ MENU CARD ++++++++++++");
        int[] id = {1, 2, 3, 4, 5 , 6};
        string[] dishes = {"Veg Kopta", "Paneer Tikka", "Veg Handi", "Veg Pulav", "Biryani" , "Roti"};
        float[] price = {250, 300, 350, 400, 500 , 15};

        List<int> orderIds = new List<int>();
        List<int> orderQtys = new List<int>();

        Console.WriteLine("Sr.No\t Item Name\t Rate");
        for (int i = 0; i < dishes.Length; i++)  
        {
            Console.WriteLine((i + 1) + "] \t " + dishes[i] + " \t " + price[i]);
        }

        Console.WriteLine("================================================");

        Console.WriteLine();
        Console.WriteLine("---------- PLACE YOUR ORDER ----------");
        int ch = 1;
        int orderid = 0, quantity;
        while (ch == 1)
        {
            Console.Write("Enter Dish Number :: ");
            orderid = Convert.ToInt32(Console.ReadLine());
            orderIds.Add(orderid);
            Console.Write("Enter Quantity :: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            orderQtys.Add(quantity);
            Console.Write("If you want to continue ordering, press 1 ::");
            ch = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("----- THANK YOU !! YOUR ORDER -----");
        if (orderIds.Count > 0)  
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("************** SHRADDHA's HOTEL ****************");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Address :: Shirdi, Maharashtra - 423109, INDIA ");
            Console.WriteLine("===================================================");
            Console.WriteLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("GST : XYZXYZ \tDATE :" + start);
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++ BILLING RECEIPT +++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("===================================================");
            Console.WriteLine("Sr.No\t Item Name\t Rate\t Quantity");
            float total = 0;
            for (int i = 0; i < orderIds.Count && i < orderQtys.Count; i++)  
            {
                int dishIndex = orderIds[i] - 1; 
                if (dishIndex >= 0 && dishIndex < dishes.Length)
                {
                    float itemTotal = price[dishIndex] * orderQtys[i];
                    total += itemTotal;
                    Console.WriteLine((i + 1) + " \t " + dishes[dishIndex] + " \t " + price[dishIndex] + " \t " + orderQtys[i]);
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("TOTAL BILLING AMOUNT :: " + total);
            Console.WriteLine("===================================================");
        }
    }
}
