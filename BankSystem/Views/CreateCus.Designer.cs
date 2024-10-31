namespace BankSystem.Views
{
    partial class CreateCus
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtHouse = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(755, 527);
            label4.Name = "label4";
            label4.Size = new Size(76, 40);
            label4.TabIndex = 23;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(743, 447);
            label3.Name = "label3";
            label3.Size = new Size(88, 60);
            label3.TabIndex = 22;
            label3.Text = "Phone";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(634, 368);
            label2.Name = "label2";
            label2.Size = new Size(197, 60);
            label2.TabIndex = 21;
            label2.Text = "Name Customer";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(837, 457);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(214, 41);
            txtPhone.TabIndex = 2;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(837, 377);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 41);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(839, 527);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 41);
            txtEmail.TabIndex = 3;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtHouse
            // 
            txtHouse.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouse.Location = new Point(839, 600);
            txtHouse.Name = "txtHouse";
            txtHouse.Size = new Size(212, 41);
            txtHouse.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(704, 601);
            label5.Name = "label5";
            label5.Size = new Size(127, 40);
            label5.TabIndex = 26;
            label5.Text = "House_no";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(839, 681);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(212, 41);
            txtCity.TabIndex = 5;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(773, 682);
            label6.Name = "label6";
            label6.Size = new Size(58, 40);
            label6.TabIndex = 28;
            label6.Text = "City";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(713, 290);
            label1.Name = "label1";
            label1.Size = new Size(444, 78);
            label1.TabIndex = 30;
            label1.Text = "Insert Info Customer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(713, 748);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(190, 60);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(950, 748);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(190, 60);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // CreateCus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonClose);
            Controls.Add(label1);
            Controls.Add(txtCity);
            Controls.Add(buttonSave);
            Controls.Add(txtHouse);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "CreateCus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCus";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtHouse;
        private Label label5;
        private TextBox txtCity;
        private Label label6;
        private Label label1;
        private Button buttonSave;
        private Button buttonClose;
    }
}