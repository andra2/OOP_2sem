namespace Lab4
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
            this.Generate = new System.Windows.Forms.Button();
            this.linq3 = new System.Windows.Forms.Button();
            this.linq1 = new System.Windows.Forms.Button();
            this.linq2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescSort = new System.Windows.Forms.Button();
            this.AscSort = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SortedlistBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate.Location = new System.Drawing.Point(12, 41);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(239, 32);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // linq3
            // 
            this.linq3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linq3.Location = new System.Drawing.Point(174, 79);
            this.linq3.Name = "linq3";
            this.linq3.Size = new System.Drawing.Size(75, 23);
            this.linq3.TabIndex = 1;
            this.linq3.Text = "LINQ3";
            this.linq3.UseVisualStyleBackColor = true;
            this.linq3.Click += new System.EventHandler(this.linq3_Click);
            // 
            // linq1
            // 
            this.linq1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linq1.Location = new System.Drawing.Point(12, 79);
            this.linq1.Name = "linq1";
            this.linq1.Size = new System.Drawing.Size(75, 23);
            this.linq1.TabIndex = 2;
            this.linq1.Text = "LINQ1";
            this.linq1.UseVisualStyleBackColor = true;
            this.linq1.Click += new System.EventHandler(this.linq1_Click);
            // 
            // linq2
            // 
            this.linq2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linq2.Location = new System.Drawing.Point(94, 79);
            this.linq2.Name = "linq2";
            this.linq2.Size = new System.Drawing.Size(75, 23);
            this.linq2.TabIndex = 3;
            this.linq2.Text = "LINQ2";
            this.linq2.UseVisualStyleBackColor = true;
            this.linq2.Click += new System.EventHandler(this.linq2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 4;
            // 
            // DescSort
            // 
            this.DescSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescSort.Location = new System.Drawing.Point(135, 108);
            this.DescSort.Name = "DescSort";
            this.DescSort.Size = new System.Drawing.Size(75, 23);
            this.DescSort.TabIndex = 5;
            this.DescSort.Text = "DescSort";
            this.DescSort.UseVisualStyleBackColor = true;
            this.DescSort.Click += new System.EventHandler(this.DescSort_Click);
            // 
            // AscSort
            // 
            this.AscSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AscSort.Location = new System.Drawing.Point(54, 108);
            this.AscSort.Name = "AscSort";
            this.AscSort.Size = new System.Drawing.Size(75, 23);
            this.AscSort.TabIndex = 6;
            this.AscSort.Text = "AscSort";
            this.AscSort.UseVisualStyleBackColor = true;
            this.AscSort.Click += new System.EventHandler(this.AscSort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // SortedlistBox2
            // 
            this.SortedlistBox2.FormattingEnabled = true;
            this.SortedlistBox2.Location = new System.Drawing.Point(135, 137);
            this.SortedlistBox2.Name = "SortedlistBox2";
            this.SortedlistBox2.Size = new System.Drawing.Size(120, 95);
            this.SortedlistBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(263, 236);
            this.Controls.Add(this.SortedlistBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AscSort);
            this.Controls.Add(this.DescSort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linq2);
            this.Controls.Add(this.linq1);
            this.Controls.Add(this.linq3);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "Коллекция";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button linq3;
        private System.Windows.Forms.Button linq1;
        private System.Windows.Forms.Button linq2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DescSort;
        private System.Windows.Forms.Button AscSort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox SortedlistBox2;
    }
}

