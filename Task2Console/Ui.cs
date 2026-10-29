using System;
using System.Collections.Generic;
using Task2;

namespace Task2Console
{
    public static class Ui
    {
        public static void Task2Ui()
        {
            MotorcycleCollection collection = new MotorcycleCollection();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("ЗАДАНИЕ 2");
                Console.WriteLine("Работа с List<Motorcycle>");
                Console.WriteLine();

                Console.WriteLine("1 - Добавить мотоцикл");
                Console.WriteLine("2 - Добавить несколько мотоциклов");
                Console.WriteLine("3 - Вставить мотоцикл по индексу");
                Console.WriteLine("4 - Удалить мотоцикл по индексу");
                Console.WriteLine("5 - Удалить мотоцикл по объекту");
                Console.WriteLine("6 - Найти мотоцикл по марке");
                Console.WriteLine("7 - Сортировать по году");
                Console.WriteLine("8 - Сортировать по цене");
                Console.WriteLine("9 - Показать коллекцию");
                Console.WriteLine("10 - Очистить коллекцию");
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
                            collection.Add(ReadMotorcycle());
                            Console.WriteLine("Мотоцикл добавлен.");
                            break;

                        case "2":
                            Console.Write("Количество мотоциклов: ");
                            int count = ReadInt();

                            if (count <= 0)
                                throw new ArgumentException(
                                    "Количество должно быть положительным.");

                            List<Motorcycle> items =
                                new List<Motorcycle>();

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine(
                                    "Мотоцикл №" + (i + 1));

                                items.Add(ReadMotorcycle());
                            }

                            collection.AddRange(items);

                            Console.WriteLine("Мотоциклы добавлены.");
                            break;

                        case "3":
                            Console.Write("Введите индекс: ");
                            int insertIndex = ReadInt();

                            Motorcycle motorcycle = ReadMotorcycle();

                            collection.Insert(insertIndex, motorcycle);

                            Console.WriteLine("Мотоцикл вставлен.");
                            break;

                        case "4":
                            if (collection.Count == 0)
                            {
                                Console.WriteLine("Коллекция пуста.");
                                break;
                            }

                            Console.Write("Введите индекс: ");
                            collection.RemoveAt(ReadInt());

                            Console.WriteLine("Мотоцикл удалён.");
                            break;

                        case "5":
                            if (collection.Count == 0)
                            {
                                Console.WriteLine("Коллекция пуста.");
                                break;
                            }

                            ShowCollection(collection);

                            Console.WriteLine();
                            Console.Write("Индекс объекта: ");

                            int index = ReadInt();

                            Motorcycle selected =
                                collection.GetByIndex(index);

                            if (collection.Remove(selected))
                                Console.WriteLine("Мотоцикл удалён.");
                            else
                                Console.WriteLine("Мотоцикл не найден.");
                            break;

                        case "6":
                            Console.Write("Введите марку: ");
                            string brand = Console.ReadLine();

                            List<Motorcycle> found =
                                collection.FindByBrand(brand);

                            if (found.Count == 0)
                            {
                                Console.WriteLine("Мотоциклы не найдены.");
                            }
                            else
                            {
                                Console.WriteLine("Результаты поиска:");

                                foreach (Motorcycle item in found)
                                    Console.WriteLine(item);
                            }
                            break;

                        case "7":
                            if (collection.Count == 0)
                                Console.WriteLine("Коллекция пуста.");
                            else
                            {
                                collection.SortByYear();
                                Console.WriteLine(
                                    "Коллекция отсортирована по году.");
                            }
                            break;

                        case "8":
                            if (collection.Count == 0)
                                Console.WriteLine("Коллекция пуста.");
                            else
                            {
                                collection.SortByPrice();
                                Console.WriteLine(
                                    "Коллекция отсортирована по цене.");
                            }
                            break;

                        case "9":
                            ShowCollection(collection);
                            break;

                        case "10":
                            if (collection.Count == 0)
                                Console.WriteLine("Коллекция уже пуста.");
                            else
                            {
                                collection.Clear();
                                Console.WriteLine("Коллекция очищена.");
                            }
                            break;

                        case "0":
                            return;

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

        private static void ShowCollection(
            MotorcycleCollection collection)
        {
            List<Motorcycle> items = collection.GetAll();

            if (items.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            Console.WriteLine("Содержимое коллекции:");
            Console.WriteLine();

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine("[" + i + "] " + items[i]);

            Console.WriteLine();
            Console.WriteLine(
                "Количество элементов: " + collection.Count);
        }
    }
}
