﻿namespace Lab5
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
            this.IdInput = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ScrollBarLable = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.creatorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPlane = new System.Windows.Forms.Button();
            this.JsonSave = new System.Windows.Forms.Button();
            this.JsonRead = new System.Windows.Forms.Button();
            this.IdErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdBox = new System.Windows.Forms.NumericUpDown();
            this.CarryingBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.производителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.датеПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.descToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Id_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.CrewCol,
            this.State});
            this.dataGridView1.Location = new System.Drawing.Point(228, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(626, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.ScrollBarLable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScrollBarLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrollBarLable.Location = new System.Drawing.Point(12, 76);
            this.ScrollBarLable.Name = "ScrollBarLable";
            this.ScrollBarLable.ReadOnly = true;
            this.ScrollBarLable.Size = new System.Drawing.Size(138, 14);
            this.ScrollBarLable.TabIndex = 7;
            this.ScrollBarLable.Text = "Количество мест: 2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Calendar.Location = new System.Drawing.Point(12, 363);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.TabIndex = 13;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Произведён";
            // 
            // creatorBox
            // 
            this.creatorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creatorBox.FormattingEnabled = true;
            this.creatorBox.Items.AddRange(new object[] {
            "AIRBUS",
            "Boeing",
            "Raytheon"});
            this.creatorBox.Location = new System.Drawing.Point(12, 262);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.Size = new System.Drawing.Size(164, 21);
            this.creatorBox.TabIndex = 15;
            this.creatorBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Производитель";
            // 
            // AddPlane
            // 
            this.AddPlane.Location = new System.Drawing.Point(228, 396);
            this.AddPlane.Name = "AddPlane";
            this.AddPlane.Size = new System.Drawing.Size(123, 30);
            this.AddPlane.TabIndex = 17;
            this.AddPlane.Text = "Добавить самолет";
            this.AddPlane.UseVisualStyleBackColor = true;
            this.AddPlane.Click += new System.EventHandler(this.button1_Click);
            // 
            // JsonSave
            // 
            this.JsonSave.Location = new System.Drawing.Point(731, 396);
            this.JsonSave.Name = "JsonSave";
            this.JsonSave.Size = new System.Drawing.Size(123, 30);
            this.JsonSave.TabIndex = 19;
            this.JsonSave.Text = "Сохранить";
            this.JsonSave.UseVisualStyleBackColor = true;
            this.JsonSave.Click += new System.EventHandler(this.JsonSave_Click);
            // 
            // JsonRead
            // 
            this.JsonRead.Location = new System.Drawing.Point(731, 432);
            this.JsonRead.Name = "JsonRead";
            this.JsonRead.Size = new System.Drawing.Size(123, 30);
            this.JsonRead.TabIndex = 20;
            this.JsonRead.Text = "Загрузить";
            this.JsonRead.UseVisualStyleBackColor = true;
            this.JsonRead.Click += new System.EventHandler(this.JsonRead_Click);
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
            // CarryingBox
            // 
            this.CarryingBox.Location = new System.Drawing.Point(12, 311);
            this.CarryingBox.Name = "CarryingBox";
            this.CarryingBox.Size = new System.Drawing.Size(58, 20);
            this.CarryingBox.TabIndex = 22;
            this.CarryingBox.Text = "15";
            this.CarryingBox.TextChanged += new System.EventHandler(this.CarryingBox_TextChanged);
            this.CarryingBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CarryingBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Грузоподъемность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(72, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "тонн";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.JsonSave_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.JsonRead_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripMenuItem,
            this.типуToolStripMenuItem,
            this.производителюToolStripMenuItem,
            this.датеПроизводстваToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascToolStripMenuItem,
            this.descToolStripMenuItem});
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.idToolStripMenuItem.Text = "Id";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // ascToolStripMenuItem
            // 
            this.ascToolStripMenuItem.Name = "ascToolStripMenuItem";
            this.ascToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ascToolStripMenuItem.Text = "Asc";
            this.ascToolStripMenuItem.Click += new System.EventHandler(this.ascToolStripMenuItem_Click);
            // 
            // descToolStripMenuItem
            // 
            this.descToolStripMenuItem.Name = "descToolStripMenuItem";
            this.descToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.descToolStripMenuItem.Text = "Desc";
            this.descToolStripMenuItem.Click += new System.EventHandler(this.descToolStripMenuItem_Click);
            // 
            // типуToolStripMenuItem
            // 
            this.типуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascToolStripMenuItem1,
            this.descToolStripMenuItem1});
            this.типуToolStripMenuItem.Name = "типуToolStripMenuItem";
            this.типуToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.типуToolStripMenuItem.Text = "Типу";
            // 
            // ascToolStripMenuItem1
            // 
            this.ascToolStripMenuItem1.Name = "ascToolStripMenuItem1";
            this.ascToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.ascToolStripMenuItem1.Text = "Asc";
            this.ascToolStripMenuItem1.Click += new System.EventHandler(this.ascToolStripMenuItem1_Click);
            // 
            // descToolStripMenuItem1
            // 
            this.descToolStripMenuItem1.Name = "descToolStripMenuItem1";
            this.descToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.descToolStripMenuItem1.Text = "Desc";
            this.descToolStripMenuItem1.Click += new System.EventHandler(this.descToolStripMenuItem1_Click);
            // 
            // производителюToolStripMenuItem
            // 
            this.производителюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascToolStripMenuItem2,
            this.descToolStripMenuItem2});
            this.производителюToolStripMenuItem.Name = "производителюToolStripMenuItem";
            this.производителюToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.производителюToolStripMenuItem.Text = "Производителю";
            // 
            // ascToolStripMenuItem2
            // 
            this.ascToolStripMenuItem2.Name = "ascToolStripMenuItem2";
            this.ascToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.ascToolStripMenuItem2.Text = "Asc";
            this.ascToolStripMenuItem2.Click += new System.EventHandler(this.ascToolStripMenuItem2_Click);
            // 
            // descToolStripMenuItem2
            // 
            this.descToolStripMenuItem2.Name = "descToolStripMenuItem2";
            this.descToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.descToolStripMenuItem2.Text = "Desc";
            this.descToolStripMenuItem2.Click += new System.EventHandler(this.descToolStripMenuItem2_Click);
            // 
            // датеПроизводстваToolStripMenuItem
            // 
            this.датеПроизводстваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascToolStripMenuItem3,
            this.descToolStripMenuItem3});
            this.датеПроизводстваToolStripMenuItem.Name = "датеПроизводстваToolStripMenuItem";
            this.датеПроизводстваToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.датеПроизводстваToolStripMenuItem.Text = "Дате производства";
            // 
            // ascToolStripMenuItem3
            // 
            this.ascToolStripMenuItem3.Name = "ascToolStripMenuItem3";
            this.ascToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.ascToolStripMenuItem3.Text = "Asc";
            this.ascToolStripMenuItem3.Click += new System.EventHandler(this.ascToolStripMenuItem3_Click);
            // 
            // descToolStripMenuItem3
            // 
            this.descToolStripMenuItem3.Name = "descToolStripMenuItem3";
            this.descToolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.descToolStripMenuItem3.Text = "Desc";
            this.descToolStripMenuItem3.Click += new System.EventHandler(this.descToolStripMenuItem3_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.помощьToolStripMenuItem.Text = "Поиск";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(886, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(228, 432);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 30);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Удалить самолет";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(809, 0);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(77, 24);
            this.ShowButton.TabIndex = 29;
            this.ShowButton.Text = "скрыть";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(228, 468);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(123, 30);
            this.CopyButton.TabIndex = 30;
            this.CopyButton.Text = "Копировать самолет";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 30);
            this.button2.TabIndex = 31;
            this.button2.Text = "Изменить статус";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Id_Col
            // 
            this.Id_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id_Col.HeaderText = "ID";
            this.Id_Col.Name = "Id_Col";
            this.Id_Col.ReadOnly = true;
            this.Id_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // State
            // 
            this.State.HeaderText = "Статус";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.State.Width = 66;
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarryingBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.JsonRead);
            this.Controls.Add(this.JsonSave);
            this.Controls.Add(this.AddPlane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creatorBox);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Airport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аэропорт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IdInput;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox ScrollBarLable;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox creatorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddPlane;
        private System.Windows.Forms.Button JsonSave;
        private System.Windows.Forms.Button JsonRead;
        private System.Windows.Forms.ErrorProvider IdErr;
        private System.Windows.Forms.NumericUpDown IdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CarryingBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датеПроизводстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ascToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ascToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem descToolStripMenuItem3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarryCol;
        private System.Windows.Forms.DataGridViewButtonColumn CrewCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}

