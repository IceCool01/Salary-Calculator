namespace Calculator
{
    partial class TablBd
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
            dataGridView1 = new DataGridView();
            loadButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 171);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // loadButton
            // 
            loadButton.FlatStyle = FlatStyle.Popup;
            loadButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            loadButton.Location = new Point(26, 204);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(123, 64);
            loadButton.TabIndex = 1;
            loadButton.Text = "Загрузить Б/Д";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            saveButton.Location = new Point(495, 204);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 64);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранить изменения";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // TablBd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 284);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "TablBd";
            Text = "TablBd";
            Load += TablBd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button loadButton;
        private Button saveButton;
        public DataGridView dataGridView1;
    }
}