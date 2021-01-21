using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*{
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
            } */
            {
                Console.WriteLine("ДЗ 1 задание 4");
                Console.Write("Count = "); int.TryParse(Console.ReadLine(), out int count);
                if (count >= 0 && count <= 14) Console.WriteLine("Вы попали в отрезок: [0 - 14]");
                else if (count >= 15 && count <= 35) Console.WriteLine("Вы попали в отрезок [15 - 35]");
                else if (count >= 36 && count <= 50) Console.WriteLine("Вы попали в отрезок [36 - 50]");
                else if (count >= 51 && count <= 100) Console.WriteLine("Вы попали в отрезок [51 - 100]");
                else Console.WriteLine("Вы не попали не на один отрезок!");
            }
        }
    }
}
