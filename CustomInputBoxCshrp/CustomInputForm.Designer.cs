namespace CustomInputBoxCshrp
{
    partial class CustomInputForm
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
            tlpMain = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancel = new Button();
            btnOK = new Button();
            txtInput = new TextBox();
            lblTitle = new Label();
            lblPrompt = new Label();
            tlpMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Controls.Add(tableLayoutPanel1, 0, 3);
            tlpMain.Controls.Add(txtInput, 0, 2);
            tlpMain.Controls.Add(lblTitle, 0, 0);
            tlpMain.Controls.Add(lblPrompt, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 41.6666679F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tlpMain.Size = new Size(507, 246);
            tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.42857F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel1.Controls.Add(btnOK, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 196);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(501, 47);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(360, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 41);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Fill;
            btnOK.Location = new Point(431, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(67, 41);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Dock = DockStyle.Fill;
            txtInput.Location = new Point(3, 145);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(501, 23);
            txtInput.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(501, 40);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "lblTitle";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Dock = DockStyle.Fill;
            lblPrompt.Location = new Point(3, 40);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(501, 102);
            lblPrompt.TabIndex = 3;
            lblPrompt.Text = "lblPrompt";
            lblPrompt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 246);
            Controls.Add(tlpMain);
            Name = "CustomInputForm";
            Text = "Form1";
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCancel;
        private Button btnOK;
        private TextBox txtInput;
        private Label lblTitle;
        private Label lblPrompt;
    }
}