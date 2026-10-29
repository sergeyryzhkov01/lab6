using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Task2;
using Task3;

namespace Task3WF
{
    public partial class Form4 : Form
    {
        private readonly MotorcycleQueue queue =
            new MotorcycleQueue();

        public Form4()
        {
            InitializeComponent();

            textBoxBrand.TextChanged += TextBox_TextChanged;
            textBoxModel.TextChanged += TextBox_TextChanged;
            textBoxYear.TextChanged += TextBox_TextChanged;
            textBoxEngine.TextChanged += TextBox_TextChanged;
            textBoxPower.TextChanged += TextBox_TextChanged;
            textBoxPrice.TextChanged += TextBox_TextChanged;

            UpdateTable();
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

        private void HandleArgumentError(ArgumentException ex)
        {
            TextBox textBox = null;

            switch (ex.ParamName)
            {
                case "Brand":
                    textBox = textBoxBrand;
                    break;

                case "Model":
                    textBox = textBoxModel;
                    break;

                case "Year":
                    textBox = textBoxYear;
                    break;

                case "EngineCapacity":
                    textBox = textBoxEngine;
                    break;

                case "HorsePower":
                    textBox = textBoxPower;
                    break;

                case "Price":
                    textBox = textBoxPrice;
                    break;
            }

            if (textBox != null)
                ShowFieldError(textBox, ex.Message);
            else
                ShowError(ex.Message);
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

        private void UpdateTable()
        {
            dataGridViewQueue.Rows.Clear();

            Motorcycle[] motorcycles = queue.ToArray();

            for (int i = 0; i < motorcycles.Length; i++)
            {
                Motorcycle m = motorcycles[i];

                dataGridViewQueue.Rows.Add(
                    i,
                    m.Brand,
                    m.Model,
                    m.Year,
                    m.EngineCapacity,
                    m.HorsePower,
                    m.Price);
            }

            labelCount.Text =
                "Количество мотоциклов: " + queue.Count;
        }

        private Motorcycle ReadMotorcycle()
        {
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.Brand = textBoxBrand.Text.Trim();
            motorcycle.Model = textBoxModel.Text.Trim();

            int value;
            decimal price;

            if (!int.TryParse(textBoxYear.Text, out value))
                throw new ArgumentException(
                    "Введите корректный год выпуска.", "Year");

            motorcycle.Year = value;

            if (!int.TryParse(textBoxEngine.Text, out value))
                throw new ArgumentException(
                    "Введите корректный объём двигателя.",
                    "EngineCapacity");

            motorcycle.EngineCapacity = value;

            if (!int.TryParse(textBoxPower.Text, out value))
                throw new ArgumentException(
                    "Введите корректную мощность.",
                    "HorsePower");

            motorcycle.HorsePower = value;

            if (!decimal.TryParse(textBoxPrice.Text, out price))
                throw new ArgumentException(
                    "Введите корректную цену.", "Price");

            motorcycle.Price = price;

            Motorcycle.Validate(motorcycle);

            return motorcycle;
        }

        private void ClearInputs()
        {
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxYear.Clear();
            textBoxEngine.Clear();
            textBoxPower.Clear();
            textBoxPrice.Clear();

            textBoxBrand.Focus();
        }

        private void buttonEnqueue_Click(object sender, EventArgs e)
        {
            try
            {
                queue.Enqueue(ReadMotorcycle());

                UpdateTable();
                ClearInputs();
            }
            catch (ArgumentException ex)
            {
                HandleArgumentError(ex);
            }
        }

        private void buttonDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                Motorcycle motorcycle = queue.Dequeue();

                UpdateTable();

                ShowInfo("Извлечён мотоцикл:\n" + motorcycle);
            }
            catch (InvalidOperationException ex)
            {
                ShowError(ex.Message);
            }
        }

        private void buttonPeek_Click(object sender, EventArgs e)
        {
            try
            {
                Motorcycle motorcycle = queue.Peek();

                ShowInfo("Первый мотоцикл:\n" + motorcycle);
            }
            catch (InvalidOperationException ex)
            {
                ShowError(ex.Message);
            }
        }

        private void buttonContains_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                ShowInfo("Очередь пуста.");
                return;
            }

            try
            {
                Motorcycle motorcycle = ReadMotorcycle();

                if (queue.Contains(motorcycle))
                    ShowInfo("Мотоцикл найден.");
                else
                    ShowInfo("Мотоцикл не найден.");
            }
            catch (ArgumentException ex)
            {
                HandleArgumentError(ex);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = textBoxBrand.Text.Trim();

                List<Motorcycle> found =
                    queue.FindByBrand(brand);

                dataGridViewQueue.ClearSelection();

                if (found.Count == 0)
                {
                    ShowInfo("Мотоциклы не найдены.");
                    return;
                }

                int count = 0;

                foreach (DataGridViewRow row in dataGridViewQueue.Rows)
                {
                    string rowBrand =
                        Convert.ToString(row.Cells[1].Value);

                    if (string.Equals(
                        rowBrand,
                        brand,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        count++;
                    }
                }

                ShowInfo("Найдено мотоциклов: " + count);
            }
            catch (ArgumentException ex)
            {
                HandleArgumentError(ex);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                ShowInfo("Очередь уже пуста.");
                return;
            }

            queue.Clear();
            UpdateTable();
            ClearInputs();
        }
    }
}
