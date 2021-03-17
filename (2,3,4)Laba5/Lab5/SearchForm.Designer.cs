namespace Lab5
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.creatorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchDataGrid = new System.Windows.Forms.DataGridView();
            this.Id_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CapacFrom = new System.Windows.Forms.NumericUpDown();
            this.CarryTo = new System.Windows.Forms.NumericUpDown();
            this.CapacTo = new System.Windows.Forms.NumericUpDown();
            this.CarryFrom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapacFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarryTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarryFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // creatorBox
            // 
            this.creatorBox.Location = new System.Drawing.Point(23, 42);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.Size = new System.Drawing.Size(183, 20);
            this.creatorBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Производитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(23, 85);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(183, 20);
            this.typeBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Сбросить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchDataGrid
            // 
            this.searchDataGrid.AllowUserToDeleteRows = false;
            this.searchDataGrid.AllowUserToResizeColumns = false;
            this.searchDataGrid.AllowUserToResizeRows = false;
            this.searchDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.searchDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.searchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Col,
            this.TypeColumn,
            this.type,
            this.SeatsCol,
            this.CreatedCol,
            this.CarryCol,
            this.CrewCol});
            this.searchDataGrid.Location = new System.Drawing.Point(231, 26);
            this.searchDataGrid.Name = "searchDataGrid";
            this.searchDataGrid.ReadOnly = true;
            this.searchDataGrid.RowHeadersVisible = false;
            this.searchDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchDataGrid.Size = new System.Drawing.Size(557, 350);
            this.searchDataGrid.TabIndex = 8;
            this.searchDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGrid_CellContentClick);
            // 
            // Id_Col
            // 
            this.Id_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id_Col.HeaderText = "ID";
            this.Id_Col.Name = "Id_Col";
            this.Id_Col.ReadOnly = true;
            this.Id_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_Col.Width = 43;
            // 
            // TypeColumn
            // 
            this.TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeColumn.HeaderText = "Производитель";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 111;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type.HeaderText = "тип";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 49;
            // 
            // SeatsCol
            // 
            this.SeatsCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SeatsCol.HeaderText = "Мест";
            this.SeatsCol.Name = "SeatsCol";
            this.SeatsCol.ReadOnly = true;
            this.SeatsCol.Width = 58;
            // 
            // CreatedCol
            // 
            this.CreatedCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedCol.HeaderText = "Произведен";
            this.CreatedCol.Name = "CreatedCol";
            this.CreatedCol.ReadOnly = true;
            this.CreatedCol.Width = 94;
            // 
            // CarryCol
            // 
            this.CarryCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CarryCol.HeaderText = "Грузоподъемность";
            this.CarryCol.Name = "CarryCol";
            this.CarryCol.ReadOnly = true;
            this.CarryCol.Width = 129;
            // 
            // CrewCol
            // 
            this.CrewCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CrewCol.HeaderText = "Экипаж";
            this.CrewCol.Name = "CrewCol";
            this.CrewCol.ReadOnly = true;
            this.CrewCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CrewCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CrewCol.Width = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Грузоподъемность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "до";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "от";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Мест";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CarryFrom);
            this.groupBox1.Controls.Add(this.CapacTo);
            this.groupBox1.Controls.Add(this.CarryTo);
            this.groupBox1.Controls.Add(this.CapacFrom);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 209);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // CapacFrom
            // 
            this.CapacFrom.Location = new System.Drawing.Point(47, 121);
            this.CapacFrom.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CapacFrom.Name = "CapacFrom";
            this.CapacFrom.Size = new System.Drawing.Size(47, 20);
            this.CapacFrom.TabIndex = 22;
            // 
            // CarryTo
            // 
            this.CarryTo.Location = new System.Drawing.Point(134, 171);
            this.CarryTo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CarryTo.Name = "CarryTo";
            this.CarryTo.Size = new System.Drawing.Size(47, 20);
            this.CarryTo.TabIndex = 23;
            this.CarryTo.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // CapacTo
            // 
            this.CapacTo.Location = new System.Drawing.Point(134, 120);
            this.CapacTo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CapacTo.Name = "CapacTo";
            this.CapacTo.Size = new System.Drawing.Size(47, 20);
            this.CapacTo.TabIndex = 24;
            this.CapacTo.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // CarryFrom
            // 
            this.CarryFrom.Location = new System.Drawing.Point(47, 171);
            this.CarryFrom.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CarryFrom.Name = "CarryFrom";
            this.CarryFrom.Size = new System.Drawing.Size(47, 20);
            this.CarryFrom.TabIndex = 25;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchDataGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creatorBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CapacFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarryTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarryFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox creatorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView searchDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarryCol;
        private System.Windows.Forms.DataGridViewButtonColumn CrewCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown CarryFrom;
        private System.Windows.Forms.NumericUpDown CapacTo;
        private System.Windows.Forms.NumericUpDown CarryTo;
        private System.Windows.Forms.NumericUpDown CapacFrom;
    }
}