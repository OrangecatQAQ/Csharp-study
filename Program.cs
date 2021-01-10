using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("-----------" + "第1步" + "-----------");
            Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");
            GoAsnyc();
            Console.WriteLine("-----------" + "第4步" + "-----------");
            Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");

            Console.WriteLine("-----------" + "main结束！" + "-----------");
            Console.ReadLine();
        }
        static async Task GoAsnyc() 
        {
            Console.WriteLine("-----------" + "第2步" + "-----------");
            Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");
            await RunAsnyc();
            Console.WriteLine("-----------" + "第5步" + "-----------");
            Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");
        }

        static Task RunAsnyc() 

        {
            Console.WriteLine("-----------" + "第3步" + "-----------");
            Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");
            return Task.Run(
                () => {
                    Console.WriteLine("-----------" + "第一步" + "-----------");
                    Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");
                    for (int i =0;i<10;i++) 
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("-----------"+ i +"-----------");
                    }
                    Console.WriteLine("-----------" + "第二步" + "-----------");
                    Console.WriteLine("-----Thread------" + Thread.CurrentThread.ManagedThreadId + "-----------");
                }
                );
        }
    }
}
