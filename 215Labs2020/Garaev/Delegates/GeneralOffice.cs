﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Delegates
{
    class GeneralOffice
    {
        public static void Max_el_mass(int message)
        {
            Console.WriteLine
                ($"Максимальный элемент внутри массива: {message}");
        }
        public static void Summ_el_mass(int message)
        {
            Console.WriteLine
                ($"Сумма элементов массива: {message}");
        }
        public static void Sortirovka(string message)
        {
            Console.WriteLine
                ($"Отсортировнный первый массив: {message}");
        }
        public static void Summ_massiv(string message)
        {
            Console.WriteLine
                ($"Сумма двух массивов: {message}");
        }
        public static void Raznost_massiv(string message)
        {
            Console.WriteLine
                ($"Вычитание двух массивов: {message}");
        }
        public static void MU_massiv(string message)
        {
            Console.WriteLine
                ($"Умножение двух массивов: {message}");
        }
    }
}
