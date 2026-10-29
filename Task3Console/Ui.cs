using System;
using System.Collections.Generic;
using Task2;
using Task3;

namespace Task3Console
{
    public static class Ui
    {
        public static void Task3Ui()
        {
            MotorcycleQueue queue = new MotorcycleQueue();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("ЗАДАНИЕ 3");
                Console.WriteLine("Работа с Queue<Motorcycle>");
                Console.WriteLine();

                Console.WriteLine("1 - Добавить мотоцикл в очередь");
                Console.WriteLine("2 - Извлечь первый мотоцикл");
                Console.WriteLine("3 - Посмотреть первый мотоцикл");
                Console.WriteLine("4 - Проверить наличие мотоцикла");
                Console.WriteLine("5 - Найти мотоциклы по марке");
                Console.WriteLine("6 - Показать очередь");
                Console.WriteLine("7 - Очистить очередь");
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
                            queue.Enqueue(ReadMotorcycle());
                            Console.WriteLine("Мотоцикл добавлен в очередь.");
                            break;

                        case "2":
                            Motorcycle removed = queue.Dequeue();

                            Console.WriteLine("Извлечён мотоцикл:");
                            Console.WriteLine(removed);
                            break;

                        case "3":
                            Motorcycle first = queue.Peek();

                            Console.WriteLine("Первый мотоцикл:");
                            Console.WriteLine(first);
                            break;

                        case "4":
                            if (queue.Count == 0)
                            {
                                Console.WriteLine("Очередь пуста.");
                                break;
                            }

                            Console.WriteLine(
                                "Введите характеристики мотоцикла:");

                            Motorcycle search = ReadMotorcycle();

                            if (queue.Contains(search))
                                Console.WriteLine(
                                    "Мотоцикл найден в очереди.");
                            else
                                Console.WriteLine(
                                    "Мотоцикл не найден.");
                            break;

                        case "5":
                            Console.Write("Введите марку: ");
                            string brand = Console.ReadLine();

                            List<Motorcycle> found =
                                queue.FindByBrand(brand);

                            if (found.Count == 0)
                            {
                                Console.WriteLine("Мотоциклы не найдены.");
                            }
                            else
                            {
                                Console.WriteLine("Результаты поиска:");

                                foreach (Motorcycle motorcycle in found)
                                    Console.WriteLine(motorcycle);
                            }
                            break;

                        case "6":
                            ShowQueue(queue);
                            break;

                        case "7":
                            if (queue.Count == 0)
                                Console.WriteLine("Очередь уже пуста.");
                            else
                            {
                                queue.Clear();
                                Console.WriteLine("Очередь очищена.");
                            }
                            break;

                        default:
                            Console.WriteLine("Неверный пункт меню.");
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

        private static Motorcycle ReadMotorcycle()
        {
            Motorcycle motorcycle = new Motorcycle();

            Console.Write("Марка: ");
            motorcycle.Brand = Console.ReadLine();

            Console.Write("Модель: ");
            motorcycle.Model = Console.ReadLine();

            Console.Write("Год выпуска: ");
            motorcycle.Year = ReadInt();

            Console.Write("Объём двигателя (см³): ");
            motorcycle.EngineCapacity = ReadInt();

            Console.Write("Мощность (л.с.): ");
            motorcycle.HorsePower = ReadInt();

            Console.Write("Цена (руб.): ");
            motorcycle.Price = ReadDecimal();

            Motorcycle.Validate(motorcycle);

            return motorcycle;
        }

        private static int ReadInt()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException(
                    "Поле не может быть пустым.");

            int value;

            if (!int.TryParse(input, out value))
                throw new ArgumentException(
                    "Введите корректное целое число.");

            return value;
        }

        private static decimal ReadDecimal()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException(
                    "Цена не может быть пустой.");

            decimal value;

            if (!decimal.TryParse(input, out value))
                throw new ArgumentException(
                    "Введите корректную цену.");

            return value;
        }

        private static void ShowQueue(MotorcycleQueue queue)
        {
            Motorcycle[] motorcycles = queue.ToArray();

            if (motorcycles.Length == 0)
            {
                Console.WriteLine("Очередь пуста.");
                return;
            }

            Console.WriteLine("Содержимое очереди:");
            Console.WriteLine();

            for (int i = 0; i < motorcycles.Length; i++)
            {
                Console.WriteLine(
                    "[" + i + "] " + motorcycles[i]);
            }

            Console.WriteLine();
            Console.WriteLine(
                "Количество элементов: " + queue.Count);
        }
    }
}
