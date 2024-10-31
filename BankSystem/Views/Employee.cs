using BankSystem.Controllers;
using System.Data;
using System.Net;
using System.Windows.Forms;
using BankSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace BankSystem.Views
{
    public partial class Employee : Form, IView
    {
        private string role;
        private string rolecheck;
        private int emp_id;
        private int selectedRowIndex = -1;
        EmployeeController emp = new EmployeeController();
        EmployeeModel em = new EmployeeModel();
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public Employee(string userRole)
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
            role = userRole;
            if (role == "Admin")
            {
                groupBoxAdmin.Visible = true;
                groupBoxEmp.Visible = false;
            }
            else if (role == "Employee")
            {
                groupBoxAdmin.Visible = false;
                groupBoxEmp.Visible = false;
            }
            Viewdata.DataBindingComplete += Viewdata_DataBindingComplete;
            Showdata();
        }
        private void Showdata()
        {
            try
            {
                emp.Load();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("User_Name", typeof(string));
                dataTable.Columns.Add("Employee_Name", typeof(string));
                dataTable.Columns.Add("Password", typeof(string));
                dataTable.Columns.Add("Role", typeof(string));
                dataTable.Columns.Add("Status", typeof(string));

                foreach (EmployeeModel employee in emp.Items)
                {
                    dataTable.Rows.Add(employee.Id, employee.User_Name, employee.Name, employee.Password, employee.Role, employee.Status);
                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
        }
        private void Viewdata_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = Viewdata.Rows[e.RowIndex];
            if (row.Cells["Status"].Value != null && row.Cells["Status"].Value.ToString() == "Block")
            {
                row.DefaultCellStyle.BackColor = Color.Gainsboro;
            }
        }
        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];
                emp_id = int.Parse(row.Cells["id_emp"].Value.ToString());
                txtUser.Text = row.Cells["Username"].Value.ToString();
                txtName.Text = row.Cells["EmployeeName"].Value.ToString();
                txtPass.Text = row.Cells["Password"].Value.ToString();
                txtStatus.Text = row.Cells["status"].Value.ToString();
                string role = row.Cells["role_emp"].Value.ToString();
                var checkRole = (role == "Admin") ? radioAdmin.Checked = true : radioEmp.Checked = (role == "Employee");
            }
        }
        private void Viewdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int shiftAmount = 80;
            if (role == "Employee")
            {
                Viewdata.Columns["status"].Visible = false;
                Viewdata.Columns["Password"].Visible = false;
                Viewdata.Columns["role_emp"].Visible = false;
                label5.Visible = false;
                txtStatus.Visible = false;
                label3.Visible = false;
                txtPass.Visible = false;
                label4.Visible = false;
                radioAdmin.Visible = false;
                radioEmp.Visible = false;
                label1.Location = new Point(label1.Location.X + shiftAmount, label1.Location.Y);
                label2.Location = new Point(label2.Location.X + shiftAmount, label2.Location.Y);
                txtUser.Location = new Point(txtUser.Location.X + shiftAmount, txtUser.Location.Y);
                txtName.Location = new Point(txtName.Location.X + shiftAmount, txtName.Location.Y);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (radioEmp.Checked)
            {
                rolecheck = "Employee";
            }
            else if (radioAdmin.Checked)
            {
                rolecheck = "Admin";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                return;
            }
            em = new EmployeeModel
            {
                Id = emp_id,
                User_Name = txtUser.Text.Trim(),
                Name = txtName.Text.Trim(),
                Password = txtPass.Text.Trim(),
                Status = txtStatus.Text.Trim(),
                Role = rolecheck,
            };
            int upsert = emp.UpdateOrCreate(em);
            Showdata();
            if (upsert == 1)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                if (Viewdata.Rows.Count > 0)
                {
                    int rowIndex = Viewdata.Rows
                        .Cast<DataGridViewRow>()
                        .ToList()
                        .FindIndex(r => (int)r.Cells["id_emp"].Value == emp_id);

                    if (rowIndex >= 0)
                    {
                        Viewdata_CellClick(this, new DataGridViewCellEventArgs(0, rowIndex));
                    }
                }
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                if (Viewdata.Rows.Count > 0)
                {
                    int rowIndex = Viewdata.Rows
                        .Cast<DataGridViewRow>()
                        .ToList()
                        .FindIndex(r => (int)r.Cells["id_emp"].Value == emp_id);

                    if (rowIndex >= 0)
                    {
                        Viewdata_CellClick(this, new DataGridViewCellEventArgs(0, rowIndex));
                    }
                }
            }
           
        }
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (emp_id > 0)
            {
                bool delete = emp.Delete(emp_id);
                if (delete)
                {
                    MessageBox.Show("Tài khoản đã cập nhật trạng thái");
                    Showdata();
                    if (Viewdata.Rows.Count > 0)
                    {
                        if (selectedRowIndex >= 0 && selectedRowIndex < Viewdata.Rows.Count)
                        {
                            Viewdata_CellClick(this, new DataGridViewCellEventArgs(0, selectedRowIndex));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái tài khoản không thành công. Vui lòng kiểm tra lại ID.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật trạng thái.");
            }
        }
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            emp_id = 0;
            txtUser.Clear();
            txtName.Clear();
            txtPass.Clear();
            radioAdmin.Checked = false;
            radioEmp.Checked = false;
        }
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPass.PasswordChar = '\0'; // '\0' sẽ hiện mật khẩu
            }
            else
            {
                txtPass.PasswordChar = '*'; // Nếu không, ẩn mật khẩu
            }
        }
    }
}
