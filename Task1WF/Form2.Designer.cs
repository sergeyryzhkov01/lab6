namespace Task1WF
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelCount;

        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxRange;

        private System.Windows.Forms.ListBox listBoxNumbers;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddRange;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveAt;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();

            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();

            this.listBoxNumbers = new System.Windows.Forms.ListBox();

            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddRange = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAt = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛР6 — Задание 1";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font(
                "Segoe UI", 16F, System.Drawing.FontStyle.Bold);

            this.labelTitle.Location = new System.Drawing.Point(25, 20);
            this.labelTitle.Text = "Работа с коллекцией List<int>";

            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(30, 80);
            this.labelNumber.Text = "Число:";

            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(30, 100);
            this.textBoxNumber.Size = new System.Drawing.Size(250, 23);
            this.textBoxNumber.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(30, 135);
            this.labelIndex.Text = "Индекс:";

            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(30, 155);
            this.textBoxIndex.Size = new System.Drawing.Size(250, 23);
            this.textBoxIndex.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(30, 190);
            this.labelRange.Text = "Числа через пробел:";

            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(30, 210);
            this.textBoxRange.Size = new System.Drawing.Size(250, 23);
            this.textBoxRange.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(30, 260);
            this.buttonAdd.Size = new System.Drawing.Size(120, 35);
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // 
            // buttonAddRange
            // 
            this.buttonAddRange.Location = new System.Drawing.Point(160, 260);
            this.buttonAddRange.Size = new System.Drawing.Size(120, 35);
            this.buttonAddRange.Text = "Добавить несколько";
            this.buttonAddRange.Click += new System.EventHandler(this.buttonAddRange_Click);

            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(30, 305);
            this.buttonInsert.Size = new System.Drawing.Size(120, 35);
            this.buttonInsert.Text = "Вставить";
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);

            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(160, 305);
            this.buttonRemove.Size = new System.Drawing.Size(120, 35);
            this.buttonRemove.Text = "Удалить по значению";
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);

            // 
            // buttonRemoveAt
            // 
            this.buttonRemoveAt.Location = new System.Drawing.Point(30, 350);
            this.buttonRemoveAt.Size = new System.Drawing.Size(120, 35);
            this.buttonRemoveAt.Text = "Удалить по индексу";
            this.buttonRemoveAt.Click += new System.EventHandler(this.buttonRemoveAt_Click);

            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(160, 350);
            this.buttonSearch.Size = new System.Drawing.Size(120, 35);
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);

            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(30, 395);
            this.buttonSort.Size = new System.Drawing.Size(120, 35);
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);

            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(160, 395);
            this.buttonClear.Size = new System.Drawing.Size(120, 35);
            this.buttonClear.Text = "Очистить";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.Location = new System.Drawing.Point(330, 80);
            this.listBoxNumbers.Size = new System.Drawing.Size(480, 355);
            this.listBoxNumbers.Font = new System.Drawing.Font("Consolas", 12F);
            this.listBoxNumbers.HorizontalScrollbar = true;

            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.labelCount.Location = new System.Drawing.Point(330, 450);
            this.labelCount.Text = "Количество элементов: 0";

            // 
            // Добавление элементов на форму
            // 
            this.Controls.Add(this.labelTitle);

            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxNumber);

            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.textBoxIndex);

            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.textBoxRange);

            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonAddRange);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonRemoveAt);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonClear);

            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.labelCount);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}