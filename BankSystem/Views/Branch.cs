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
    public partial class Branch : Form, IView
    {
        BranchController br = new BranchController();
        BranchModel branch = new BranchModel();
        private int selectedRowIndex = -1;
        int id;
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }

        public Branch()
        {
            InitializeComponent();
            Showdata();
        }
        private void Showdata()
        {
            try
            {
                br.Load();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Branch_id", typeof(string));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("House_no", typeof(string));
                dataTable.Columns.Add("City", typeof(string));
                dataTable.Columns.Add("Status", typeof(string));
                foreach (BranchModel branch in br.Items)
                {
                    dataTable.Rows.Add(branch.Id, branch.Branch_id, branch.Name, branch.House_no, branch.City, branch.Status);
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
        private void Viewdata_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];
                id = int.Parse(row.Cells["id_br"].Value.ToString());
                txtID.Text = row.Cells["BranchID"].Value.ToString();
                txtName.Text = row.Cells["BranchName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text)) 
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            branch = new BranchModel
            {
                Id = id,
                Branch_id = txtID.Text.Trim(),
                Name = txtName.Text.Trim(),
                House_no = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Status = txtStatus.Text.Trim(),
            };
            int upsert = br.UpdateOrCreate(branch);
            if (upsert == 1)
            {
                MessageBox.Show("Cập nhật chi nhánh thành công");
            }
            else
            {
                MessageBox.Show("Tạo chi nhánh mới thành công");
            }
            Showdata();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                bool delete = br.Delete(id);
                if (delete)
                {
                    MessageBox.Show("Chi Nhánh đã cập nhật trạng thái");
                    Showdata();
                    if (Viewdata.Rows.Count > 0)
                    {
                        if (selectedRowIndex >= 0 && selectedRowIndex < Viewdata.Rows.Count)
                        {
                            Viewdata_CellClick_1(this, new DataGridViewCellEventArgs(0, selectedRowIndex));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái chi nhánh không thành công. Vui lòng kiểm tra lại ID.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chi nhánh để cập nhật trạng thái.");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            id = 0;
            txtID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtStatus.Clear();
            Showdata();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
