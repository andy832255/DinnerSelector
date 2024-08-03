namespace DinnerSelector
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
            lblTitle = new Label();
            btnSelectDinner = new Button();
            lblResult = new Label();
            BtnAddDinner = new Button();
            BtnDeleteDinner = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(495, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "今晚食乜餸";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectDinner
            // 
            btnSelectDinner.Location = new Point(186, 107);
            btnSelectDinner.Name = "btnSelectDinner";
            btnSelectDinner.Size = new Size(120, 40);
            btnSelectDinner.TabIndex = 1;
            btnSelectDinner.Text = "今晚吃咩";
            btnSelectDinner.Click += btnSelectDinner_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("微軟正黑體", 28F, FontStyle.Bold);
            lblResult.ForeColor = Color.Crimson;
            lblResult.Location = new Point(100, 173);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(300, 62);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnAddDinner
            // 
            BtnAddDinner.Location = new Point(100, 278);
            BtnAddDinner.Name = "BtnAddDinner";
            BtnAddDinner.Size = new Size(120, 40);
            BtnAddDinner.TabIndex = 3;
            BtnAddDinner.Text = "新增晚餐";
            BtnAddDinner.Click += BtnAddDinner_Click;
            // 
            // BtnDeleteDinner
            // 
            BtnDeleteDinner.Location = new Point(261, 278);
            BtnDeleteDinner.Name = "BtnDeleteDinner";
            BtnDeleteDinner.Size = new Size(120, 40);
            BtnDeleteDinner.TabIndex = 4;
            BtnDeleteDinner.Text = "刪除晚餐";
            BtnDeleteDinner.Click += BtnDeleteDinner_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(495, 354);
            Controls.Add(BtnDeleteDinner);
            Controls.Add(BtnAddDinner);
            Controls.Add(lblTitle);
            Controls.Add(btnSelectDinner);
            Controls.Add(lblResult);
            Name = "Form1";
            Text = "今晚食乜餸";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnSelectDinner;
        private Label lblResult;
        private Button BtnAddDinner;
        private Button BtnDeleteDinner;
    }
}
