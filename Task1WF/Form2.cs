using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Task1;

namespace Task1WF
{
    public partial class Form2 : Form
    {
        private readonly NumberCollection collection =
            new NumberCollection();

        public Form2()
        {
            InitializeComponent();

            textBoxNumber.TextChanged += TextBox_TextChanged;
            textBoxIndex.TextChanged += TextBox_TextChanged;
            textBoxRange.TextChanged += TextBox_TextChanged;

            UpdateList();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
                textBox.BackColor = Color.White;
        }

        private void ShowFieldError(TextBox textBox, string message)
        {
            textBox.BackColor = Color.MistyRose;
            textBox.Focus();

            MessageBox.Show(
                message,
                "Ошибка ввода",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(
                message,
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateList()
        {
            listBoxNumbers.Items.Clear();

            List<int> numbers = collection.GetAll();

            for (int i = 0; i < numbers.Count; i++)
                listBoxNumbers.Items.Add(
                    "[" + i + "] = " + numbers[i]);

            labelCount.Text =
                "Количество элементов: " + collection.Count;
        }

        private int ReadNumber()
        {
            int number;

            if (!int.TryParse(textBoxNumber.Text, out number))
            {
                ShowFieldError(
                    textBoxNumber,
                    "Введите корректное целое число.");

                throw new FormatException();
            }

            return number;
        }

        private int ReadIndex()
        {
            int index;

            if (!int.TryParse(textBoxIndex.Text, out index))
            {
                ShowFieldError(
                    textBoxIndex,
                    "Введите корректный индекс.");

                throw new FormatException();
            }

            return index;
        }

        private int[] ReadNumberArray()
        {
            string input = textBoxRange.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                ShowFieldError(
                    textBoxRange,
                    "Введите хотя бы одно число.");

                throw new FormatException();
            }

            string[] parts = input.Split(
                new[] { ' ', '\t', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            foreach (string part in parts)
            {
                int number;

                if (!int.TryParse(part, out number))
                {
                    ShowFieldError(
                        textBoxRange,
                        "Некорректное число: " + part);

                    throw new FormatException();
                }

                numbers.Add(number);
            }

            return numbers.ToArray();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                collection.Add(ReadNumber());
                UpdateList();
            }
            catch (FormatException)
            {
            }
        }

        private void buttonAddRange_Click(object sender, EventArgs e)
        {
            try
            {
                collection.AddRange(ReadNumberArray());
                UpdateList();
            }
            catch (FormatException)
            {
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ReadIndex();
                int number = ReadNumber();

                collection.Insert(index, number);
                UpdateList();
            }
            catch (FormatException)
            {
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowFieldError(textBoxIndex, ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            try
            {
                int number = ReadNumber();

                if (!collection.Remove(number))
                    ShowInfo("Элемент не найден.");

                UpdateList();
            }
            catch (FormatException)
            {
            }
        }

        private void buttonRemoveAt_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            try
            {
                collection.RemoveAt(ReadIndex());
                UpdateList();
            }
            catch (FormatException)
            {
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowFieldError(textBoxIndex, ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            try
            {
                int index = collection.IndexOf(ReadNumber());

                if (index >= 0)
                {
                    listBoxNumbers.SelectedIndex = index;
                    ShowInfo("Элемент найден. Индекс: " + index);
                }
                else
                {
                    ShowInfo("Элемент не найден.");
                }
            }
            catch (FormatException)
            {
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            collection.Sort();
            UpdateList();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция уже пуста.");
                return;
            }

            collection.Clear();
            UpdateList();
        }
    }
}
