namespace BankSystem.Views
{
    partial class Employee
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
            Viewdata = new DataGridView();
            txtPass = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            radioEmp = new RadioButton();
            radioAdmin = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBoxAdmin = new GroupBox();
            buttonClose = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonSave = new Button();
            groupBoxEmp = new GroupBox();
            button5 = new Button();
            button6 = new Button();
            buttonEdit = new Button();
            label5 = new Label();
            txtStatus = new TextBox();
            checkPass = new CheckBox();
            id_emp = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            role_emp = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            groupBoxAdmin.SuspendLayout();
            groupBoxEmp.SuspendLayout();
            SuspendLayout();
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_emp, Username, EmployeeName, Password, role_emp, Status });
            Viewdata.Location = new Point(2, 86);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.RowTemplate.Height = 29;
            Viewdata.Size = new Size(1905, 836);
            Viewdata.TabIndex = 0;
            Viewdata.CellClick += Viewdata_CellClick;
            Viewdata.DataBindingComplete += Viewdata_DataBindingComplete;
            Viewdata.RowPrePaint += Viewdata_RowPrePaint;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(1138, 28);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(253, 41);
            txtPass.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(712, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 41);
            txtName.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.ButtonHighlight;
            txtUser.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(216, 28);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(231, 41);
            txtUser.TabIndex = 1;
            // 
            // radioEmp
            // 
            radioEmp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radioEmp.Location = new Point(1770, 2);
            radioEmp.Name = "radioEmp";
            radioEmp.Size = new Size(128, 37);
            radioEmp.TabIndex = 4;
            radioEmp.TabStop = true;
            radioEmp.Text = "Employee";
            radioEmp.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            radioAdmin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radioAdmin.Location = new Point(1770, 45);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(128, 35);
            radioAdmin.TabIndex = 5;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Admin";
            radioAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(187, 60);
            label1.TabIndex = 6;
            label1.Text = "User Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(453, 15);
            label2.Name = "label2";
            label2.Size = new Size(265, 60);
            label2.TabIndex = 7;
            label2.Text = "Employee Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(982, 15);
            label3.Name = "label3";
            label3.Size = new Size(160, 60);
            label3.TabIndex = 8;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1652, 15);
            label4.Name = "label4";
            label4.Size = new Size(112, 60);
            label4.TabIndex = 11;
            label4.Text = "Role";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxAdmin
            // 
            groupBoxAdmin.Controls.Add(buttonClose);
            groupBoxAdmin.Controls.Add(buttonClear);
            groupBoxAdmin.Controls.Add(buttonDelete);
            groupBoxAdmin.Controls.Add(buttonSave);
            groupBoxAdmin.Location = new Point(2, 901);
            groupBoxAdmin.Name = "groupBoxAdmin";
            groupBoxAdmin.Size = new Size(1905, 128);
            groupBoxAdmin.TabIndex = 14;
            groupBoxAdmin.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(1276, 38);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(190, 60);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click_1;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(1012, 38);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(190, 60);
            buttonClear.TabIndex = 8;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(741, 38);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 60);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click_1;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(471, 38);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(190, 60);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // groupBoxEmp
            // 
            groupBoxEmp.Controls.Add(button5);
            groupBoxEmp.Controls.Add(button6);
            groupBoxEmp.Controls.Add(buttonEdit);
            groupBoxEmp.Location = new Point(2, 907);
            groupBoxEmp.Name = "groupBoxEmp";
            groupBoxEmp.Size = new Size(1905, 128);
            groupBoxEmp.TabIndex = 15;
            groupBoxEmp.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(1153, 38);
            button5.Name = "button5";
            button5.Size = new Size(190, 60);
            button5.TabIndex = 9;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(905, 38);
            button6.Name = "button6";
            button6.Size = new Size(190, 60);
            button6.TabIndex = 8;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(639, 38);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(190, 60);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1454, 15);
            label5.Name = "label5";
            label5.Size = new Size(117, 60);
            label5.TabIndex = 16;
            label5.Text = "Status";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(1562, 28);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 41);
            txtStatus.TabIndex = 17;
            // 
            // checkPass
            // 
            checkPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkPass.Location = new Point(1408, 35);
            checkPass.Name = "checkPass";
            checkPass.Size = new Size(20, 30);
            checkPass.TabIndex = 18;
            checkPass.UseVisualStyleBackColor = true;
            checkPass.CheckedChanged += checkPass_CheckedChanged;
            // 
            // id_emp
            // 
            id_emp.DataPropertyName = "id";
            id_emp.FillWeight = 15F;
            id_emp.HeaderText = "Id";
            id_emp.MinimumWidth = 6;
            id_emp.Name = "id_emp";
            // 
            // Username
            // 
            Username.DataPropertyName = "user_name";
            Username.FillWeight = 30F;
            Username.HeaderText = "User Name";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // EmployeeName
            // 
            EmployeeName.DataPropertyName = "employee_name";
            EmployeeName.FillWeight = 30F;
            EmployeeName.HeaderText = "EmployeeName";
            EmployeeName.MinimumWidth = 6;
            EmployeeName.Name = "EmployeeName";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // role_emp
            // 
            role_emp.DataPropertyName = "Role";
            role_emp.FillWeight = 15F;
            role_emp.HeaderText = "Role";
            role_emp.MinimumWidth = 6;
            role_emp.Name = "role_emp";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.FillWeight = 15F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(checkPass);
            Controls.Add(txtStatus);
            Controls.Add(Viewdata);
            Controls.Add(label4);
            Controls.Add(radioAdmin);
            Controls.Add(radioEmp);
            Controls.Add(txtUser);
            Controls.Add(txtName);
            Controls.Add(txtPass);
            Controls.Add(groupBoxAdmin);
            Controls.Add(groupBoxEmp);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBoxAdmin.ResumeLayout(false);
            groupBoxEmp.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Viewdata;
        private TextBox txtPass;
        private TextBox txtName;
        private TextBox txtUser;
        private RadioButton radioEmp;
        private RadioButton radioAdmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBoxAdmin;
        private Button buttonClose;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonSave;
        private GroupBox groupBoxEmp;
        private Button button5;
        private Button button6;
        private Button buttonEdit;
        private Label label5;
        private TextBox txtStatus;
        private CheckBox checkPass;
        private DataGridViewTextBoxColumn id_emp;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn role_emp;
        private DataGridViewTextBoxColumn Status;
    }
}