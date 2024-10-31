using BankSystem.Controllers;
using BankSystem.Controlles;
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
    public partial class Homepage : Form ,IView
    {
        EmployeeController emp = new EmployeeController();
        private bool isLoggedIn = false;
        public Dangnhap dangnhap;
        public int EmployeeId { get; set; }
        public string UserRole { get; set; }
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }

        public Homepage()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Trangchu_KeyDown);
            logoutToolStripMenuItem.Visible = false;
        }
        public void Trangchu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        public void UpdateLoginStatus(bool status)
        {
            isLoggedIn = status;
            logoutToolStripMenuItem.Visible = status;
            loginToolStripMenuItem.Visible = !status;
        }

        public void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap(this);
            dn.MdiParent = this;
            dn.Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            isLoggedIn = false;
            UpdateLoginStatus(isLoggedIn);

            EmployeeId = 0;
            UserRole = string.Empty;

            Dangnhap dn = new Dangnhap(this);
            dn.MdiParent = this;
            dn.Show();

        }
        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                Employee emp = new Employee(UserRole);
                emp.MdiParent = this;
                emp.Show();
            }
        }

        public void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                Branch br = new Branch();
                br.MdiParent = this;
                br.Show();
            }
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                Customer cr = new Customer(UserRole);
                cr.MdiParent = this;
                cr.Show();
            }
        }

        private void depositAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                Transaction dep = new Transaction(EmployeeId); 
                dep.MdiParent = this;
                dep.Show();
            }
        }

        private void withdrawAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                Withdraw withdraw = new Withdraw(EmployeeId);
                withdraw.MdiParent = this;
                withdraw.Show();
            }
        }

        private void transactionAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                Deposit transaction = new Deposit(EmployeeId);
                transaction.MdiParent = this;
                transaction.Show();
            }
        }

        private void balanceAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                BalanceAccount balance = new BalanceAccount();
                balance.MdiParent = this;
                balance.Show();
            }
        }

        private void transactionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isLoggedIn)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng tính năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dangnhap dn = new Dangnhap(this);
                dn.MdiParent = this;
                dn.Show();
            }
            else
            {
                TransactionLog log = new TransactionLog();
                log.MdiParent = this;
                log.Show();
            }
        }
    }
}
