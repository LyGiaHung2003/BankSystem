namespace BankSystem.Views
{
    partial class BalanceAccount
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
            label2 = new Label();
            txtCustomerid = new TextBox();
            label3 = new Label();
            buttonClear = new Button();
            buttonClose = new Button();
            buttonDelete = new Button();
            Viewdata = new DataGridView();
            id_acc = new DataGridViewTextBoxColumn();
            customerid = new DataGridViewTextBoxColumn();
            date_opend = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            buttonSave = new Button();
            label4 = new Label();
            txtBalance = new TextBox();
            dateTimeDate = new DateTimePicker();
            label5 = new Label();
            txtStatus = new TextBox();
            buttonExport = new Button();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(111, 3);
            label2.Name = "label2";
            label2.Size = new Size(157, 60);
            label2.TabIndex = 56;
            label2.Text = "Customer ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCustomerid
            // 
            txtCustomerid.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerid.Location = new Point(274, 13);
            txtCustomerid.Name = "txtCustomerid";
            txtCustomerid.Size = new Size(187, 41);
            txtCustomerid.TabIndex = 48;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(573, 3);
            label3.Name = "label3";
            label3.Size = new Size(153, 60);
            label3.TabIndex = 57;
            label3.Text = "Date Opend";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(997, 43);
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
            buttonClose.Location = new Point(1258, 43);
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
            buttonDelete.Location = new Point(734, 43);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 60);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { id_acc, customerid, date_opend, Balance, Status });
            Viewdata.Location = new Point(-1, 68);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.RowTemplate.Height = 29;
            Viewdata.Size = new Size(1905, 843);
            Viewdata.TabIndex = 54;
            Viewdata.CellClick += Viewdata_CellClick;
            Viewdata.RowPrePaint += Viewdata_RowPrePaint;
            // 
            // id_acc
            // 
            id_acc.DataPropertyName = "id";
            id_acc.HeaderText = "ID";
            id_acc.MinimumWidth = 6;
            id_acc.Name = "id_acc";
            // 
            // customerid
            // 
            customerid.DataPropertyName = "customer_id";
            customerid.HeaderText = "Customer ID";
            customerid.MinimumWidth = 6;
            customerid.Name = "customerid";
            // 
            // date_opend
            // 
            date_opend.DataPropertyName = "date_opend";
            date_opend.HeaderText = "Date Opend";
            date_opend.MinimumWidth = 6;
            date_opend.Name = "date_opend";
            // 
            // Balance
            // 
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonClose);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Location = new Point(-1, 902);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1905, 128);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(467, 43);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(190, 60);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(976, 15);
            label4.Name = "label4";
            label4.Size = new Size(101, 40);
            label4.TabIndex = 58;
            label4.Text = "Balance";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBalance.Location = new Point(1083, 14);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(311, 41);
            txtBalance.TabIndex = 50;
            txtBalance.Leave += txtBalance_Leave;
            txtBalance.Validating += txtBalance_Validating;
            // 
            // dateTimeDate
            // 
            dateTimeDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeDate.Format = DateTimePickerFormat.Short;
            dateTimeDate.Location = new Point(732, 12);
            dateTimeDate.Name = "dateTimeDate";
            dateTimeDate.Size = new Size(155, 41);
            dateTimeDate.TabIndex = 60;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1458, 15);
            label5.Name = "label5";
            label5.Size = new Size(101, 40);
            label5.TabIndex = 61;
            label5.Text = "Status";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(1550, 15);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 41);
            txtStatus.TabIndex = 62;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ControlLight;
            buttonExport.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExport.Location = new Point(1692, 14);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(113, 41);
            buttonExport.TabIndex = 94;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // BalanceAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonExport);
            Controls.Add(txtStatus);
            Controls.Add(label5);
            Controls.Add(dateTimeDate);
            Controls.Add(txtBalance);
            Controls.Add(label2);
            Controls.Add(txtCustomerid);
            Controls.Add(label4);
            Controls.Add(Viewdata);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "BalanceAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BalanceAccount";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtCustomerid;
        private Label label3;
        private Button buttonClear;
        private Button buttonClose;
        private Button buttonDelete;
        private DataGridView Viewdata;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtBalance;
        private DateTimePicker dateTimeDate;
        private Label label5;
        private TextBox txtStatus;
        private Button buttonSave;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn id_acc;
        private DataGridViewTextBoxColumn customerid;
        private DataGridViewTextBoxColumn date_opend;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn Status;
        private Button buttonExport;
    }
}