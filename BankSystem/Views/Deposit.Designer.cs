namespace BankSystem.Views
{
    partial class Deposit
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
            comboBranch = new ComboBox();
            buttonClose = new Button();
            buttonClear = new Button();
            buttonSend = new Button();
            textPin = new TextBox();
            textContent = new TextBox();
            textAmount = new TextBox();
            textFromName = new TextBox();
            textFromAccount = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBranch
            // 
            comboBranch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBranch.FormattingEnabled = true;
            comboBranch.Location = new Point(742, 478);
            comboBranch.Name = "comboBranch";
            comboBranch.Size = new Size(589, 43);
            comboBranch.TabIndex = 5;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(1173, 630);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(158, 62);
            buttonClose.TabIndex = 52;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(956, 630);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(158, 62);
            buttonClear.TabIndex = 51;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Location = new Point(742, 630);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(158, 62);
            buttonSend.TabIndex = 50;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textPin
            // 
            textPin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textPin.Location = new Point(742, 408);
            textPin.Name = "textPin";
            textPin.Size = new Size(211, 41);
            textPin.TabIndex = 3;
            // 
            // textContent
            // 
            textContent.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textContent.Location = new Point(742, 536);
            textContent.Name = "textContent";
            textContent.Size = new Size(589, 41);
            textContent.TabIndex = 6;
            // 
            // textAmount
            // 
            textAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textAmount.Location = new Point(1120, 408);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(211, 41);
            textAmount.TabIndex = 4;
            textAmount.Leave += textAmount_Leave;
            textAmount.Validating += textAmount_Validating;
            // 
            // textFromName
            // 
            textFromName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textFromName.Location = new Point(1120, 341);
            textFromName.Name = "textFromName";
            textFromName.Size = new Size(211, 41);
            textFromName.TabIndex = 2;
            // 
            // textFromAccount
            // 
            textFromAccount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textFromAccount.Location = new Point(742, 341);
            textFromAccount.Name = "textFromAccount";
            textFromAccount.Size = new Size(211, 41);
            textFromAccount.TabIndex = 1;
            textFromAccount.TextChanged += textFromAccount_TextChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(654, 408);
            label8.Name = "label8";
            label8.Size = new Size(82, 40);
            label8.TabIndex = 47;
            label8.Text = "Pin";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(625, 536);
            label7.Name = "label7";
            label7.Size = new Size(111, 35);
            label7.TabIndex = 46;
            label7.Text = "Content";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(972, 408);
            label6.Name = "label6";
            label6.Size = new Size(142, 36);
            label6.TabIndex = 43;
            label6.Text = "Amount";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(634, 478);
            label5.Name = "label5";
            label5.Size = new Size(102, 36);
            label5.TabIndex = 42;
            label5.Text = "Branch";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(572, 341);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 38;
            label1.Text = "From Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(972, 345);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 41;
            label3.Text = "From Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Deposit
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
            Controls.Add(textFromName);
            Controls.Add(textFromAccount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBranch;
        private Button buttonClose;
        private Button buttonClear;
        private Button buttonSend;
        private TextBox textPin;
        private TextBox textContent;
        private TextBox textAmount;
        private TextBox textFromName;
        private TextBox textFromAccount;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label3;
    }
}