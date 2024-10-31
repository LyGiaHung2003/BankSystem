namespace BankSystem.Views
{
    partial class TransactionLog
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
            txtToAcc = new TextBox();
            txtToName = new TextBox();
            txtFromName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            txtEmpId = new TextBox();
            txtId = new TextBox();
            txtFromAcc = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtContent = new TextBox();
            dateTimedate = new DateTimePicker();
            label10 = new Label();
            txtBranch = new TextBox();
            label11 = new Label();
            buttonExport = new Button();
            txtType = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            From_account_id = new DataGridViewTextBoxColumn();
            Fromname = new DataGridViewTextBoxColumn();
            To_account_id = new DataGridViewTextBoxColumn();
            Toname = new DataGridViewTextBoxColumn();
            branch_id = new DataGridViewTextBoxColumn();
            date_of_trans = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            employee_id = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            content = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Viewdata).BeginInit();
            SuspendLayout();
            // 
            // Viewdata
            // 
            Viewdata.AllowUserToAddRows = false;
            Viewdata.AllowUserToDeleteRows = false;
            Viewdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Viewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Viewdata.Columns.AddRange(new DataGridViewColumn[] { Id, From_account_id, Fromname, To_account_id, Toname, branch_id, date_of_trans, Amount, employee_id, Type, content });
            Viewdata.Location = new Point(-1, 308);
            Viewdata.Name = "Viewdata";
            Viewdata.RowHeadersVisible = false;
            Viewdata.RowHeadersWidth = 51;
            Viewdata.RowTemplate.Height = 29;
            Viewdata.Size = new Size(1905, 713);
            Viewdata.TabIndex = 64;
            Viewdata.CellClick += Viewdata_CellClick;
            // 
            // txtToAcc
            // 
            txtToAcc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtToAcc.Location = new Point(782, 171);
            txtToAcc.Name = "txtToAcc";
            txtToAcc.Size = new Size(293, 41);
            txtToAcc.TabIndex = 75;
            // 
            // txtToName
            // 
            txtToName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtToName.Location = new Point(782, 241);
            txtToName.Name = "txtToName";
            txtToName.Size = new Size(293, 41);
            txtToName.TabIndex = 74;
            // 
            // txtFromName
            // 
            txtFromName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtFromName.Location = new Point(782, 99);
            txtFromName.Name = "txtFromName";
            txtFromName.Size = new Size(293, 41);
            txtFromName.TabIndex = 73;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(637, 171);
            label6.Name = "label6";
            label6.Size = new Size(139, 40);
            label6.TabIndex = 82;
            label6.Text = "To Accont";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(247, 244);
            label7.Name = "label7";
            label7.Size = new Size(106, 40);
            label7.TabIndex = 83;
            label7.Text = "Amount";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(645, 241);
            label5.Name = "label5";
            label5.Size = new Size(127, 40);
            label5.TabIndex = 81;
            label5.Text = "To Name";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(359, 243);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(263, 41);
            txtAmount.TabIndex = 76;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(603, 17);
            label2.Name = "label2";
            label2.Size = new Size(173, 60);
            label2.TabIndex = 78;
            label2.Text = "From Account";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmpId
            // 
            txtEmpId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpId.Location = new Point(359, 97);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(153, 41);
            txtEmpId.TabIndex = 72;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ButtonHighlight;
            txtId.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(359, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(153, 41);
            txtId.TabIndex = 70;
            // 
            // txtFromAcc
            // 
            txtFromAcc.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtFromAcc.Location = new Point(782, 27);
            txtFromAcc.Name = "txtFromAcc";
            txtFromAcc.Size = new Size(293, 41);
            txtFromAcc.TabIndex = 71;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 18);
            label1.Name = "label1";
            label1.Size = new Size(176, 60);
            label1.TabIndex = 77;
            label1.Text = "ID Transaction";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(625, 101);
            label4.Name = "label4";
            label4.Size = new Size(147, 40);
            label4.TabIndex = 80;
            label4.Text = "From Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(196, 89);
            label3.Name = "label3";
            label3.Size = new Size(157, 60);
            label3.TabIndex = 79;
            label3.Text = "Employee";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1212, 25);
            label8.Name = "label8";
            label8.Size = new Size(111, 40);
            label8.TabIndex = 85;
            label8.Text = "Content";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(195, 173);
            label9.Name = "label9";
            label9.Size = new Size(169, 40);
            label9.TabIndex = 87;
            label9.Text = "Date Of Trans";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.Location = new Point(1316, 28);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(408, 122);
            txtContent.TabIndex = 86;
            // 
            // dateTimedate
            // 
            dateTimedate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimedate.Format = DateTimePickerFormat.Short;
            dateTimedate.Location = new Point(359, 173);
            dateTimedate.Name = "dateTimedate";
            dateTimedate.Size = new Size(170, 41);
            dateTimedate.TabIndex = 88;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1212, 172);
            label10.Name = "label10";
            label10.Size = new Size(98, 40);
            label10.TabIndex = 89;
            label10.Text = "Branch";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBranch
            // 
            txtBranch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtBranch.Location = new Point(1316, 171);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(408, 41);
            txtBranch.TabIndex = 90;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1109, 241);
            label11.Name = "label11";
            label11.Size = new Size(201, 40);
            label11.TabIndex = 91;
            label11.Text = "Type Transaction";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = SystemColors.ControlLight;
            buttonExport.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExport.Location = new Point(1509, 240);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(113, 41);
            buttonExport.TabIndex = 93;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // txtType
            // 
            txtType.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtType.Location = new Point(1316, 240);
            txtType.Name = "txtType";
            txtType.Size = new Size(164, 41);
            txtType.TabIndex = 94;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.FillWeight = 15F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // From_account_id
            // 
            From_account_id.DataPropertyName = "from_account_id";
            From_account_id.FillWeight = 45F;
            From_account_id.HeaderText = "From Account";
            From_account_id.MinimumWidth = 6;
            From_account_id.Name = "From_account_id";
            // 
            // Fromname
            // 
            Fromname.DataPropertyName = "FromCustomerName";
            Fromname.FillWeight = 50F;
            Fromname.HeaderText = "From Name";
            Fromname.MinimumWidth = 6;
            Fromname.Name = "Fromname";
            // 
            // To_account_id
            // 
            To_account_id.DataPropertyName = "to_account_id";
            To_account_id.FillWeight = 40F;
            To_account_id.HeaderText = "To Account";
            To_account_id.MinimumWidth = 6;
            To_account_id.Name = "To_account_id";
            // 
            // Toname
            // 
            Toname.DataPropertyName = "ToCustomerName";
            Toname.FillWeight = 50F;
            Toname.HeaderText = "To Name";
            Toname.MinimumWidth = 6;
            Toname.Name = "Toname";
            // 
            // branch_id
            // 
            branch_id.DataPropertyName = "branch_id";
            branch_id.HeaderText = "Branch";
            branch_id.MinimumWidth = 6;
            branch_id.Name = "branch_id";
            // 
            // date_of_trans
            // 
            date_of_trans.DataPropertyName = "date_of_trans";
            date_of_trans.FillWeight = 50F;
            date_of_trans.HeaderText = "Date Of Trans";
            date_of_trans.MinimumWidth = 6;
            date_of_trans.Name = "date_of_trans";
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.FillWeight = 80F;
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // employee_id
            // 
            employee_id.DataPropertyName = "employee_id";
            employee_id.FillWeight = 50F;
            employee_id.HeaderText = "Employee";
            employee_id.MinimumWidth = 6;
            employee_id.Name = "employee_id";
            // 
            // Type
            // 
            Type.DataPropertyName = "id_type";
            Type.FillWeight = 50F;
            Type.HeaderText = "Type Transaction";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            // 
            // content
            // 
            content.DataPropertyName = "content";
            content.HeaderText = "content";
            content.MinimumWidth = 6;
            content.Name = "content";
            // 
            // TransactionLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtType);
            Controls.Add(buttonExport);
            Controls.Add(label11);
            Controls.Add(txtBranch);
            Controls.Add(label10);
            Controls.Add(dateTimedate);
            Controls.Add(label9);
            Controls.Add(txtContent);
            Controls.Add(txtToAcc);
            Controls.Add(txtToName);
            Controls.Add(txtFromName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAmount);
            Controls.Add(txtEmpId);
            Controls.Add(txtId);
            Controls.Add(txtFromAcc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Viewdata);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Name = "TransactionLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionLog";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Viewdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView Viewdata;
        private TextBox txtToAcc;
        private TextBox txtToName;
        private TextBox txtFromName;
        private Label label6;
        private Label label7;
        private Label label5;
        private TextBox txtAmount;
        private Label label2;
        private TextBox txtEmpId;
        private TextBox txtId;
        private TextBox txtFromAcc;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label9;
        private TextBox txtContent;
        private DateTimePicker dateTimedate;
        private Label label10;
        private TextBox txtBranch;
        private Label label11;
        private Button buttonExport;
        private TextBox txtType;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn From_account_id;
        private DataGridViewTextBoxColumn Fromname;
        private DataGridViewTextBoxColumn To_account_id;
        private DataGridViewTextBoxColumn Toname;
        private DataGridViewTextBoxColumn branch_id;
        private DataGridViewTextBoxColumn date_of_trans;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn employee_id;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn content;
    }
}