using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            Console.WriteLine(
                "1 - Среднее арифметическое; 2 - Сумма и произведение; 3 - Конвертер" +
                "\n4 - Гипотенуза; 5 - Четность\n6 - Калькулятор два варианта;" +
                "\n7 - Количество четных и нечетных чисел;"
                );

            Console.WriteLine("Нажмите на кнопку");

            switch (Console.ReadKey().Key) {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    Console.WriteLine("Среднее арифметическое");
                    prog.Homework1();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.WriteLine("Сумма и произведение");
                    prog.Homework2();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.WriteLine("Конвертер");
                    prog.Homework3();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine();
                    Console.WriteLine("Гипотенуза");
                    prog.Hypotenuse();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine();
                    Console.WriteLine("Четность");
                    prog.Homework4();
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine();
                    Console.WriteLine("Калькулятор два варианта");
                    prog.Homework5VersionFirst();
                    prog.Homework5VersionSecond();
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine();
                    Console.WriteLine("Количество четных и нечетных чисел");
                    prog.Homework6();
                    break;
                default:
                    break;
            }
        }
        public void Homework1()
        {

            string str;
            double num1, num2;

            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            num1 = Convert.ToDouble(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            num2 = Convert.ToDouble(str);

            double result = (num1 + num2) / 2;

            Console.WriteLine($"Результат = {result}");
        }

        public void Homework2()
        {
            string str;
            double num1, num2, num3;

            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            num1 = double.Parse(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            num2 = double.Parse(str);

            Console.WriteLine("Введите число 3");
            str = Console.ReadLine();
            num3 = double.Parse(str);

            double result1 = num1 + num2 + num3;
            double result2 = num1 * num2 * num3;

            Console.WriteLine($"Результаты \nСумма = {result1} \nПроизведение = {result2}");
        }

        public void Homework3()
        {
            double course = 84.08;

            string str;
            double num1;

            Console.WriteLine("Введите количество долларов");
            str = Console.ReadLine();
            num1 = Convert.ToDouble(str);

            double result = num1 * course;

            Console.WriteLine($"Результат {result} рубля/ей");
        }
        public void Hypotenuse()
        {
            string str;
            double firstValue, secondValue;

            Console.WriteLine("Введите значение первого катета");
            str = Console.ReadLine();
            firstValue = Convert.ToDouble(str);

            Console.WriteLine("Введите значение второго катета");
            str = Console.ReadLine();
            secondValue = double.Parse(str);

            double result = Math.Pow(Math.Pow(firstValue, 2) + Math.Pow(secondValue, 2), 0.5);
            Console.WriteLine($"Гипотенуза треугольника равна = {result}");
        }
        public void Homework4()
        {
            Console.WriteLine("Введите число!");
            try
            {
                double value = double.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    Console.WriteLine("Число четное");
                }
                else
                {
                    Console.WriteLine("Число нечетное");
                }
            }
            catch
            {
                Console.WriteLine("Неверный формат!");
            }
        }
        public void Homework5VersionFirst()
        {
            string str;
            char symbol;
            double firstValue, secondValue;
            double result;

            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            firstValue = double.Parse(str);

            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            secondValue = double.Parse(str);

            Console.WriteLine("Введите знак");
            str = Console.ReadLine();
            symbol = char.Parse(str);

            switch (symbol)
            {
                case '+':
                    result = firstValue + secondValue;
                    break;
                case '-':
                    result = firstValue - secondValue;
                    break;
                case '*':
                    result = firstValue * secondValue;
                    break;
                case '/':
                    if (secondValue == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = firstValue / secondValue;
                    }
                    break;
                default:
                    result = 0;
                    Console.WriteLine("Вы ввели неподходящий знак");
                    break;
            }

            Console.WriteLine($"Ваш результат = {result}");
        }
        public void Homework5VersionSecond()
        {
            string str;
            char symbol;
            double firstValue, secondValue;
            double result;
            
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            firstValue = double.Parse(str);

            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();
            secondValue = double.Parse(str);

            Console.WriteLine("Введите знак");
            str = Console.ReadLine();
            symbol = char.Parse(str);

            if (symbol == '+')
            {
                result = firstValue + secondValue;
            }
            else if (symbol == '-')
            {
                result = firstValue - secondValue;
            }
            else if (symbol == '*')
            {
                result = firstValue * secondValue;
            }
            else if (symbol == '/')
            {
                if (secondValue == 0)
                {
                    result = 0;
                }
                else
                {
                    result = firstValue / secondValue;
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неподходящий знак");
                result = 0;
            }

            Console.WriteLine($"Ваш результат = {result}");
        }
        public void Homework6()
        {
            string str; // принять значение
            int rangeFromNumbers, rangeToNumbers; // диапазон от и до
            uint countEven = 0; // количество четных
            uint countOdd = 0; // количество нечетных
            int sumEven = 0; // сумма четных
            int sumOdd = 0; // сумма нечетных

            Console.WriteLine("Введите значение от которого идет счет");
            str = Console.ReadLine();
            rangeFromNumbers = int.Parse(str);

            Console.WriteLine("Введите значение до которого идет счет");
            str = Console.ReadLine();
            rangeToNumbers = int.Parse(str);

            int copyRangeFromNumbers = rangeFromNumbers; // копия диапазона

            while (rangeFromNumbers <= rangeToNumbers)
            {
                if (rangeFromNumbers % 2 == 0)
                {
                    countEven++;
                    sumEven += rangeFromNumbers;
                }
                else
                {
                    countOdd++;
                    sumOdd += rangeFromNumbers;
                }
                rangeFromNumbers++;
            }

            Console.WriteLine($"Количество чисел в диапазоне от {copyRangeFromNumbers} до {rangeToNumbers} \nчетных: {countEven} \nнечетных: {countOdd}");
            Console.WriteLine($"Сумма чисел в диапазоне от {copyRangeFromNumbers} до {rangeToNumbers} \nчетных: {sumEven} \nнечетных: {sumOdd}");
        }
    }
}
