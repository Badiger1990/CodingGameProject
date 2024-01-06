using System;
using DotNetTutorials;

namespace CodingGameProject
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\nHello welcome to Dot net tutorials!!");
            Console.WriteLine("Enter your choice");
            Console.WriteLine($"1. Swapping program\n" +
                $"2. Armstrong number\n" +
                $"3. Print Fibonacci series\n" +
                $"4. Numbers using LINQ\n" +
                $"5. Find repeted chars\n" +
                $"6. Multithreading program\n" +
                $"7. Sum of digits\n" +
                $"0.Exit application");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1.Swapping program");
                    SwappingProgram sp = new SwappingProgram();
                    sp.SwapNumbers(0, 19);
                    Main();
                    break;
                case 2:
                    Console.WriteLine("2.Armstrong number");
                    NumberPrograms np = new NumberPrograms();
                    Console.WriteLine("Enter a number to check Armstrong number or not");
                    int input = Convert.ToInt32(Console.ReadLine());
                    bool result = np.IsArmstrongNumber(input);
                    Console.WriteLine("Input number is"+ input);
                    Console.WriteLine($"result is : {result}");
                    if (input != 0)
                        Main();
                    break;
                case 3:
                    Console.WriteLine($"3. Print Fibonacci series" +
                        $"\nEnter number:");
                    FibonacciSeries fs = new FibonacciSeries();
                    //fs.PrintFibonacciSeries(Convert.ToInt32(Console.ReadLine()));
                    //fs.Main();
                    Console.WriteLine("Not yet implemented..");
                    Main();
                    break;
                case 4:
                    Console.WriteLine("4. Numbers using LINQ");
                    PowerOfLINQ pl = new PowerOfLINQ();
                    pl.PlayOnNumbersLINQ();
                    Main();
                    break;
                case 5:
                    Console.WriteLine("5. Find repeted chars");
                    NumberPrograms numberPgm=new NumberPrograms();
                    numberPgm.PrintRepetedCharCount("Hi How are you Naveen");
                    Main();
                    break;
                case 6:
                    Console.WriteLine("6. Multithreading program");
                    MultithreadingProgram mtp = new MultithreadingProgram();
                    mtp.CallSerialMethods();
                    Main();
                    break;
                case 7:
                    Console.WriteLine("7. Sum of digits");
                    Console.WriteLine("Enter a number");
                    NumberPrograms.SumOfDigits(Convert.ToInt32(Console.ReadLine()));
                    Main();
                    break;
                default:
                    Console.WriteLine("Closing your window..");
                    Environment.Exit(1);
                    break;
            }

            Console.ReadKey();
        }
    }
}
