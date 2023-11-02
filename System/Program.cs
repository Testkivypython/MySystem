using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;


            while (true)
            {
                Console.WriteLine($"Напишите help для помощи");
                str = Console.ReadLine();

                command(str);

            }

        }

        static void calcalotor()
        {
            while (true)
            {
                double a, b, result;
                string str;
                char Char;
                int num;

                Console.WriteLine("Введите операцию (Для выхода введите exit, для очистки введите clear)");
                str = Console.ReadLine();

                command(str);
                char.TryParse(str, out Char);



                Console.WriteLine("Введите первое число (Для выхода введите exit, для очистки введите clear)");
                str = Console.ReadLine();

                command(str);
                double.TryParse(str, out a);


                Console.WriteLine("Введите второе число (Для выхода введите exit, для очистки введите clear)");
                str = Console.ReadLine();

                command(str);
                double.TryParse(str, out b);


                switch (Char)
                {
                    case '/':
                        if (b == 0)
                        {
                            result = 0;
                            Console.WriteLine("результат: " + result);
                        }
                        else
                        {
                            result = a / b;
                            Console.WriteLine("результат: " + result);
                        }

                        break;
                    case '*':
                        result = a * b;
                        Console.WriteLine("результат: " + result);
                        break;
                    case '%':
                        result = a % b;
                        Console.WriteLine("результат: " + result);
                        break;
                    case '+':
                        result = a + b;
                        Console.WriteLine("результат: " + result);
                        break;
                    case '-':
                        result = a - b;
                        Console.WriteLine("результат: " + result);
                        break;
                    default:
                        Console.WriteLine("Неизвестный символ");
                        break;
                }
            }
        }

        static void parety()
        {
            while (true)
            {
                string str;
                int number;

                Console.WriteLine("Напишите любое число");

                str = Console.ReadLine();

                command(str);

                int.TryParse(str, out number);

                int result = number % 2;

                if (result == 0)
                {
                    Console.WriteLine("Это число является чётным");
                }
                else
                {
                    Console.WriteLine("Это число является не чётным");
                }

            }

        }

        static void convert()
        {
            while (true)
            {

                double dollar, quantity, result;



                Console.WriteLine("Введите сумму в долларах");
                string str = Console.ReadLine();
                command(str);

                double.TryParse(str, out quantity);

                Console.WriteLine("Введите курс доллара к рублю");
                str = Console.ReadLine();

                command(str);

                double.TryParse(str, out dollar); //93.22

                result = quantity * dollar;

                Console.WriteLine("Суммма в рублях: " + result);

            }

        }

        static void command(string str)
        {
            switch (str)
            {

                case "help":
                    help();
                    break;

                case "calc":
                    calcalotor();
                    break;

                case "clear":
                    Console.Clear();
                    break;

                case "parety":
                    parety();
                    break;

                case "convert":
                    convert();
                    break;

                case "close":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Неизвестная команда");
                    break;

            }
        }

        static void help()
        {
            Console.WriteLine("calc - калькулятор");
            Console.WriteLine("clear - очистка консоли");
            Console.WriteLine("help - помощь");
            Console.WriteLine("parety - проверка числа на чётность");
            Console.WriteLine("convert - конвертор долларов в рубли");
            Console.WriteLine("close - закрыть консоль");
        }
    }
}
