using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Task2;

namespace Task2WF
{
    public partial class Form3 : Form
    {
        private readonly MotorcycleCollection collection =
            new MotorcycleCollection();

        public Form3()
        {
            InitializeComponent();

            textBoxBrand.TextChanged += TextBox_TextChanged;
            textBoxModel.TextChanged += TextBox_TextChanged;
            textBoxYear.TextChanged += TextBox_TextChanged;
            textBoxEngine.TextChanged += TextBox_TextChanged;
            textBoxPower.TextChanged += TextBox_TextChanged;
            textBoxPrice.TextChanged += TextBox_TextChanged;
            textBoxIndex.TextChanged += TextBox_TextChanged;

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

                case "index":
                    textBox = textBoxIndex;
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
            dataGridViewMotorcycles.Rows.Clear();

            List<Motorcycle> motorcycles = collection.GetAll();

            for (int i = 0; i < motorcycles.Count; i++)
            {
                Motorcycle m = motorcycles[i];

                dataGridViewMotorcycles.Rows.Add(
                    i,
                    m.Brand,
                    m.Model,
                    m.Year,
                    m.EngineCapacity,
                    m.HorsePower,
                    m.Price);
            }

            labelCount.Text =
                "Количество мотоциклов: " + collection.Count;
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

        private int ReadIndex()
        {
            int index;

            if (!int.TryParse(textBoxIndex.Text, out index))
                throw new ArgumentException(
                    "Введите корректный индекс.", "index");

            return index;
        }

        private void ClearInputs()
        {
            textBoxBrand.Clear();
            textBoxModel.Clear();
            textBoxYear.Clear();
            textBoxEngine.Clear();
            textBoxPower.Clear();
            textBoxPrice.Clear();
            textBoxIndex.Clear();

            textBoxBrand.Focus();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                collection.Add(ReadMotorcycle());
                UpdateTable();
                ClearInputs();
            }
            catch (ArgumentException ex)
            {
                HandleArgumentError(ex);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ReadIndex();
                collection.Insert(index, ReadMotorcycle());

                UpdateTable();
                ClearInputs();
            }
            catch (ArgumentException ex)
            {
                HandleArgumentError(ex);
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
                UpdateTable();
            }
            catch (ArgumentException ex)
            {
                HandleArgumentError(ex);
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            if (dataGridViewMotorcycles.SelectedRows.Count == 0)
            {
                ShowInfo("Выберите мотоцикл в таблице.");
                return;
            }

            int index = Convert.ToInt32(
                dataGridViewMotorcycles.SelectedRows[0].Cells[0].Value);

            Motorcycle motorcycle = collection.GetByIndex(index);

            collection.Remove(motorcycle);
            UpdateTable();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = textBoxBrand.Text.Trim();

                List<Motorcycle> found =
                    collection.FindByBrand(brand);

                dataGridViewMotorcycles.ClearSelection();

                if (found.Count == 0)
                {
                    ShowInfo("Мотоциклы не найдены.");
                    return;
                }

                int count = 0;

                foreach (DataGridViewRow row in dataGridViewMotorcycles.Rows)
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

        private void buttonSortYear_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            collection.SortByYear();
            UpdateTable();
        }

        private void buttonSortPrice_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция пуста.");
                return;
            }

            collection.SortByPrice();
            UpdateTable();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (collection.Count == 0)
            {
                ShowInfo("Коллекция уже пуста.");
                return;
            }

            collection.Clear();
            UpdateTable();
            ClearInputs();
        }
    }
}