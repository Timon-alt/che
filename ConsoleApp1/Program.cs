using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            zadanie1();
            zadanie2();
            zadanie3();
            zadanie4();
            zadanie5();
            zadanie6();
            zadanie7();
            zadanie8();
        }

        static void zadanie1()
        {
            Console.WriteLine("---Zadanie 18.1---");
            List<int> nums = new List<int>();
            int sum = 0;
            int sumList = 0;
            Console.WriteLine("Введите числовой диапознон");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            for (int i = 1; i <= a; i++)
            {
                int num = i;
                nums.Clear();
                sumList = 0;
                while (num > 0)
                {
                    nums.Add(num % 10);
                    num /= 10;
                }

                foreach (var number in nums)
                {
                    sumList += number;
                }

                if (sumList > sum)
                {
                    sum = sumList;
                    c = i;
                }

            }

            Console.WriteLine("В числе " + c + " наибольшая сумма цифр = " + sum);
        }

        static void zadanie2()
        {
            Console.WriteLine("---Zadanie 18.2---");
            List<int> nums = new List<int>();
            Console.WriteLine("Введите число больше 0");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (a == 0 || a < 0)
            {
                Console.WriteLine("Неверный ввод");
            }

            else
            {
                for (int i = 1; i <= a; i++)
                {
                    List<int> numbers = new List<int>();
                    int num = i;
                    sum = 0;

                    while (num > 0)
                    {
                        numbers.Add(num % 10);
                        num /= 10;
                    }

                    foreach (var number in numbers)
                    {
                        sum += number;
                    }

                    if (i % sum == 0)
                    {
                        nums.Add(i);
                    }
                }
                Console.WriteLine("Замечательные числа");
                foreach (var number in nums)
                {
                    Console.Write(number + " ");
                }
            }
        }

        static void zadanie3()
        {
            Console.WriteLine("---Zadanie 18.3---");
            for (double i = 1; i <= 100; i++)
            {
                if (i % Math.Cbrt(i) == 0)
                {
                    Console.WriteLine("Число " + i + " это " + Math.Cbrt(i) + " в корне");
                }
            }
        }

        static void zadanie4()
        {
            Console.WriteLine("---Zadanie 18.4---");
            List<int> nums = new List<int>();
            int sum = 0;
            int proiz = 1;
            for (int i = 100; i <= 999; i++)
            {
                List<int> numbers = new List<int>();
                int num = i;
                sum = 0;
                proiz = 1;

                while (num > 0)
                {
                    numbers.Add(num % 10);
                    num /= 10;
                }

                foreach (var number in numbers)
                {
                    sum += number;
                    proiz *= number;
                }

                if (sum == proiz)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine("Список трёхзначных чисел, где сумма = произведение:");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }

        static void zadanie5()
        {
            Console.WriteLine("---Zadanie 18.5---");
            List<int> nums = new List<int>();
            Console.WriteLine("Введите диапозон");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= a; i++)
            {
                List<int> numbers = new List<int>();
                int num = i;
                sum = 0;

                while (num > 0)
                {
                    numbers.Add(num % 10);
                    num /= 10;
                }

                foreach (var number in numbers)
                {
                    sum += number;
                }

                if (sum % c == 0 && sum % d != 0)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine("Числа, кратные n и одновременно не кратные d:");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }

        static void zadanie6()
        {
            Console.WriteLine("---Zadanie 18.6---");
            List<int> nums = new List<int>();
            int sum = 0;
            
            for (int i = 100; i <= 999; i++)
            {
                List<int> numbers = new List<int>();
                int num = i;
                sum = 0;
                

                while (num > 0)
                {
                    numbers.Add(num % 10);
                    num /= 10;
                }

                foreach (var number in numbers)
                {
                    sum += number;
                }

                if (sum == 8)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine("Трехзначные числа, где сумма = 8:");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }

        static void zadanie7()
        {
            Console.WriteLine("---Zadanie 18.7---");
            List<int> nums = new List<int>();
            
            int proiz = 1;
            for (int i = 10; i <= 99; i++)
            {
                List<int> numbers = new List<int>();
                int num = i;
                proiz = 1;

                while (num > 0)
                {
                    numbers.Add(num % 10);
                    num /= 10;
                }

                foreach (var number in numbers)
                {
                    proiz *= number;
                }

                if (i == proiz * 2)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine("Числа:");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }

        static void zadanie8()
        {
            Console.WriteLine("---Zadanie 18.8---");
            List<int> nums = new List<int>();
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = 0;
                List<int> numbers = new List<int>();
                for (int b = 1; b < i; b++)
                {
                    if (i % b == 0)
                    {
                        numbers.Add(b);
                    }
                }
                foreach (var number in numbers)
                {
                    sum += number;
                }

                if (i == sum)
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine("Совершенные числа от 0 до 100:");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }

       // Тут тяжелооо
        
        static void zadanie9()
        {

        }

        static void zadanie10()
        {

        }
    }
}
