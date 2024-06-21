namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lastName_label = new Label();
            middleName_label = new Label();
            post_label = new Label();
            firstName_label = new Label();
            splitContainer = new SplitContainer();
            tablBd = new Button();
            officialEmployee = new CheckBox();
            label11 = new Label();
            salary = new Button();
            groupBox1 = new GroupBox();
            absence = new TextBox();
            delays = new TextBox();
            workingOnTheWeekend = new TextBox();
            overtime = new TextBox();
            workingDays = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            worker4 = new Button();
            worker3 = new Button();
            worker2 = new Button();
            worker1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            salaryDeductions = new Button();
            button1 = new Button();
            groupBox4 = new GroupBox();
            coefficient1_35 = new Label();
            groupBox3 = new GroupBox();
            coefficient1_2 = new Label();
            groupBox2 = new GroupBox();
            coefficient1_05 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lastName_label
            // 
            lastName_label.BorderStyle = BorderStyle.FixedSingle;
            lastName_label.Location = new Point(160, 71);
            lastName_label.Name = "lastName_label";
            lastName_label.Size = new Size(246, 23);
            lastName_label.TabIndex = 15;
            // 
            // middleName_label
            // 
            middleName_label.BorderStyle = BorderStyle.FixedSingle;
            middleName_label.Location = new Point(159, 102);
            middleName_label.Name = "middleName_label";
            middleName_label.Size = new Size(246, 23);
            middleName_label.TabIndex = 16;
            middleName_label.Click += label13_Click;
            // 
            // post_label
            // 
            post_label.BorderStyle = BorderStyle.FixedSingle;
            post_label.Location = new Point(159, 131);
            post_label.Name = "post_label";
            post_label.Size = new Size(246, 23);
            post_label.TabIndex = 17;
            // 
            // firstName_label
            // 
            firstName_label.BorderStyle = BorderStyle.FixedSingle;
            firstName_label.Location = new Point(159, 42);
            firstName_label.Name = "firstName_label";
            firstName_label.Size = new Size(246, 23);
            firstName_label.TabIndex = 14;
            firstName_label.Tag = "";
            // 
            // splitContainer
            // 
            splitContainer.BackColor = SystemColors.ButtonHighlight;
            splitContainer.BorderStyle = BorderStyle.Fixed3D;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(tablBd);
            splitContainer.Panel1.Controls.Add(officialEmployee);
            splitContainer.Panel1.Controls.Add(label11);
            splitContainer.Panel1.Controls.Add(post_label);
            splitContainer.Panel1.Controls.Add(middleName_label);
            splitContainer.Panel1.Controls.Add(lastName_label);
            splitContainer.Panel1.Controls.Add(firstName_label);
            splitContainer.Panel1.Controls.Add(salary);
            splitContainer.Panel1.Controls.Add(groupBox1);
            splitContainer.Panel1.Controls.Add(worker4);
            splitContainer.Panel1.Controls.Add(worker3);
            splitContainer.Panel1.Controls.Add(worker2);
            splitContainer.Panel1.Controls.Add(worker1);
            splitContainer.Panel1.Controls.Add(label5);
            splitContainer.Panel1.Controls.Add(label4);
            splitContainer.Panel1.Controls.Add(label3);
            splitContainer.Panel1.Controls.Add(label2);
            splitContainer.Panel1.Controls.Add(label1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(salaryDeductions);
            splitContainer.Panel2.Controls.Add(button1);
            splitContainer.Panel2.Controls.Add(groupBox4);
            splitContainer.Panel2.Controls.Add(groupBox3);
            splitContainer.Panel2.Controls.Add(groupBox2);
            splitContainer.Size = new Size(784, 461);
            splitContainer.SplitterDistance = 413;
            splitContainer.TabIndex = 0;
            // 
            // tablBd
            // 
            tablBd.FlatStyle = FlatStyle.Popup;
            tablBd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            tablBd.Location = new Point(273, 395);
            tablBd.Name = "tablBd";
            tablBd.Size = new Size(126, 52);
            tablBd.TabIndex = 20;
            tablBd.Text = "Таблица Б/Д";
            tablBd.UseVisualStyleBackColor = true;
            tablBd.Click += button2_Click;
            // 
            // officialEmployee
            // 
            officialEmployee.Location = new Point(337, 167);
            officialEmployee.Name = "officialEmployee";
            officialEmployee.RightToLeft = RightToLeft.Yes;
            officialEmployee.Size = new Size(63, 24);
            officialEmployee.TabIndex = 19;
            officialEmployee.UseVisualStyleBackColor = true;
            officialEmployee.CheckedChanged += officialEmployee_CheckedChanged;
            // 
            // label11
            // 
            label11.Location = new Point(10, 163);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(294, 23);
            label11.TabIndex = 18;
            label11.Text = "Сотрудник официально трудоустроен";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salary
            // 
            salary.FlatStyle = FlatStyle.Popup;
            salary.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            salary.Location = new Point(10, 395);
            salary.Name = "salary";
            salary.Size = new Size(126, 52);
            salary.TabIndex = 13;
            salary.Text = "Расчитать З/П";
            salary.UseVisualStyleBackColor = true;
            salary.Click += salary_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(absence);
            groupBox1.Controls.Add(delays);
            groupBox1.Controls.Add(workingOnTheWeekend);
            groupBox1.Controls.Add(overtime);
            groupBox1.Controls.Add(workingDays);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(10, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 185);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Переработки/Нарушения";
            // 
            // absence
            // 
            absence.BorderStyle = BorderStyle.FixedSingle;
            absence.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            absence.Location = new Point(263, 147);
            absence.Name = "absence";
            absence.Size = new Size(127, 25);
            absence.TabIndex = 9;
            absence.Text = "0";
            // 
            // delays
            // 
            delays.BorderStyle = BorderStyle.FixedSingle;
            delays.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            delays.Location = new Point(263, 116);
            delays.Name = "delays";
            delays.Size = new Size(127, 25);
            delays.TabIndex = 8;
            delays.Text = "0";
            // 
            // workingOnTheWeekend
            // 
            workingOnTheWeekend.BorderStyle = BorderStyle.FixedSingle;
            workingOnTheWeekend.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            workingOnTheWeekend.Location = new Point(263, 85);
            workingOnTheWeekend.Name = "workingOnTheWeekend";
            workingOnTheWeekend.Size = new Size(127, 25);
            workingOnTheWeekend.TabIndex = 7;
            workingOnTheWeekend.Text = "0";
            // 
            // overtime
            // 
            overtime.BorderStyle = BorderStyle.FixedSingle;
            overtime.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            overtime.Location = new Point(263, 54);
            overtime.Name = "overtime";
            overtime.Size = new Size(127, 25);
            overtime.TabIndex = 6;
            overtime.Text = "0";
            // 
            // workingDays
            // 
            workingDays.BorderStyle = BorderStyle.FixedSingle;
            workingDays.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            workingDays.Location = new Point(263, 23);
            workingDays.Name = "workingDays";
            workingDays.Size = new Size(127, 25);
            workingDays.TabIndex = 5;
            workingDays.Text = "0";
            workingDays.TextChanged += workingDays_TextChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(6, 155);
            label10.Name = "label10";
            label10.Size = new Size(157, 17);
            label10.TabIndex = 4;
            label10.Text = "Пропуск рабочих дней";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(6, 124);
            label9.Name = "label9";
            label9.Size = new Size(157, 17);
            label9.TabIndex = 3;
            label9.Text = "Количество опозданий";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(6, 93);
            label8.Name = "label8";
            label8.Size = new Size(157, 17);
            label8.TabIndex = 2;
            label8.Text = "Выходы в выходной";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(6, 62);
            label7.Name = "label7";
            label7.Size = new Size(157, 17);
            label7.TabIndex = 1;
            label7.Text = "Количество доп. часов\r\n";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(143, 17);
            label6.TabIndex = 0;
            label6.Text = "Рабочие дни в месяце";
            // 
            // worker4
            // 
            worker4.FlatStyle = FlatStyle.System;
            worker4.Location = new Point(348, 16);
            worker4.Name = "worker4";
            worker4.Size = new Size(57, 23);
            worker4.TabIndex = 11;
            worker4.Text = "4";
            worker4.UseVisualStyleBackColor = true;
            worker4.Click += worker4_Click;
            // 
            // worker3
            // 
            worker3.FlatStyle = FlatStyle.System;
            worker3.Location = new Point(285, 16);
            worker3.Name = "worker3";
            worker3.Size = new Size(57, 23);
            worker3.TabIndex = 10;
            worker3.Text = "3";
            worker3.UseVisualStyleBackColor = true;
            worker3.Click += worker3_Click;
            // 
            // worker2
            // 
            worker2.FlatStyle = FlatStyle.System;
            worker2.Location = new Point(222, 16);
            worker2.Name = "worker2";
            worker2.Size = new Size(57, 23);
            worker2.TabIndex = 9;
            worker2.Text = "2";
            worker2.UseVisualStyleBackColor = true;
            worker2.Click += worker2_Click;
            // 
            // worker1
            // 
            worker1.FlatStyle = FlatStyle.System;
            worker1.Location = new Point(159, 16);
            worker1.Name = "worker1";
            worker1.Size = new Size(57, 23);
            worker1.TabIndex = 8;
            worker1.Text = "1";
            worker1.UseVisualStyleBackColor = true;
            worker1.Click += worker1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 139);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "Должность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 110);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 79);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 50);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер сотрудника";
            // 
            // salaryDeductions
            // 
            salaryDeductions.FlatStyle = FlatStyle.Popup;
            salaryDeductions.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            salaryDeductions.Location = new Point(227, 395);
            salaryDeductions.Name = "salaryDeductions";
            salaryDeductions.Size = new Size(126, 52);
            salaryDeductions.TabIndex = 4;
            salaryDeductions.Text = "Удержание З/П";
            salaryDeductions.UseVisualStyleBackColor = true;
            salaryDeductions.Click += salaryDeductions_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button1.Location = new Point(9, 395);
            button1.Name = "button1";
            button1.Size = new Size(126, 52);
            button1.TabIndex = 3;
            button1.Text = "Отчистить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImageLayout = ImageLayout.None;
            groupBox4.Controls.Add(coefficient1_35);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(3, 256);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(357, 100);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Коэфицент  1,35";
            // 
            // coefficient1_35
            // 
            coefficient1_35.Anchor = AnchorStyles.None;
            coefficient1_35.BorderStyle = BorderStyle.FixedSingle;
            coefficient1_35.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            coefficient1_35.Location = new Point(6, 22);
            coefficient1_35.Name = "coefficient1_35";
            coefficient1_35.Size = new Size(344, 34);
            coefficient1_35.TabIndex = 3;
            coefficient1_35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImageLayout = ImageLayout.None;
            groupBox3.Controls.Add(coefficient1_2);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(3, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(357, 100);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Коэфицент  1,2";
            // 
            // coefficient1_2
            // 
            coefficient1_2.Anchor = AnchorStyles.None;
            coefficient1_2.BorderStyle = BorderStyle.FixedSingle;
            coefficient1_2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            coefficient1_2.Location = new Point(0, 21);
            coefficient1_2.Name = "coefficient1_2";
            coefficient1_2.Size = new Size(344, 34);
            coefficient1_2.TabIndex = 1;
            coefficient1_2.TextAlign = ContentAlignment.MiddleCenter;
            coefficient1_2.Click += label11_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(coefficient1_05);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(3, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Коэфицент  1,05";
            // 
            // coefficient1_05
            // 
            coefficient1_05.Anchor = AnchorStyles.None;
            coefficient1_05.BorderStyle = BorderStyle.FixedSingle;
            coefficient1_05.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coefficient1_05.Location = new Point(6, 21);
            coefficient1_05.Name = "coefficient1_05";
            coefficient1_05.Size = new Size(344, 34);
            coefficient1_05.TabIndex = 0;
            coefficient1_05.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button worker1;
        private Button worker4;
        private Button worker3;
        private Button worker2;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button salary;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        internal Label firstName_label;
        internal Label lastName_label;
        internal Label middleName_label;
        internal Label post_label;
        public TextBox workingDays;
        public TextBox overtime;
        public TextBox delays;
        public TextBox workingOnTheWeekend;
        public TextBox absence;
        private Button button1;
        public Label coefficient1_05;
        public Label coefficient1_35;
        public Label coefficient1_2;
        private Label label11;
        private CheckBox officialEmployee;
        private Button salaryDeductions;
        private Button tablBd;
    }
}
