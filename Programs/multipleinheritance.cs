using System;

class Inheritance
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***** MULTIPLE INHERITANCE PROGRAM *****");
        Computer computer = new Computer();
        computer.Display();
    }

    class CPU
    {
        public void Display()
        {
            Console.WriteLine("CPU is a Central Processing Unit.");
        }
    }

    class Memory
    {
        public void Display()
        {
            Console.WriteLine("Memory is a Storage Unit.");
        }
    }

    class Monitor
    {
        public void Display()
        {
            Console.WriteLine("Monitor is responsible for UI Display.");
        }
    }

    class Computer
    {
        private CPU cpu = new CPU();
        private Memory memory = new Memory();
        private Monitor monitor = new Monitor();

        public void Display()
        {
            Console.WriteLine("Computer is a functional machine which consists of CPU, Memory, and Monitor.");
            cpu.Display();
            memory.Display();
            monitor.Display();
        }
    }
}
