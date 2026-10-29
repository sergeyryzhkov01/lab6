namespace Task2WF
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelCount;

        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxIndex;

        private System.Windows.Forms.DataGridView dataGridViewMotorcycles;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonRemoveAt;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSortYear;
        private System.Windows.Forms.Button buttonSortPrice;
        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.DataGridViewTextBoxColumn columnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEngine;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelEngine = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();

            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();

            this.dataGridViewMotorcycles =
                new System.Windows.Forms.DataGridView();

            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonRemoveAt = new System.Windows.Forms.Button();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSortYear = new System.Windows.Forms.Button();
            this.buttonSortPrice = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();

            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridViewMotorcycles)).BeginInit();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Text = "ЛР6 — Задание 2";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.labelTitle.Text = "Коллекция мотоциклов List<Motorcycle>";
            this.labelTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(25, 15);

            this.labelBrand.Text = "Марка:";
            this.labelBrand.Location = new System.Drawing.Point(30, 65);
            this.labelBrand.AutoSize = true;

            this.textBoxBrand.Location = new System.Drawing.Point(30, 85);
            this.textBoxBrand.Size = new System.Drawing.Size(150, 25);

            this.labelModel.Text = "Модель:";
            this.labelModel.Location = new System.Drawing.Point(200, 65);
            this.labelModel.AutoSize = true;

            this.textBoxModel.Location = new System.Drawing.Point(200, 85);
            this.textBoxModel.Size = new System.Drawing.Size(150, 25);

            this.labelYear.Text = "Год:";
            this.labelYear.Location = new System.Drawing.Point(370, 65);
            this.labelYear.AutoSize = true;

            this.textBoxYear.Location = new System.Drawing.Point(370, 85);
            this.textBoxYear.Size = new System.Drawing.Size(100, 25);

            this.labelEngine.Text = "Объём (см³):";
            this.labelEngine.Location = new System.Drawing.Point(490, 65);
            this.labelEngine.AutoSize = true;

            this.textBoxEngine.Location = new System.Drawing.Point(490, 85);
            this.textBoxEngine.Size = new System.Drawing.Size(100, 25);

            this.labelPower.Text = "Мощность (л.с.):";
            this.labelPower.Location = new System.Drawing.Point(610, 65);
            this.labelPower.AutoSize = true;

            this.textBoxPower.Location = new System.Drawing.Point(610, 85);
            this.textBoxPower.Size = new System.Drawing.Size(120, 25);

            this.labelPrice.Text = "Цена (руб.):";
            this.labelPrice.Location = new System.Drawing.Point(750, 65);
            this.labelPrice.AutoSize = true;

            this.textBoxPrice.Location = new System.Drawing.Point(750, 85);
            this.textBoxPrice.Size = new System.Drawing.Size(130, 25);

            this.labelIndex.Text = "Индекс:";
            this.labelIndex.Location = new System.Drawing.Point(900, 65);
            this.labelIndex.AutoSize = true;

            this.textBoxIndex.Location = new System.Drawing.Point(900, 85);
            this.textBoxIndex.Size = new System.Drawing.Size(100, 25);

            this.dataGridViewMotorcycles.Location =
                new System.Drawing.Point(30, 140);

            this.dataGridViewMotorcycles.Size =
                new System.Drawing.Size(1040, 350);

            this.dataGridViewMotorcycles.AllowUserToAddRows = false;
            this.dataGridViewMotorcycles.AllowUserToDeleteRows = false;
            this.dataGridViewMotorcycles.ReadOnly = true;
            this.dataGridViewMotorcycles.MultiSelect = true;
            this.dataGridViewMotorcycles.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dataGridViewMotorcycles.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.columnIndex.HeaderText = "Индекс";
            this.columnBrand.HeaderText = "Марка";
            this.columnModel.HeaderText = "Модель";
            this.columnYear.HeaderText = "Год";
            this.columnEngine.HeaderText = "Объём";
            this.columnPower.HeaderText = "Мощность";
            this.columnPrice.HeaderText = "Цена";

            this.dataGridViewMotorcycles.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.columnIndex,
                    this.columnBrand,
                    this.columnModel,
                    this.columnYear,
                    this.columnEngine,
                    this.columnPower,
                    this.columnPrice
                });

            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Location = new System.Drawing.Point(30, 515);
            this.buttonAdd.Size = new System.Drawing.Size(120, 35);
            this.buttonAdd.Click +=
                new System.EventHandler(this.buttonAdd_Click);

            this.buttonInsert.Text = "Вставить";
            this.buttonInsert.Location = new System.Drawing.Point(160, 515);
            this.buttonInsert.Size = new System.Drawing.Size(120, 35);
            this.buttonInsert.Click +=
                new System.EventHandler(this.buttonInsert_Click);

            this.buttonRemoveAt.Text = "Удалить по индексу";
            this.buttonRemoveAt.Location = new System.Drawing.Point(290, 515);
            this.buttonRemoveAt.Size = new System.Drawing.Size(150, 35);
            this.buttonRemoveAt.Click +=
                new System.EventHandler(this.buttonRemoveAt_Click);

            this.buttonRemoveSelected.Text = "Удалить выбранный";
            this.buttonRemoveSelected.Location = new System.Drawing.Point(450, 515);
            this.buttonRemoveSelected.Size = new System.Drawing.Size(150, 35);
            this.buttonRemoveSelected.Click +=
                new System.EventHandler(this.buttonRemoveSelected_Click);

            this.buttonSearch.Text = "Поиск по марке";
            this.buttonSearch.Location = new System.Drawing.Point(610, 515);
            this.buttonSearch.Size = new System.Drawing.Size(140, 35);
            this.buttonSearch.Click +=
                new System.EventHandler(this.buttonSearch_Click);

            this.buttonSortYear.Text = "Сортировать по году";
            this.buttonSortYear.Location = new System.Drawing.Point(30, 560);
            this.buttonSortYear.Size = new System.Drawing.Size(180, 35);
            this.buttonSortYear.Click +=
                new System.EventHandler(this.buttonSortYear_Click);

            this.buttonSortPrice.Text = "Сортировать по цене";
            this.buttonSortPrice.Location = new System.Drawing.Point(220, 560);
            this.buttonSortPrice.Size = new System.Drawing.Size(180, 35);
            this.buttonSortPrice.Click +=
                new System.EventHandler(this.buttonSortPrice_Click);

            this.buttonClear.Text = "Очистить коллекцию";
            this.buttonClear.Location = new System.Drawing.Point(410, 560);
            this.buttonClear.Size = new System.Drawing.Size(180, 35);
            this.buttonClear.Click +=
                new System.EventHandler(this.buttonClear_Click);

            this.labelCount.Text = "Количество мотоциклов: 0";
            this.labelCount.Location = new System.Drawing.Point(780, 570);
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelEngine);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelCount);

            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxEngine);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxIndex);

            this.Controls.Add(this.dataGridViewMotorcycles);

            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonRemoveAt);
            this.Controls.Add(this.buttonRemoveSelected);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSortYear);
            this.Controls.Add(this.buttonSortPrice);
            this.Controls.Add(this.buttonClear);

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridViewMotorcycles)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}