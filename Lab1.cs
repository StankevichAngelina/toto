﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugaday_chislo
{
    class Program
    {
        static void Main(string[] args)
        {


            char again = 'y';
            Random rand = new Random();

            while (again == 'y')
            {
                int i = rand.Next(50);

                Console.WriteLine("Компьютер загадал число от 0 до 50");

                if (i < 25) Console.WriteLine("Число меньше 25");
                else Console.WriteLine("Число больше или равно 25");

                int x = Convert.ToInt32(Console.ReadLine());

                if (i == x) Console.WriteLine("Поздравляем! Вы победили свой компьютер!");
                else Console.WriteLine("Вы проиграли! Компьютер загадал число {0}", i);

                Console.WriteLine("Попробовать еще? (y = Да, n = Нет)");
                again = Convert.ToChar(Console.ReadLine());

            }
        }
    }
}