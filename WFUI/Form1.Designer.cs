namespace WFUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelVariant;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVariant = new System.Windows.Forms.Label();

            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "Лабораторная работа №6";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.labelTitle.AutoSize = true;
            this.labelTitle.Text = "Лабораторная работа №6";
            this.labelTitle.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(85, 35);

            this.labelVariant.AutoSize = true;
            this.labelVariant.Text = "Вариант 4";
            this.labelVariant.Font = new System.Drawing.Font(
                "Segoe UI", 13F);
            this.labelVariant.Location = new System.Drawing.Point(200, 85);

            this.button1.Text = "Задание 1 — List<int>";
            this.button1.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.button1.Location = new System.Drawing.Point(80, 145);
            this.button1.Size = new System.Drawing.Size(340, 50);
            this.button1.Click +=
                new System.EventHandler(this.button1_Click);

            this.button2.Text = "Задание 2 — List<Motorcycle>";
            this.button2.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.button2.Location = new System.Drawing.Point(80, 215);
            this.button2.Size = new System.Drawing.Size(340, 50);
            this.button2.Click +=
                new System.EventHandler(this.button2_Click);

            this.button3.Text = "Задание 3 — Queue<Motorcycle>";
            this.button3.Font = new System.Drawing.Font(
                "Segoe UI", 11F);
            this.button3.Location = new System.Drawing.Point(80, 285);
            this.button3.Size = new System.Drawing.Size(340, 50);
            this.button3.Click +=
                new System.EventHandler(this.button3_Click);

            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelVariant);

            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

