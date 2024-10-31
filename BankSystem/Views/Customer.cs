using BankSystem.Controllers;
using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Views
{
    public partial class Customer : Form, IView
    {
        private string role;
        int id;
        private int selectedRowIndex = -1;
        CustomerController cs = new CustomerController();
        CustomerModel cus = new CustomerModel();
        ErrorProvider errorProvider = new ErrorProvider();
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public Customer(string userRole)
        {
            role = userRole;
            InitializeComponent();
            Showdata();
            Viewdata.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(Viewdata_DataBindingComplete);
            txtEmail.Validating += new CancelEventHandler(txtEmail_Validating);
            txtPhone.Validating += new CancelEventHandler(txtPhone_Validating);
        }
        private void Showdata()
        {
            try
            {
                cs.Load();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("cus_id", typeof(long));
                dataTable.Columns.Add("name", typeof(string));
                dataTable.Columns.Add("phone", typeof(string));
                dataTable.Columns.Add("email", typeof(string));
                dataTable.Columns.Add("house_no", typeof(string));
                dataTable.Columns.Add("city", typeof(string));
                dataTable.Columns.Add("pin", typeof(string));
                dataTable.Columns.Add("status", typeof(string));

                foreach (CustomerModel Customer in cs.Items)
                {
                    string status = cs.GetAccountStatus(Customer.Cus_Id);
                    dataTable.Rows.Add(Customer.Id, Customer.Cus_Id, Customer.Name, Customer.Phone, Customer.Email, Customer.Address, Customer.City, Customer.Pin, status);
                }

                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
        }
        private void UpdateRowColors()
        {
            foreach (DataGridViewRow row in Viewdata.Rows)
            {
                if (row.Cells["status"].Value.ToString() == "Block")
                {
                    row.DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void Viewdata_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UpdateRowColors();
            int shiftAmount = 180;
            if (role == "Employee")
            {
                Viewdata.Columns["Pin"].Visible = false;
                label7.Visible = false;
                txtPin.Visible = false;
                label1.Location = new Point(label1.Location.X + shiftAmount, label1.Location.Y);
                label2.Location = new Point(label2.Location.X + shiftAmount, label2.Location.Y);
                label3.Location = new Point(label3.Location.X + shiftAmount, label3.Location.Y);
                label4.Location = new Point(label4.Location.X + shiftAmount, label4.Location.Y);
                label5.Location = new Point(label5.Location.X + shiftAmount, label5.Location.Y);
                label6.Location = new Point(label6.Location.X + shiftAmount, label6.Location.Y);
                txtId.Location = new Point(txtId.Location.X + shiftAmount, txtId.Location.Y);
                txtName.Location = new Point(txtName.Location.X + shiftAmount, txtName.Location.Y);
                txtPhone.Location = new Point(txtPhone.Location.X + shiftAmount, txtPhone.Location.Y);
                txtEmail.Location = new Point(txtEmail.Location.X + shiftAmount, txtEmail.Location.Y);
                txtHouse.Location = new Point(txtHouse.Location.X + shiftAmount, txtHouse.Location.Y);
                txtCity.Location = new Point(txtCity.Location.X + shiftAmount, txtCity.Location.Y);
            }
        }
        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];

                if (!int.TryParse(row.Cells["Id_Cus"].Value.ToString(), out id))
                {
                    MessageBox.Show("ID không hợp lệ.");
                    return;
                }
                txtId.Text = row.Cells["NumberAccount"].Value.ToString();
                txtName.Text = row.Cells["CusName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtHouse.Text = row.Cells["House_no"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtPin.Text = row.Cells["Pin"].Value.ToString();
            }
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string phone = txtPhone.Text;
            if (!cs.IsValidPhone(phone))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại phải có từ 10 đến 11 chữ số không bao gồm chữ cái!");
                e.Cancel = true; // Hủy sự kiện nếu số điện thoại không hợp lệ
            }
            else
            {
                errorProvider.SetError(txtPhone, "");
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;
            if (!cs.IsValidEmail(email))
            {
                errorProvider.SetError(txtEmail, "Email không hợp lệ!");
                e.Cancel = true; // Hủy sự kiện nếu email không hợp lệ
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtHouse.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            cus = new CustomerModel
            {
                Id = id,
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtHouse.Text.Trim(),
                City = txtCity.Text.Trim(),
            }; 
            long upsert = cs.UpdateOrCreate(cus);
            Showdata();
            if (upsert == 1)
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                if (Viewdata.Rows.Count > 0)
                {
                    int rowIndex = Viewdata.Rows
                        .Cast<DataGridViewRow>()
                        .ToList()
                        .FindIndex(r => (long)r.Cells["NumberAccount"].Value == id);

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
                        .FindIndex(r => (long)r.Cells["NumberAccount"].Value == id);

                    if (rowIndex >= 0)
                    {
                        Viewdata_CellClick(this, new DataGridViewCellEventArgs(0, rowIndex));
                    }
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            cus = new CustomerModel
            {
                Id = id,
            };
            long id_cus = cs.GetAccountNumber(cus.Id);
            bool upsert = cs.Delete(id_cus);
            Showdata();
            if (upsert)
            {
                MessageBox.Show("Đóng bằng tài khoản thành công!");
                if (Viewdata.Rows.Count > 0)
                {
                    int rowIndex = Viewdata.Rows
                        .Cast<DataGridViewRow>()
                        .ToList()
                        .FindIndex(r => (long)r.Cells["NumberAccount"].Value == id);

                    if (rowIndex >= 0)
                    {
                        Viewdata_CellClick(this, new DataGridViewCellEventArgs(0, rowIndex));
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đã được đóng băng trước đó hoặc chưa chọn tài khoản.");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtHouse.Clear();
            txtCity.Clear();
            txtPin.Clear();
        }
    }
}
