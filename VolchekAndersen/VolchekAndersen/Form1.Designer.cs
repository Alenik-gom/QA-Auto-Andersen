namespace VolchekAndersen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tasks = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.TextBox();
            this.tbPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Solve_Name = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_Massiv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Massiv = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Tasks.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbPage2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tasks
            // 
            this.Tasks.Controls.Add(this.tabPage1);
            this.Tasks.Controls.Add(this.tbPage2);
            this.Tasks.Controls.Add(this.tabPage2);
            this.Tasks.Controls.Add(this.tabPage3);
            this.Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tasks.Location = new System.Drawing.Point(0, 0);
            this.Tasks.Name = "Tasks";
            this.Tasks.SelectedIndex = 0;
            this.Tasks.Size = new System.Drawing.Size(419, 209);
            this.Tasks.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Solve);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TB);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Solve
            // 
            this.Solve.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.Solve.Location = new System.Drawing.Point(127, 120);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(151, 37);
            this.Solve.TabIndex = 2;
            this.Solve.Text = "Решить!";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число:";
            // 
            // TB
            // 
            this.TB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB.Location = new System.Drawing.Point(99, 81);
            this.TB.Name = "TB";
            this.TB.ShortcutsEnabled = false;
            this.TB.Size = new System.Drawing.Size(216, 33);
            this.TB.TabIndex = 0;
            this.TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_KeyPress);
            // 
            // tbPage2
            // 
            this.tbPage2.Controls.Add(this.BTN_Solve_Name);
            this.tbPage2.Controls.Add(this.label2);
            this.tbPage2.Controls.Add(this.TB_Name);
            this.tbPage2.Location = new System.Drawing.Point(4, 22);
            this.tbPage2.Name = "tbPage2";
            this.tbPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage2.Size = new System.Drawing.Size(411, 183);
            this.tbPage2.TabIndex = 1;
            this.tbPage2.Text = "Задание 2";
            this.tbPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_Solve_Name
            // 
            this.BTN_Solve_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.BTN_Solve_Name.Location = new System.Drawing.Point(124, 129);
            this.BTN_Solve_Name.Name = "BTN_Solve_Name";
            this.BTN_Solve_Name.Size = new System.Drawing.Size(151, 37);
            this.BTN_Solve_Name.TabIndex = 5;
            this.BTN_Solve_Name.Text = "Решить!";
            this.BTN_Solve_Name.UseVisualStyleBackColor = true;
            this.BTN_Solve_Name.Click += new System.EventHandler(this.BTN_Solve_Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите имя:";
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Name.Location = new System.Drawing.Point(91, 80);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(225, 33);
            this.TB_Name.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_Massiv);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.TB_Massiv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(411, 183);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Задание 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_Massiv
            // 
            this.BTN_Massiv.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.BTN_Massiv.Location = new System.Drawing.Point(133, 138);
            this.BTN_Massiv.Name = "BTN_Massiv";
            this.BTN_Massiv.Size = new System.Drawing.Size(151, 37);
            this.BTN_Massiv.TabIndex = 8;
            this.BTN_Massiv.Text = "Решить!";
            this.BTN_Massiv.UseVisualStyleBackColor = true;
            this.BTN_Massiv.Click += new System.EventHandler(this.BTN_Massiv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 75);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите массив чисел, разделяя \r\nэлементы пробелами.\r\nНапример, 1 8 3";
            // 
            // TB_Massiv
            // 
            this.TB_Massiv.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Massiv.Location = new System.Drawing.Point(8, 99);
            this.TB_Massiv.Name = "TB_Massiv";
            this.TB_Massiv.ShortcutsEnabled = false;
            this.TB_Massiv.Size = new System.Drawing.Size(390, 33);
            this.TB_Massiv.TabIndex = 6;
            this.TB_Massiv.Text = " ";
            this.TB_Massiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Massiv_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(411, 183);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Текстовое задание";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(43, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 138);
            this.label4.TabIndex = 8;
            this.label4.Text = " скобочная последовательность:\r\n [((())()(())]]\r\nне является правильной.\r\n\r\nПрави" +
    "льная:\r\n [[(())()(())]]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 209);
            this.Controls.Add(this.Tasks);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Волчек Елена. QA Auto Тестовое задание";
            this.Tasks.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbPage2.ResumeLayout(false);
            this.tbPage2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tasks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.TabPage tbPage2;
        private System.Windows.Forms.Button BTN_Solve_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTN_Massiv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Massiv;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
    }
}

