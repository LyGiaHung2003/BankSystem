namespace BankSystem.Views
{
    partial class Branch
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
            buttonClear = new Button();
            buttonAdd = new Button();
            label4 = new Label();
            buttonDelete = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonClose = new Button();
            txtAddress = new TextBox();
            Viewdata = new DataGridView();
            txtCity = new TextBox();
            txtStatus = new TextBox();
            label5 = new Label();
            id_br = new DataGridViewTextBoxColumn();
            BranchID = new DataGridViewTextBoxColumn();
            BranchName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(1048, 37);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(190, 60);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(503, 37);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(190, 60);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Save";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1460, 9);
            label4.Name = "label4";
            label4.Size = new Size(83, 60);
            label4.TabIndex = 23;
            label4.Text = "City";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(781, 37);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 60);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(190, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(129, 41);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(550, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(434, 41);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(990, 9);
            label3.Name = "label3";
            label3.Size = new Size(142, 60);
            label3.TabIndex = 22;
            label3.Text = "Address";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(325, 9);
            label2.Name = "label2";
            label2.Size = new Size(239, 60);
            label2.TabIndex = 21;
            label2.Text = "Branch Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 60);
            label1.TabIndex = 20;
            label1.Text = "Branch ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClose);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Location = new Point(-1, 906);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1905, 128);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(1312, 37);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(190, 60);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(1122, 22);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(332, 41);
            txtAddress.TabIndex = 3;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_br, BranchID, BranchName, Address, City, Status });
            Viewdata.Location = new Point(-1, 80);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.RowTemplate.Height = 29;
            Viewdata.Size = new Size(1905, 835);
            Viewdata.TabIndex = 14;
            Viewdata.CellClick += Viewdata_CellClick_1;
            Viewdata.RowPrePaint += Viewdata_RowPrePaint;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(1536, 22);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(152, 41);
            txtCity.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(1786, 22);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(109, 41);
            txtStatus.TabIndex = 25;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1680, 9);
            label5.Name = "label5";
            label5.Size = new Size(114, 60);
            label5.TabIndex = 26;
            label5.Text = "Status";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // id_br
            // 
            id_br.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_br.DataPropertyName = "id";
            id_br.FillWeight = 15F;
            id_br.HeaderText = "ID";
            id_br.MinimumWidth = 6;
            id_br.Name = "id_br";
            // 
            // BranchID
            // 
            BranchID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BranchID.DataPropertyName = "Branch_id";
            BranchID.FillWeight = 23F;
            BranchID.HeaderText = "Branch ID";
            BranchID.MinimumWidth = 6;
            BranchID.Name = "BranchID";
            // 
            // BranchName
            // 
            BranchName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BranchName.DataPropertyName = "Name";
            BranchName.HeaderText = "Branch Name";
            BranchName.MinimumWidth = 6;
            BranchName.Name = "BranchName";
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Address.DataPropertyName = "House_no";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // City
            // 
            City.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            City.DataPropertyName = "City";
            City.FillWeight = 15F;
            City.HeaderText = "City";
            City.MinimumWidth = 6;
            City.Name = "City";
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "status";
            Status.FillWeight = 15F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // Branch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtName);
            Controls.Add(txtStatus);
            Controls.Add(txtCity);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(Viewdata);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "Branch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Branch";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClear;
        private Button buttonAdd;
        private Label label4;
        private Button buttonDelete;
        private TextBox txtID;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAddress;
        private DataGridView Viewdata;
        private TextBox txtCity;
        private Button buttonClose;
        private TextBox txtStatus;
        private Label label5;
        private DataGridViewTextBoxColumn id_br;
        private DataGridViewTextBoxColumn BranchID;
        private DataGridViewTextBoxColumn BranchName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Status;
    }
}