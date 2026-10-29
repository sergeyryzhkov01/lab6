using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class MotorcycleCollection
    {
        private readonly List<Motorcycle> motorcycles =
            new List<Motorcycle>();

        public void Add(Motorcycle motorcycle)
        {
            Motorcycle.Validate(motorcycle);
            motorcycles.Add(motorcycle);
        }

        public void AddRange(IEnumerable<Motorcycle> items)
        {
            if (items == null)
                throw new ArgumentNullException(
                    nameof(items), "Коллекция не задана.");

            List<Motorcycle> newItems = items.ToList();

            if (newItems.Count == 0)
                throw new ArgumentException(
                    "Необходимо добавить хотя бы один мотоцикл.");

            foreach (Motorcycle motorcycle in newItems)
                Motorcycle.Validate(motorcycle);

            motorcycles.AddRange(newItems);
        }

        public void Insert(int index, Motorcycle motorcycle)
        {
            Motorcycle.Validate(motorcycle);

            if (index < 0 || index > motorcycles.Count)
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Индекс должен находиться в диапазоне от 0 до " +
                    motorcycles.Count + ".");

            motorcycles.Insert(index, motorcycle);
        }

        public bool Remove(Motorcycle motorcycle)
        {
            if (motorcycle == null)
                throw new ArgumentNullException(
                    nameof(motorcycle), "Мотоцикл не задан.");

            return motorcycles.Remove(motorcycle);
        }

        public void RemoveAt(int index)
        {
            if (motorcycles.Count == 0)
                throw new InvalidOperationException(
                    "Коллекция пуста.");

            if (index < 0 || index >= motorcycles.Count)
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Индекс должен находиться в диапазоне от 0 до " +
                    (motorcycles.Count - 1) + ".");

            motorcycles.RemoveAt(index);
        }

        public Motorcycle GetByIndex(int index)
        {
            if (motorcycles.Count == 0)
                throw new InvalidOperationException(
                    "Коллекция пуста.");

            if (index < 0 || index >= motorcycles.Count)
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Индекс должен находиться в диапазоне от 0 до " +
                    (motorcycles.Count - 1) + ".");

            return motorcycles[index];
        }

        public List<Motorcycle> FindByBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException(
                    "Введите марку мотоцикла.");

            return motorcycles
                .Where(m => string.Equals(
                    m.Brand,
                    brand.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void SortByYear()
        {
            motorcycles.Sort(
                (a, b) => a.Year.CompareTo(b.Year));
        }

        public void SortByPrice()
        {
            motorcycles.Sort(
                (a, b) => a.Price.CompareTo(b.Price));
        }

        public void Clear()
        {
            motorcycles.Clear();
        }

        public List<Motorcycle> GetAll()
        {
            return new List<Motorcycle>(motorcycles);
        }

        public int Count
        {
            get { return motorcycles.Count; }
        }
    }
}
