using System;

namespace Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine(
                    "Лабораторная работа №6. Вариант 4");

                System.Console.WriteLine();

                System.Console.WriteLine(
                    "1 - Работа с List<int>");

                System.Console.WriteLine(
                    "2 - Коллекция мотоциклов");

                System.Console.WriteLine(
                    "3 - Очередь мотоциклов");

                System.Console.WriteLine(
                    "0 - Выход");

                System.Console.WriteLine();

                System.Console.Write("Выберите пункт: ");

                string choice = System.Console.ReadLine();

                System.Console.Clear();

                switch (choice)
                {
                    case "1":
                        Task1Console.Ui.Task1Ui();
                        break;

                    case "2":
                        Task2Console.Ui.Task2Ui();
                        break;

                    case "3":
                        Task3Console.Ui.Task3Ui();
                        break;

                    case "0":
                        return;

                    default:
                        System.Console.WriteLine(
                            "Ошибка: выберите пункт от 0 до 3.");
                        break;
                }

                System.Console.WriteLine();
                System.Console.WriteLine(
                    "Нажмите любую клавишу для возврата в меню...");

                System.Console.ReadKey();
                System.Console.Clear();
            }
        }
    }
}
