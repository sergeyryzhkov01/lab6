namespace Task3WF
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCount;

        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxPrice;

        private System.Windows.Forms.DataGridView dataGridViewQueue;

        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.Button buttonPeek;
        private System.Windows.Forms.Button buttonContains;
        private System.Windows.Forms.Button buttonSearch;
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
            if (disposing && components != null)
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
            this.labelCount = new System.Windows.Forms.Label();

            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();

            this.dataGridViewQueue = new System.Windows.Forms.DataGridView();

            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.buttonPeek = new System.Windows.Forms.Button();
            this.buttonContains = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();

            this.columnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridViewQueue)).BeginInit();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Text = "ЛР6 — Задание 3";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.labelTitle.Text = "Очередь мотоциклов Queue<Motorcycle>";
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

            this.dataGridViewQueue.Location =
                new System.Drawing.Point(30, 140);

            this.dataGridViewQueue.Size =
                new System.Drawing.Size(1040, 340);

            this.dataGridViewQueue.AllowUserToAddRows = false;
            this.dataGridViewQueue.AllowUserToDeleteRows = false;
            this.dataGridViewQueue.ReadOnly = true;
            this.dataGridViewQueue.MultiSelect = true;
            this.dataGridViewQueue.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dataGridViewQueue.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.columnIndex.HeaderText = "Позиция";
            this.columnBrand.HeaderText = "Марка";
            this.columnModel.HeaderText = "Модель";
            this.columnYear.HeaderText = "Год";
            this.columnEngine.HeaderText = "Объём";
            this.columnPower.HeaderText = "Мощность";
            this.columnPrice.HeaderText = "Цена";

            this.dataGridViewQueue.Columns.AddRange(
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

            this.buttonEnqueue.Text = "Добавить в очередь";
            this.buttonEnqueue.Location = new System.Drawing.Point(30, 510);
            this.buttonEnqueue.Size = new System.Drawing.Size(160, 35);
            this.buttonEnqueue.Click +=
                new System.EventHandler(this.buttonEnqueue_Click);

            this.buttonDequeue.Text = "Извлечь первый";
            this.buttonDequeue.Location = new System.Drawing.Point(200, 510);
            this.buttonDequeue.Size = new System.Drawing.Size(160, 35);
            this.buttonDequeue.Click +=
                new System.EventHandler(this.buttonDequeue_Click);

            this.buttonPeek.Text = "Посмотреть первый";
            this.buttonPeek.Location = new System.Drawing.Point(370, 510);
            this.buttonPeek.Size = new System.Drawing.Size(160, 35);
            this.buttonPeek.Click +=
                new System.EventHandler(this.buttonPeek_Click);

            this.buttonContains.Text = "Проверить наличие";
            this.buttonContains.Location = new System.Drawing.Point(540, 510);
            this.buttonContains.Size = new System.Drawing.Size(160, 35);
            this.buttonContains.Click +=
                new System.EventHandler(this.buttonContains_Click);

            this.buttonSearch.Text = "Поиск по марке";
            this.buttonSearch.Location = new System.Drawing.Point(710, 510);
            this.buttonSearch.Size = new System.Drawing.Size(160, 35);
            this.buttonSearch.Click +=
                new System.EventHandler(this.buttonSearch_Click);

            this.buttonClear.Text = "Очистить очередь";
            this.buttonClear.Location = new System.Drawing.Point(880, 510);
            this.buttonClear.Size = new System.Drawing.Size(160, 35);
            this.buttonClear.Click +=
                new System.EventHandler(this.buttonClear_Click);

            this.labelCount.Text = "Количество мотоциклов: 0";
            this.labelCount.Location = new System.Drawing.Point(30, 565);
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
            this.Controls.Add(this.labelCount);

            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxEngine);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.textBoxPrice);

            this.Controls.Add(this.dataGridViewQueue);

            this.Controls.Add(this.buttonEnqueue);
            this.Controls.Add(this.buttonDequeue);
            this.Controls.Add(this.buttonPeek);
            this.Controls.Add(this.buttonContains);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClear);

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridViewQueue)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}