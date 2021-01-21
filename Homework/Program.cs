using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("ДЗ 1 задание 2");
                Console.Write("A = "); int.TryParse(Console.ReadLine(), out int a);
                Console.Write("B = "); int.TryParse(Console.ReadLine(), out int b);
                if (a != b) 
                {
                    if (a > b) b = a;
                    else a = b;
                }
                else a = b = 0;
                Console.WriteLine($"A = {a}, B = {b}");
            }
            {
                Console.WriteLine("ДЗ 1 задание 3");
                Console.Write("operand1 = "); double.TryParse(Console.ReadLine(), out double operand1);
                Console.Write("sign = "); char.TryParse(Console.ReadLine(), out char sign);
                Console.Write("operand2 = "); double.TryParse(Console.ReadLine(), out double operand2);
                switch (sign)
                {
                    case '+':
                        Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                        break;
                    case '-':
                        Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                        break;
                    case '*':
                        Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                        break;
                    case '/':
                        if (operand2 != 0) Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                        else Console.WriteLine("Error b = 0!");
                        break;
                    default:
                        Console.WriteLine("Error Вы ввели неправильный sign");
                        break;
                }
            } 
            {
                Console.WriteLine("ДЗ 1 задание 4");
                Console.Write("Count = "); int.TryParse(Console.ReadLine(), out int count);
                if (count >= 0 && count <= 14) Console.WriteLine("Вы попали в отрезок: [0 - 14]");
                else if (count >= 15 && count <= 35) Console.WriteLine("Вы попали в отрезок [15 - 35]");
                else if (count >= 36 && count <= 50) Console.WriteLine("Вы попали в отрезок [36 - 50]");
                else if (count >= 51 && count <= 100) Console.WriteLine("Вы попали в отрезок [51 - 100]");
                else Console.WriteLine("Вы не попали не на один отрезок!");
            }
            {
                Console.WriteLine("ДЗ 2 задание 2");
                Console.Write("Cost = "); double.TryParse(Console.ReadLine(), out double cost);
                if (cost > 500 && cost <= 1000) cost  = cost  - ((cost * 3) / 100);
                else if (cost > 1000) cost = cost - ((cost * 5) / 100);
                else if (cost < 0) Console.WriteLine("Сумма покупки не может быть отрицательным числом!");
                if (cost > 0) Console.WriteLine($"Стоимость вашей покупки с учетом скидки: {cost}");
            }
            {
                Console.WriteLine("ДЗ 2 задание 3");
                Console.Write("num1 = "); double.TryParse(Console.ReadLine(), out double num1);
                Console.Write("num2 = "); double.TryParse(Console.ReadLine(), out double num2);
                Console.Write("num3 = "); double.TryParse(Console.ReadLine(), out double num3);
                Console.Write("num4 = "); double.TryParse(Console.ReadLine(), out double num4);
                var min = num1;
                if (num1 > num2 || num2 > num3 || num3 > num4)
                {
                    if (num2 < min ) min = num2;
                    else if (num3 < min) min = num3;
                    else if (num4 < min) min = num4;
                    Console.WriteLine($"Min is {min}");
                }
                else if (num1 == num2  && num2 == num3 && num3 == num4) Console.WriteLine(num1 * num2 * num3 * num4);
                else Console.WriteLine("Числа расположены по возрастанию!");
            }
            {
                Console.WriteLine("ДЗ 2 задание 4");
                Console.Write("a = "); double.TryParse(Console.ReadLine(), out double a);
                Console.Write("b = "); double.TryParse(Console.ReadLine(), out double b);
                Console.Write("c = "); double.TryParse(Console.ReadLine(), out double c);
                if (a >= c && c >= b) 
                {
                    b = b + c; 
                    c = b - c; 
                    b = b - c;
                }
                else if (b >= a && a >= c) 
                {
                    a = a + b; 
                    b = a - b; 
                    a = a - b;
                }
                else if (c >= b && b >= a)
                {
                    c = a + c;
                    a = c - a;
                    c = c - a;
                }
                else if (c >= a && a >= b)
                {
                    c = c + a;
                    a = c - a;
                    c = c - a;
                    c = c + b;
                    b = c - b;
                    c = c - b;
                }
                else if (b >= c && c >= a)
                {
                    c = c + a;
                    a = c - a;
                    c = c - a;
                    b = b + a;
                    a = b - a;
                    b = b - a;
                }
                Console.WriteLine($"{a} >= {b} >= {c}");
            }
        }
    }
}
