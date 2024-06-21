namespace Calculator
{
    partial class SalaryDeductions
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
            salaryRetentionInfo = new Label();
            SuspendLayout();
            // 
            // salaryRetentionInfo
            // 
            salaryRetentionInfo.BorderStyle = BorderStyle.FixedSingle;
            salaryRetentionInfo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            salaryRetentionInfo.Location = new Point(12, 9);
            salaryRetentionInfo.Name = "salaryRetentionInfo";
            salaryRetentionInfo.Size = new Size(363, 105);
            salaryRetentionInfo.TabIndex = 0;
            salaryRetentionInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalaryDeductions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 128);
            Controls.Add(salaryRetentionInfo);
            MaximizeBox = false;
            Name = "SalaryDeductions";
            Text = "SalaryDeductions";
            Load += SalaryDeductions_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label salaryRetentionInfo;
    }
}