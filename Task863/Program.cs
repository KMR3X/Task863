using System;
using System.Collections.Generic;

namespace Task862
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вас приветствует программа заполнения хэш-набора.\n");

            HashSet<int> set = new HashSet<int>();

            AddNumber(set);
            Print(set);

            Console.ReadLine();
        }


        /// <summary>
        /// Метод для заполнения набора введенными с клавиатуры числами.
        /// </summary>
        /// <param name="set"></param>
        static void AddNumber(HashSet<int> set)
        {
            do
            {
                Console.Write("Введите число: ");

                string input = Console.ReadLine();
                if (input == string.Empty)
                {
                    break;
                }
                int number = Convert.ToInt32(input);

                if (set.Contains(number) == true)
                {
                    Console.WriteLine("Коллизия: число уже существует в наборе!\n");
                }
                else
                {
                    set.Add(number);
                    Console.WriteLine("Число успешно добавлено.\n");
                }

            } while (true);
        }

        /// <summary>
        /// Метод для вывода набора в консоль.
        /// </summary>
        /// <param name="set"></param>
        static void Print(HashSet<int> set)
        {
            Console.WriteLine("\nВаш набор: ");

            foreach (int e in set)
            {
                Console.WriteLine(e);
            }
        }
    }
}
