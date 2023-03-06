using System;
using System.Threading;

namespace Task_5
{
    class Program
    {
        static Random random = new Random();
        static void CountBackWards()
        {
            int waitTime = random.Next(1, 10) * 1000;
            Console.WriteLine($"Wait time: {waitTime}");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(waitTime);
            }


        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(CountBackWards);
            Thread thread2 = new Thread(CountBackWards);
            thread1.Start(); thread2.Start();
        }
    }
}
