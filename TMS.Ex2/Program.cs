using System;

namespace TMS.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: Сумма чисел произвольного числа
            int orig = 1234;            
            int sum = 0;
            int temp = orig;
            for (int i = 0; i < orig.ToString().Length; i++)
            {                
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine($"Сумма цифр {orig} равна {sum}");

            //Задание 2
            Console.Write("Введите координату x выстрела: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y выстрела: ");
            int y1 = int.Parse(Console.ReadLine());
            int radius = 4;
            bool shot_result = true;
            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) > Math.Pow(radius, 2))
            {
                shot_result = false;
            }
            Console.WriteLine(shot_result);

            //Задание 3
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int first_digit = number / 100;
            int second_digit = number % 100 / 10;
            int third_digit = number % 10;
            bool digit_result = false;
            if (second_digit <= first_digit && second_digit > third_digit)
            {
                digit_result = true;
            }
            Console.WriteLine(digit_result);

            //Задание 4
            Console.Write("Введите число: ");
            int number_before_swap = int.Parse(Console.ReadLine());
            int first_digit2 = number_before_swap / 100;
            int second_digit2 = number_before_swap % 100 / 10;
            int third_digit2 = number_before_swap % 10;
            int number_after_swap = third_digit2 * 100 + second_digit2 * 10 + first_digit2;
            Console.WriteLine(number_after_swap);

            //Задание 5
            double number_double = 156.0;
            int number_int = (int)number_double;
            bool res = true;
            if (number_double > number_int)
            {
                res = false;
            }            
            Console.WriteLine(res);
        }
    }
}
