using System;
using System.Collections.Generic;

class ToDoListApp
{
    static List<string> tasks = new List<string>(); // list to store tasks

    public static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            // Console.Clear();
            Console.WriteLine("******** TO DO LIST APP **********");
            Console.WriteLine("==================================");
            Console.WriteLine(" 1] Add Task to List.");
            Console.WriteLine(" 2] View Tasks in List.");
            Console.WriteLine(" 3] Delete Task from List.");
            Console.WriteLine(" 4] Exit.");
            Console.WriteLine("==================================");
            Console.Write("ENTER YOUR CHOICE :: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    Console.WriteLine("Exiting the application...");
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        // Console.Clear();
        Console.WriteLine("***** ADD TASK TO YOUR LIST ******");
        Console.Write("Write description of the task: ");
        string description = Console.ReadLine();
        tasks.Add(description);
        // Console.Clear();
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks()
    {
        // Console.Clear();
        Console.WriteLine("***** VIEW TASKS IN YOUR LIST *****");
        if (tasks.Count > 0)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine("================================");
                Console.WriteLine((i + 1) + "] " + tasks[i]);
                Console.WriteLine("================================");
            }
        }
        else
        {
            Console.WriteLine("No tasks in the list.");
        }
    }

    static void DeleteTask()
    {
        // Console.Clear();
        Console.WriteLine("***** DELETE TASK FROM YOUR LIST *****");
        if (tasks.Count > 0)
        {
            ViewTasks();
            Console.Write("Enter the number of the task to delete: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
        else
        {
            Console.WriteLine("No tasks to delete.");
        }
    }
}
