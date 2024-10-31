using BankSystem.Controllers;
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
    public partial class CreateCus : Form, IView
    {
        CustomerController cs = new CustomerController();
        ErrorProvider errorProvider = new ErrorProvider();
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public CreateCus()
        {
            InitializeComponent();
            txtEmail.Validating += new CancelEventHandler(txtEmail_Validating);
            txtPhone.Validating += new CancelEventHandler(txtPhone_Validating);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text;
            //string phone = txtPhone.Text;
            //string email = txtEmail.Text;
            //string house_no = txtHouse.Text;
            //string city = txtCity.Text;
            ////string created = cs.RegisterCus(name, phone, email, house_no, city);
            //if (created == "Đăng ký thành công")
            //{
            //    MessageBox.Show("Đăng ký tài khoản thành công!");
            //}
            //else
            //{
            //    MessageBox.Show("Đăng ký không thành công. Vui lòng thử lại.");
            //}
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            //string phone = txtPhone.Text;
            //if (!cs.IsValidPhone(phone))
            //{
            //    errorProvider.SetError(txtPhone, "Số điện thoại phải từ 10 đến 11 số không bao gồm chữ cái");
            //    e.Cancel = true;
            //}
            //else
            //{
            //    errorProvider.SetError(txtPhone, "");
            //}
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //    string email = txtEmail.Text;

            //    // Kiểm tra email hợp lệ
            //    if (!cs.IsValidEmail(email))
            //    {
            //        errorProvider.SetError(txtEmail, "Email không hợp lệ, không được có dấu!");
            //        e.Cancel = true;
            //    }
            //    else
            //    {
            //        errorProvider.SetError(txtEmail, "");
            //    }
        }
    }
}
