using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class OperatorsOverload
    {
        public double _number;


        public OperatorsOverload(double number)
        {
            _number = number;
        }
        public static double operator +(OperatorsOverload number1, OperatorsOverload number2)
        {
            return (number1._number + number2._number);
        }
        public static double operator -(OperatorsOverload number1, OperatorsOverload number2)
        {
            return (number1._number - number2._number);
        }
        public static double operator /(OperatorsOverload number1, OperatorsOverload number2)
        {
            return (number1._number / number2._number);
        }
        public static double operator *(OperatorsOverload number1, OperatorsOverload number2)
        {
            return number1._number * number2._number;
        }
        public static bool operator ==(OperatorsOverload number1, OperatorsOverload number2)
        {
            return number1._number == number2._number;
        }
        public static bool operator !=(OperatorsOverload number1, OperatorsOverload number2)
        {
            return number1._number == number2._number;
        }

        public static void Program()
        {

         
        
         Console.Write("Введите желаемое число(1): ");
         double nb1 = double.Parse(Console.ReadLine());
         Console.Write("Введите желаемое число(2): ");
         double nb2 = double.Parse(Console.ReadLine());
         OperatorsOverload operator1 = new OperatorsOverload(nb1);
         OperatorsOverload operator2 = new OperatorsOverload(nb2);

         
         Console.WriteLine("Выберите нужное вам действие: ");
         Console.WriteLine("Сложение - (+). ");
         Console.WriteLine("Вычитание - (-). ");
         Console.WriteLine("Деление - (/). ");
         Console.WriteLine("Умножение - (*). ");
         Console.WriteLine("Сравнение - (=). ");
         Console.WriteLine("Введите действие:  ");
            double average = 0;
            string action = Console.ReadLine();
         switch (action)

         {
                case "+": average = operator1 + operator2; break;
                case "-": average = operator1 - operator2; break;
                case "*": average = operator1 * operator2; break;
                case "/": average = operator1 / operator2; break;
                case "=": bool res = operator1 == operator2; break;
         }

            Console.WriteLine($"Ответ: {average}  ");
                


            
        }
    }
}  