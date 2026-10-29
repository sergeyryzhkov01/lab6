using System;
using System.Collections.Generic;
using Task1;

namespace Task1Console
{
    public static class Ui
    {
        public static void Task1Ui()
        {
            NumberCollection collection = new NumberCollection();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("ЗАДАНИЕ 1");
                Console.WriteLine("Работа с коллекцией List<int>");
                Console.WriteLine();

                Console.WriteLine("1 - Добавить элемент");
                Console.WriteLine("2 - Добавить несколько элементов");
                Console.WriteLine("3 - Вставить элемент по индексу");
                Console.WriteLine("4 - Удалить элемент по значению");
                Console.WriteLine("5 - Удалить элемент по индексу");
                Console.WriteLine("6 - Найти индекс элемента");
                Console.WriteLine("7 - Отсортировать коллекцию");
                Console.WriteLine("8 - Показать коллекцию");
                Console.WriteLine("9 - Очистить коллекцию");
                Console.WriteLine("0 - Назад");

                Console.WriteLine();
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                if (choice == null || choice == "0")
                    return;

                Console.Clear();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Введите число: ");
                            collection.Add(ReadInt());
                            Console.WriteLine("Элемент добавлен.");
                            break;

                        case "2":
                            Console.Write("Введите числа через пробел: ");
                            int[] values = ReadIntArray();

                            collection.AddRange(values);
                            Console.WriteLine("Элементы добавлены.");
                            break;

                        case "3":
                            Console.Write("Введите индекс: ");
                            int insertIndex = ReadInt();

                            Console.Write("Введите число: ");
                            int insertNumber = ReadInt();

                            collection.Insert(insertIndex, insertNumber);
                            Console.WriteLine("Элемент вставлен.");
                            break;

                        case "4":
                            if (collection.Count == 0)
                            {
                                Console.WriteLine("Коллекция пуста.");
                                break;
                            }

                            Console.Write("Введите число: ");
                            int removeNumber = ReadInt();

                            if (collection.Remove(removeNumber))
                                Console.WriteLine("Элемент удалён.");
                            else
                                Console.WriteLine("Элемент не найден.");
                            break;

                        case "5":
                            if (collection.Count == 0)
                            {
                                Console.WriteLine("Коллекция пуста.");
                                break;
                            }

                            Console.Write("Введите индекс: ");
                            collection.RemoveAt(ReadInt());

                            Console.WriteLine("Элемент удалён.");
                            break;

                        case "6":
                            if (collection.Count == 0)
                            {
                                Console.WriteLine("Коллекция пуста.");
                                break;
                            }

                            Console.Write("Введите число: ");
                            int number = ReadInt();

                            int index = collection.IndexOf(number);

                            if (index >= 0)
                                Console.WriteLine("Индекс элемента: " + index);
                            else
                                Console.WriteLine("Элемент не найден.");
                            break;

                        case "7":
                            if (collection.Count == 0)
                                Console.WriteLine("Коллекция пуста.");
                            else
                            {
                                collection.Sort();
                                Console.WriteLine("Коллекция отсортирована.");
                            }
                            break;

                        case "8":
                            ShowCollection(collection);
                            break;

                        case "9":
                            if (collection.Count == 0)
                                Console.WriteLine("Коллекция уже пуста.");
                            else
                            {
                                collection.Clear();
                                Console.WriteLine("Коллекция очищена.");
                            }
                            break;

                        default:
                            Console.WriteLine("Ошибка: выберите пункт от 0 до 9.");
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
            }
        }

        private static int ReadInt()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Поле не может быть пустым.");

            int number;

            if (!int.TryParse(input, out number))
                throw new ArgumentException(
                    "Введите корректное целое число от " +
                    int.MinValue + " до " + int.MaxValue + ".");

            return number;
        }

        private static int[] ReadIntArray()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException(
                    "Введите хотя бы одно число.");

            string[] parts = input.Split(
                new[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            foreach (string part in parts)
            {
                int number;

                if (!int.TryParse(part, out number))
                    throw new ArgumentException(
                        "Некорректное число: " + part);

                numbers.Add(number);
            }

            return numbers.ToArray();
        }

        private static void ShowCollection(NumberCollection collection)
        {
            List<int> numbers = collection.GetAll();

            if (numbers.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            Console.WriteLine("Содержимое коллекции:");
            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine("[" + i + "] = " + numbers[i]);

            Console.WriteLine();
            Console.WriteLine(
                "Количество элементов: " + collection.Count);
        }
    }
}
