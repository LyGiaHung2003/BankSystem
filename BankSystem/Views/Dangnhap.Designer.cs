namespace BankSystem.Views
{
    partial class Dangnhap
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
            txtPassword = new TextBox();
            txtAccount = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ButtonDN = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(805, 547);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(272, 41);
            txtPassword.TabIndex = 2;
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.Location = new Point(805, 476);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(272, 41);
            txtAccount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(623, 541);
            label2.Name = "label2";
            label2.Size = new Size(161, 46);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(606, 468);
            label1.Name = "label1";
            label1.Size = new Size(200, 49);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(805, 386);
            label3.Name = "label3";
            label3.Size = new Size(279, 59);
            label3.TabIndex = 0;
            label3.Text = "Đăng nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonDN
            // 
            ButtonDN.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDN.Location = new Point(805, 611);
            ButtonDN.Name = "ButtonDN";
            ButtonDN.Size = new Size(272, 55);
            ButtonDN.TabIndex = 4;
            ButtonDN.Text = "Đăng nhập";
            ButtonDN.UseVisualStyleBackColor = true;
            ButtonDN.Enter += ButtonDN_Enter;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(1090, 549);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(204, 41);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(checkBox1);
            Controls.Add(ButtonDN);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtAccount;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button ButtonDN;
        private CheckBox checkBox1;
    }
}