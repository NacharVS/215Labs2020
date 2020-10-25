using System;

namespace _215Labs2020.Garaev4
{
    class Operators
    {
        private double _number;
        public Operators(double number)
        {
            _number = number;
        }
        public static double operator + (Operators number1, Operators number2) 
        {
            return (number1._number + number2._number);
        }
        public static double operator -(Operators number1, Operators number2)
        {
            return (number1._number - number2._number);
        }
        public static double operator *(Operators number1, Operators number2)
        {
            return (number1._number * number2._number);
        }
        public static double operator /(Operators number1, Operators number2)
        {
            return Math.Round(number1._number / number2._number,2);
        }
        public static void a()
        {
            bool v = true;
            while (v == true)
            {
                Console.Write("Введите первое число: ");
                int b1 = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b2 = int.Parse(Console.ReadLine());
                Operators operator1 = new Operators(b1);
                Operators operator2 = new Operators(b2);
                Console.WriteLine("Выберите действие: +, -, *, /");
                double average = 0;
                string vibor = Console.ReadLine();
                if (vibor != "+" && vibor != "-" && vibor != "*" && vibor != "/")
                    v = false;
                else
                {
                    switch (vibor)
                    {
                        case "+": average = (operator1 + operator2); break;
                        case "-": average = (operator1 - operator2); break;
                        case "*": average = (operator1 * operator2); break;
                        case "/": average = (operator1 / operator2); break;
                    }
                    Console.WriteLine($"{b1} {vibor} {b2} = {average}");
                }
            }
        }
    }
}
