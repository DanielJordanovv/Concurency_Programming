using System;
using System.Threading;

namespace Taks_5._1
{
    class Program
    {
        static Random random = new Random();
        static void Player1()
        {
            int currPoints = 0;
            int endPoints = 100;
            while (currPoints<=endPoints)
            {
                currPoints += random.Next(1, 10);
                Console.WriteLine($"Player 1 points: {currPoints}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Player 1 finished!");
        }
        static void Player2()
        {
            int currPoints = 0;
            int endPoints = 100;
            while (currPoints <= endPoints)
            {
                currPoints += random.Next(1, 10);
                Console.WriteLine($"Player 2 points: {currPoints}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Player 2 finished!");
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Player1);
            Thread thread2 = new Thread(Player2);
            thread1.Start(); thread2.Start();
        }
    }
}
