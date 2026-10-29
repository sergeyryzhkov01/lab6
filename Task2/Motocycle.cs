using System;

namespace Task2
{
    public class Motorcycle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int EngineCapacity { get; set; }
        public int HorsePower { get; set; }
        public decimal Price { get; set; }

        public static void Validate(Motorcycle motorcycle)
        {
            if (motorcycle == null)
                throw new ArgumentNullException(
                    nameof(motorcycle), "Мотоцикл не задан.");

            if (string.IsNullOrWhiteSpace(motorcycle.Brand))
                throw new ArgumentException(
                    "Марка мотоцикла не может быть пустой.",
                    nameof(Brand));

            if (string.IsNullOrWhiteSpace(motorcycle.Model))
                throw new ArgumentException(
                    "Модель мотоцикла не может быть пустой.",
                    nameof(Model));

            if (motorcycle.Year < 1885 ||
                motorcycle.Year > DateTime.Now.Year + 1)
                throw new ArgumentException(
                    "Некорректный год выпуска.",
                    nameof(Year));

            if (motorcycle.EngineCapacity <= 0)
                throw new ArgumentException(
                    "Объём двигателя должен быть положительным.",
                    nameof(EngineCapacity));

            if (motorcycle.HorsePower <= 0)
                throw new ArgumentException(
                    "Мощность должна быть положительной.",
                    nameof(HorsePower));

            if (motorcycle.Price < 0)
                throw new ArgumentException(
                    "Цена не может быть отрицательной.",
                    nameof(Price));
        }

        public override string ToString()
        {
            return Brand + " " + Model +
                   " (" + Year + " г., " +
                   EngineCapacity + " см³, " +
                   HorsePower + " л.с., " +
                   Price + " руб.)";
        }
    }
}
