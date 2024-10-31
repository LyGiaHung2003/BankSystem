using BankSystem.Controllers;

namespace BankSystem.Views
{
    public partial class Dangnhap : Form, IView
    {
        private Homepage parentForm;
        EmployeeController emp = new EmployeeController();
        public string EmployeeId { get; private set; }
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public Dangnhap(Homepage parent)
        {
            InitializeComponent();
            parentForm = parent;
            txtPassword.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
        private void CloseOpenForms()
        {
            List<Form> formsToClose = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form != parentForm)
                {
                    formsToClose.Add(form); 
                }
            }

            // Đóng các form trong danh sách
            foreach (Form form in formsToClose)
            {
                form.Close();
            }
        }
        private void ButtonDN_Enter(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassword.Text;
            string role = emp.Login(account, password);
            if (!string.IsNullOrEmpty(role))
            {
                parentForm.dangnhap = this; 
                int employeeId = emp.GetEmployeeId(account); 
                parentForm.EmployeeId = employeeId; 
                parentForm.UserRole = role;

                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentForm.loginToolStripMenuItem.Visible = false;
                parentForm.UpdateLoginStatus(true);

                CloseOpenForms(); // Đóng các form mở khác
                this.Hide();
            }
        }
    }
}
