using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGameProject
{
    internal class MultithreadingProgram
    {
        public void CallSerialMethods()
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread 1"
            };
            Thread t2 = new Thread(MethodHugeProcess)
            {
                Name = "Thread 2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread 3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main thread ended");

        }

        private void Method1()
        {
            Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);
            for (int i = 1; i < 5; i++)
            {
                    Thread.Sleep(20000);//10sec
                Console.WriteLine($"Method 1 index is:{i}");
            }
            Console.WriteLine("Method1 ended using " + Thread.CurrentThread.Name);

        }
        private void MethodHugeProcess()
        {
            Console.WriteLine("Huge process started using " + Thread.CurrentThread.Name);

            for (int i = 1; i < 5; i++)
            {
               // Console.WriteLine("Method 2\n");
                if (i==3)
                {
                    Console.WriteLine($"Database operation started");
                    Thread.Sleep(10000);//10sec
                    Console.WriteLine($"Database operation finished");
                }
            }
            Console.WriteLine("Method2 ended using " + Thread.CurrentThread.Name);

        }
        private void Method3()
        {
            Console.WriteLine("Method3 started using " + Thread.CurrentThread.Name);

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine($"Method 3 index is:{i}");
            }
            Console.WriteLine("Method3 ended using " + Thread.CurrentThread.Name);

        }
    }
}
