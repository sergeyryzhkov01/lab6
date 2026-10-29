using System;
using System.Collections.Generic;

namespace Task1
{
    public class NumberCollection
    {
        private readonly List<int> numbers = new List<int>();

        public void Add(int number)
        {
            numbers.Add(number);
        }

        public void AddRange(int[] values)
        {
            if (values == null)
                throw new ArgumentNullException(
                    nameof(values), "Массив чисел не задан.");

            if (values.Length == 0)
                throw new ArgumentException(
                    "Необходимо указать хотя бы одно число.");

            numbers.AddRange(values);
        }

        public void Insert(int index, int number)
        {
            if (index < 0 || index > numbers.Count)
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Индекс должен находиться в диапазоне от 0 до " +
                    numbers.Count + ".");

            numbers.Insert(index, number);
        }

        public bool Remove(int number)
        {
            return numbers.Remove(number);
        }

        public void RemoveAt(int index)
        {
            if (numbers.Count == 0)
                throw new InvalidOperationException(
                    "Невозможно удалить элемент: коллекция пуста.");

            if (index < 0 || index >= numbers.Count)
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Индекс должен находиться в диапазоне от 0 до " +
                    (numbers.Count - 1) + ".");

            numbers.RemoveAt(index);
        }

        public int IndexOf(int number)
        {
            return numbers.IndexOf(number);
        }

        public bool Contains(int number)
        {
            return numbers.Contains(number);
        }

        public void Sort()
        {
            numbers.Sort();
        }

        public void Clear()
        {
            numbers.Clear();
        }

        public List<int> GetAll()
        {
            return new List<int>(numbers);
        }

        public int Count
        {
            get { return numbers.Count; }
        }
    }
}
