using System;
using System.Collections.Generic;
using System.Linq;
using Task2;

namespace Task3
{
    public class MotorcycleQueue
    {
        private readonly Queue<Motorcycle> queue =
            new Queue<Motorcycle>();

        public void Enqueue(Motorcycle motorcycle)
        {
            Motorcycle.Validate(motorcycle);
            queue.Enqueue(motorcycle);
        }

        public Motorcycle Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException(
                    "Очередь пуста. Извлечение невозможно.");

            return queue.Dequeue();
        }

        public Motorcycle Peek()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException(
                    "Очередь пуста. Просмотр невозможен.");

            return queue.Peek();
        }

        public bool Contains(Motorcycle motorcycle)
        {
            if (motorcycle == null)
                throw new ArgumentNullException(
                    nameof(motorcycle), "Мотоцикл не задан.");

            return queue.Any(m =>
                string.Equals(
                    m.Brand,
                    motorcycle.Brand,
                    StringComparison.OrdinalIgnoreCase) &&
                string.Equals(
                    m.Model,
                    motorcycle.Model,
                    StringComparison.OrdinalIgnoreCase) &&
                m.Year == motorcycle.Year &&
                m.EngineCapacity == motorcycle.EngineCapacity &&
                m.HorsePower == motorcycle.HorsePower &&
                m.Price == motorcycle.Price);
        }

        public List<Motorcycle> FindByBrand(string brand)
        {
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException(
                    "Введите марку мотоцикла.");

            return queue
                .Where(m => string.Equals(
                    m.Brand,
                    brand.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void Clear()
        {
            queue.Clear();
        }

        public Motorcycle[] ToArray()
        {
            return queue.ToArray();
        }

        public int Count
        {
            get { return queue.Count; }
        }
    }
}
