﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_lab_task_10_while
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите натуральное положительное число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int k = 0, c = n;
                while (c > 0)
                {
                    k = k * 10 + c % 10; // финальный результат
                    c = c / 10;
                }
                if (n == k)
                {
                    Console.WriteLine("Число является палиндромом.");
                }
                else
                {
                    Console.WriteLine("Число не является палиндромом.");
                }
            }
            catch
            {
                Console.WriteLine("Только безработные и бездельники постоянно чем-то заняты.");
            }
            Console.ReadKey();
        }
    }
}
