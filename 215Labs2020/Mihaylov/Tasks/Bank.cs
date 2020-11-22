﻿using System;
namespace _215Labs2020.Mihaylov
{
    class Bank
    {
        private static double balans = 0;
        private static double persent = 0.06;
        private static DateTime accountOpen;
        private static int age;
        private static int year;
        private static int day;
        private static int month;
        private static void registration()
        {
            Console.WriteLine("Введите день своего рождения: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год своего рождения:");
            year = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - year;
            if (age >= 14)
            {
                Console.WriteLine("Можете продолжить регистрацию");
            }
            else
            {
                Console.WriteLine("Вы не можете продолжить регистрацию, так как вам меньше 14 лет");
                System.Environment.Exit(0);
            }

            Console.WriteLine("Введите своё ФИО : ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите свой номер телефона: ");
            string numberphone = Console.ReadLine();
            Console.WriteLine("Вы успешно зарегистрировались, можете пользоваться услугами банка.");
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        private static void addition()
        {
            Console.Write("Введите сумму пополнения от 10000 до 200000: ");
            int a= 0;
            if (a <= 10000 | a >= 200000)
            {
                while (a <= 10000 | a >= 200000)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Ошибка! Диапазон пополнений  от 10000 до 200000. ");
                        Console.WriteLine("Введите сумму пополнения: ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            balans += a;
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        private static void cut()
        {
            Console.WriteLine("Введите сумму которую хотите снять: ");
            int a = int.Parse(Console.ReadLine());
            while (balans - a < 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    if (a <= 10000 | a >= 200000)
                    {
                        Console.WriteLine($" У вас недостаточно средств для вывода денег, ваш баланс составляет: {balans}");
                        Console.Write("Введите сумму которую хотите снять:  ");
                        a = int.Parse(Console.ReadLine());
                    }
                }}
            balans -= a;
            Console.WriteLine("Снятие прошло успешно");
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
        }
        private static void time()
        {
            int x= (DateTime.Now.Hour -accountOpen.Hour);
            int y= (DateTime.Now.Minute-accountOpen.Minute);
            int z = (DateTime.Now.Second -accountOpen.Second);
            Console.WriteLine($"С момента вашей регистрации прошло {x} часов {y} минут {z} секунд ");
        }
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Регистрация: ( 1 )");
                Console.WriteLine("Пополнить счет: ( 2 )");
                Console.WriteLine("Снять с счета: ( 3 )");
                Console.WriteLine("Проверить время акккаунта: (4)");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: registration(); break;
                    case 2: addition(); break;
                    case 3: cut(); break;
                    case 4: time(); break;
                }
            }
        }
    }
}