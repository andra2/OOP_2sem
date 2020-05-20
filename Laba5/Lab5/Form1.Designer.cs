namespace Lab5
{
    partial class Airport
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdInput = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ScrollBarLable = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPlane = new System.Windows.Forms.Button();
            this.AddCrew = new System.Windows.Forms.Button();
            this.JsonSave = new System.Windows.Forms.Button();
            this.JsonRead = new System.Windows.Forms.Button();
            this.IdErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Col,
            this.TypeColumn,
            this.type,
            this.SeatsCol,
            this.CreatedCol,
            this.CarryCol,
            this.CrewCol});
            this.dataGridView1.Location = new System.Drawing.Point(254, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(600, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Col
            // 
            this.Id_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id_Col.HeaderText = "ID";
            this.Id_Col.Name = "Id_Col";
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
            // IdInput
            // 
            this.IdInput.AutoSize = true;
            this.IdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdInput.Location = new System.Drawing.Point(12, 24);
            this.IdInput.Name = "IdInput";
            this.IdInput.Size = new System.Drawing.Size(19, 15);
            this.IdInput.TabIndex = 1;
            this.IdInput.Text = "ID";
            this.IdInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(12, 102);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(210, 35);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ScrollBarLable
            // 
            this.ScrollBarLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScrollBarLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrollBarLable.Location = new System.Drawing.Point(12, 76);
            this.ScrollBarLable.Name = "ScrollBarLable";
            this.ScrollBarLable.ReadOnly = true;
            this.ScrollBarLable.Size = new System.Drawing.Size(213, 21);
            this.ScrollBarLable.TabIndex = 7;
            this.ScrollBarLable.Text = "Количество мест: 2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Пассажирский";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 189);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Грузовой";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 212);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Военный";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(12, 318);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.TabIndex = 13;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Произведен";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AIRBUS",
            "Boeing",
            "Raytheon"});
            this.comboBox1.Location = new System.Drawing.Point(12, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Производитель";
            // 
            // AddPlane
            // 
            this.AddPlane.Location = new System.Drawing.Point(12, 492);
            this.AddPlane.Name = "AddPlane";
            this.AddPlane.Size = new System.Drawing.Size(123, 30);
            this.AddPlane.TabIndex = 17;
            this.AddPlane.Text = "Добавить самолет";
            this.AddPlane.UseVisualStyleBackColor = true;
            this.AddPlane.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCrew
            // 
            this.AddCrew.Location = new System.Drawing.Point(254, 396);
            this.AddCrew.Name = "AddCrew";
            this.AddCrew.Size = new System.Drawing.Size(129, 30);
            this.AddCrew.TabIndex = 18;
            this.AddCrew.Text = "Добавить работника";
            this.AddCrew.UseVisualStyleBackColor = true;
            this.AddCrew.Click += new System.EventHandler(this.AddCrew_Click);
            // 
            // JsonSave
            // 
            this.JsonSave.Location = new System.Drawing.Point(725, 405);
            this.JsonSave.Name = "JsonSave";
            this.JsonSave.Size = new System.Drawing.Size(129, 30);
            this.JsonSave.TabIndex = 19;
            this.JsonSave.Text = "Запись в JSON";
            this.JsonSave.UseVisualStyleBackColor = true;
            // 
            // JsonRead
            // 
            this.JsonRead.Location = new System.Drawing.Point(725, 450);
            this.JsonRead.Name = "JsonRead";
            this.JsonRead.Size = new System.Drawing.Size(129, 30);
            this.JsonRead.TabIndex = 20;
            this.JsonRead.Text = "Чтение из JSON";
            this.JsonRead.UseVisualStyleBackColor = true;
            // 
            // IdErr
            // 
            this.IdErr.ContainerControl = this;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(12, 42);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(120, 20);
            this.IdBox.TabIndex = 21;
            this.IdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IdBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 567);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.JsonRead);
            this.Controls.Add(this.JsonSave);
            this.Controls.Add(this.AddCrew);
            this.Controls.Add(this.AddPlane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ScrollBarLable);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IdInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Airport";
            this.Text = "Аэропорт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IdInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarryCol;
        private System.Windows.Forms.DataGridViewButtonColumn CrewCol;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox ScrollBarLable;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddPlane;
        private System.Windows.Forms.Button AddCrew;
        private System.Windows.Forms.Button JsonSave;
        private System.Windows.Forms.Button JsonRead;
        private System.Windows.Forms.ErrorProvider IdErr;
        private System.Windows.Forms.NumericUpDown IdBox;
    }
}

