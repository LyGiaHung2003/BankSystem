namespace BankSystem.Views
{
    partial class Transaction
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textFromAccount = new TextBox();
            textFromName = new TextBox();
            textToAccount = new TextBox();
            textToName = new TextBox();
            textAmount = new TextBox();
            textContent = new TextBox();
            textPin = new TextBox();
            buttonSend = new Button();
            buttonClear = new Button();
            buttonClose = new Button();
            comboBranch = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(488, 288);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 0;
            label1.Text = "From Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(510, 364);
            label2.Name = "label2";
            label2.Size = new Size(142, 34);
            label2.TabIndex = 1;
            label2.Text = "To Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(941, 290);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 2;
            label3.Text = "From Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(961, 362);
            label4.Name = "label4";
            label4.Size = new Size(122, 35);
            label4.TabIndex = 3;
            label4.Text = "To Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(550, 484);
            label5.Name = "label5";
            label5.Size = new Size(102, 36);
            label5.TabIndex = 4;
            label5.Text = "Branch";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(510, 423);
            label6.Name = "label6";
            label6.Size = new Size(142, 36);
            label6.TabIndex = 5;
            label6.Text = "Amount";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(541, 544);
            label7.Name = "label7";
            label7.Size = new Size(111, 35);
            label7.TabIndex = 6;
            label7.Text = "Content";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1001, 423);
            label8.Name = "label8";
            label8.Size = new Size(82, 40);
            label8.TabIndex = 7;
            label8.Text = "Pin";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textFromAccount
            // 
            textFromAccount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textFromAccount.Location = new Point(658, 288);
            textFromAccount.Name = "textFromAccount";
            textFromAccount.Size = new Size(277, 41);
            textFromAccount.TabIndex = 1;
            textFromAccount.TextChanged += textFromAccount_TextChanged;
            // 
            // textFromName
            // 
            textFromName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textFromName.Location = new Point(1089, 286);
            textFromName.Name = "textFromName";
            textFromName.Size = new Size(277, 41);
            textFromName.TabIndex = 2;
            // 
            // textToAccount
            // 
            textToAccount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textToAccount.Location = new Point(658, 359);
            textToAccount.Name = "textToAccount";
            textToAccount.Size = new Size(277, 41);
            textToAccount.TabIndex = 3;
            textToAccount.TextChanged += textToAccount_TextChanged;
            // 
            // textToName
            // 
            textToName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textToName.Location = new Point(1089, 356);
            textToName.Name = "textToName";
            textToName.Size = new Size(277, 41);
            textToName.TabIndex = 4;
            // 
            // textAmount
            // 
            textAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textAmount.Location = new Point(658, 423);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(277, 41);
            textAmount.TabIndex = 5;
            textAmount.Leave += textAmount_Leave;
            textAmount.Validating += textAmount_Validating;
            // 
            // textContent
            // 
            textContent.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textContent.Location = new Point(658, 544);
            textContent.Name = "textContent";
            textContent.Size = new Size(708, 41);
            textContent.TabIndex = 8;
            // 
            // textPin
            // 
            textPin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textPin.Location = new Point(1089, 423);
            textPin.Name = "textPin";
            textPin.Size = new Size(277, 41);
            textPin.TabIndex = 6;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Location = new Point(720, 623);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(158, 62);
            buttonSend.TabIndex = 16;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(934, 623);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(158, 62);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(1151, 623);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(158, 62);
            buttonClose.TabIndex = 18;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // comboBranch
            // 
            comboBranch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBranch.FormattingEnabled = true;
            comboBranch.Location = new Point(658, 484);
            comboBranch.Name = "comboBranch";
            comboBranch.Size = new Size(708, 43);
            comboBranch.TabIndex = 7;
            comboBranch.SelectedIndexChanged += comboBranch_SelectedIndexChanged;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(comboBranch);
            Controls.Add(buttonClose);
            Controls.Add(buttonClear);
            Controls.Add(buttonSend);
            Controls.Add(textPin);
            Controls.Add(textContent);
            Controls.Add(textAmount);
            Controls.Add(textToName);
            Controls.Add(textToAccount);
            Controls.Add(textFromName);
            Controls.Add(textFromAccount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textFromAccount;
        private TextBox textFromName;
        private TextBox textToAccount;
        private TextBox textToName;
        private TextBox textAmount;
        private TextBox textContent;
        private TextBox textPin;
        private Button buttonSend;
        private Button buttonClear;
        private Button buttonClose;
        private ComboBox comboBranch;
    }
}