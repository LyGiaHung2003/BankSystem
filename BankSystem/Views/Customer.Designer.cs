namespace BankSystem.Views
{
    partial class Customer
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
            txtCity = new TextBox();
            txtHouse = new TextBox();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            buttonClear = new Button();
            buttonClose = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtPin = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            txtId = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            Viewdata = new DataGridView();
            Id_Cus = new DataGridViewTextBoxColumn();
            NumberAccount = new DataGridViewTextBoxColumn();
            CusName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            House_no = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Pin = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(768, 81);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(221, 41);
            txtCity.TabIndex = 5;
            // 
            // txtHouse
            // 
            txtHouse.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouse.Location = new Point(1156, 81);
            txtHouse.Name = "txtHouse";
            txtHouse.Size = new Size(564, 41);
            txtHouse.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(1156, 11);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(345, 41);
            txtEmail.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonClose);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Location = new Point(-1, 902);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1905, 128);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(1032, 44);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(190, 60);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(1293, 44);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(190, 60);
            buttonClose.TabIndex = 10;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(769, 44);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 60);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(499, 44);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(190, 60);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Edit";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(704, 82);
            label6.Name = "label6";
            label6.Size = new Size(58, 40);
            label6.TabIndex = 44;
            label6.Text = "City";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1534, 12);
            label7.Name = "label7";
            label7.Size = new Size(58, 40);
            label7.TabIndex = 46;
            label7.Text = "Pin";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1019, 81);
            label5.Name = "label5";
            label5.Size = new Size(127, 40);
            label5.TabIndex = 42;
            label5.Text = "House_no";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPin
            // 
            txtPin.BackColor = SystemColors.ButtonHighlight;
            txtPin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPin.Location = new Point(1598, 12);
            txtPin.Name = "txtPin";
            txtPin.ReadOnly = true;
            txtPin.Size = new Size(122, 41);
            txtPin.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(565, 2);
            label2.Name = "label2";
            label2.Size = new Size(197, 60);
            label2.TabIndex = 37;
            label2.Text = "Name Customer";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(332, 81);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 41);
            txtPhone.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(332, 11);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(227, 41);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(768, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 41);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(133, 2);
            label1.Name = "label1";
            label1.Size = new Size(204, 60);
            label1.TabIndex = 36;
            label1.Text = "NumberAccount";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1070, 13);
            label4.Name = "label4";
            label4.Size = new Size(76, 40);
            label4.TabIndex = 39;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(249, 71);
            label3.Name = "label3";
            label3.Size = new Size(88, 60);
            label3.TabIndex = 38;
            label3.Text = "Phone";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { Id_Cus, NumberAccount, CusName, Phone, Email, House_no, City, Pin });
            Viewdata.Location = new Point(-1, 137);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.RowTemplate.Height = 29;
            Viewdata.Size = new Size(1905, 774);
            Viewdata.TabIndex = 32;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // Id_Cus
            // 
            Id_Cus.DataPropertyName = "id";
            Id_Cus.FillWeight = 15F;
            Id_Cus.HeaderText = "ID";
            Id_Cus.MinimumWidth = 6;
            Id_Cus.Name = "Id_Cus";
            // 
            // NumberAccount
            // 
            NumberAccount.DataPropertyName = "cus_id";
            NumberAccount.FillWeight = 50F;
            NumberAccount.HeaderText = "Number Account";
            NumberAccount.MinimumWidth = 6;
            NumberAccount.Name = "NumberAccount";
            // 
            // CusName
            // 
            CusName.DataPropertyName = "Name";
            CusName.FillWeight = 50F;
            CusName.HeaderText = "Name Customer";
            CusName.MinimumWidth = 6;
            CusName.Name = "CusName";
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.FillWeight = 30F;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // House_no
            // 
            House_no.DataPropertyName = "House_no";
            House_no.HeaderText = "House_no";
            House_no.MinimumWidth = 6;
            House_no.Name = "House_no";
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            // 
            // Pin
            // 
            Pin.DataPropertyName = "Pin";
            Pin.HeaderText = "Pin";
            Pin.MinimumWidth = 6;
            Pin.Name = "Pin";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtCity);
            Controls.Add(txtHouse);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtPin);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(Viewdata);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customer";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private TextBox txtHouse;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private Button buttonClose;
        private Button buttonDelete;
        private Button buttonSave;
        private Label label6;
        private Label label7;
        private Label label5;
        private TextBox txtPin;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtId;
        private TextBox txtName;
        private Label label1;
        private Label label4;
        private Label label3;
        private DataGridView Viewdata;
        private Button buttonClear;
        private DataGridViewTextBoxColumn Id_Cus;
        private DataGridViewTextBoxColumn NumberAccount;
        private DataGridViewTextBoxColumn CusName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn House_no;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Pin;
    }
}