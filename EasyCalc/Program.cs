﻿using System;

namespace EasyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'д';
            while (again == 'д')
            {
                double a;
                double b;
                double total;
                char oper;
                try
                {
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                Console.WriteLine("Введите оператор:");
                oper = Convert.ToChar(Console.ReadLine());

                try
                {
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '-')
                {
                    total = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
                }

                else if (oper == '*')
                {
                    total = a * b;
                    Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
                }

                else if (oper == '/')
                {
                    total = a / b;


                    if (b == 0) {
                        Console.WriteLine("Ошибка!" +" На ноль делить нельзя!");
                    }
                    else
                    Console.WriteLine("Деление  " + a + " на " + b + " равно " + total + ".");

                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
