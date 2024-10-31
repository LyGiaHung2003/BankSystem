using BankSystem.Controllers;
using BankSystem.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystem.Views
{
    public partial class BalanceAccount : Form, IView
    {
        AccountController acc = new AccountController();
        AccountModel ac = new AccountModel();
        ErrorProvider errorProvider = new ErrorProvider();
        TransactionController trancs = new TransactionController();
        private float originalAmount;
        private int selectedRowIndex = -1;
        int id_ac;
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public BalanceAccount()
        {
            InitializeComponent();
            dateTimeDate.Enabled = false;
            dateTimeDate.Format = DateTimePickerFormat.Custom;
            dateTimeDate.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày theo kiểu dd/MM/yy
            Showdata();
        }
        private void Showdata()
        {
            try
            {
                acc.Load();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("customer_id", typeof(long));
                dataTable.Columns.Add("date_opend", typeof(DateTime));
                dataTable.Columns.Add("balance", typeof(float));
                dataTable.Columns.Add("status", typeof(string));

                foreach (AccountModel account in acc.Items)
                {
                    dataTable.Rows.Add(account.Id, account.Customer_id, account.Date_opend, account.Balance, account.Status);
                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
            Viewdata.Columns["Date_opend"].DefaultCellStyle.Format = "dd/MM/yyyy";
            Viewdata.RowPrePaint += new DataGridViewRowPrePaintEventHandler(Viewdata_RowPrePaint);
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
                id_ac = int.Parse(row.Cells["id_acc"].Value.ToString());
                txtCustomerid.Text = row.Cells["customerid"].Value.ToString();

                if (DateTime.TryParse(row.Cells["Date_opend"].Value.ToString(), out DateTime selectedDate))
                {
                    dateTimeDate.Value = selectedDate; // Gán cho DateTimePicker
                }
                else
                {
                    MessageBox.Show("Giá trị không hợp lệ cho ngày tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (decimal.TryParse(row.Cells["Balance"].Value.ToString(), out decimal amount))
                {
                    txtBalance.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} VNĐ", amount * 1000);
                }
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }
        private void txtBalance_Leave(object sender, EventArgs e)
        {
            string cleanedInput = txtBalance.Text.Replace(".", ",").Replace(",", ".");

            if (float.TryParse(cleanedInput, NumberStyles.Any, CultureInfo.InvariantCulture, out float amount))
            {
                originalAmount = amount;
                txtBalance.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} VNĐ", amount * 1000);
            }
        }
        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            string input = txtBalance.Text;

            string errorMessage;
            if (!trancs.ValidateAmount(input, out decimal amount, out errorMessage))
            {
                errorProvider.SetError(txtBalance, errorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBalance, "");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerid.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerid.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 tài khoản.");
                return;
            }
            float money = originalAmount;
            ac = new AccountModel
            {
                Id = id_ac,
                Balance = money,
            };
            bool insert = acc.Update(ac);
            Showdata();
            string mess;
            if (insert)
            {
                mess = "Cập nhật số dư thành công";
                if (Viewdata.Rows.Count > 0)
                {
                    int rowIndex = Viewdata.Rows
                        .Cast<DataGridViewRow>()
                        .ToList()
                        .FindIndex(r => (int)r.Cells["id_acc"].Value == id_ac);

                    if (rowIndex >= 0)
                    {
                        Viewdata_CellClick(this, new DataGridViewCellEventArgs(0, rowIndex));
                    }
                }
            }
            else
            {
                mess = "Cập nhật số dư không thành công";
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (id_ac > 0)
            {
                bool delete = acc.Delete(id_ac);
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
        private void buttonClear_Click(object sender, EventArgs e)
        {

            id_ac = 0;
            txtCustomerid.Clear();
            txtBalance.Clear();
            dateTimeDate.Value = DateTime.Now;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // Đặt tên file mặc định với ngày hiện tại
            string fileName = $"BalanceAccount_{DateTime.Now:dd-MM-yyyy}.pdf";

            // Tạo SaveFileDialog với tên file mặc định
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đường dẫn tới font Arial hỗ trợ Unicode
                    string arialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bfArial = BaseFont.CreateFont(arialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bfArial, 12);

                    // Tạo document PDF
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    // Tạo bảng PDF với số cột giống như trong DataGridView
                    PdfPTable pdfTable = new PdfPTable(Viewdata.Columns.Count);
                    pdfTable.WidthPercentage = 100; // Đặt chiều rộng bảng là 100%

                    // Thiết lập chiều rộng cho các cột (tính bằng phần trăm tổng chiều rộng bảng)
                    float[] columnWidths = new float[] { 10f, 15f, 30f, 15f, 30f}; // Căn chỉnh chiều rộng cột phù hợp
                    pdfTable.SetWidths(columnWidths);

                    // Thêm tiêu đề cột vào bảng PDF
                    foreach (DataGridViewColumn column in Viewdata.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.Padding = 5; // Tạo khoảng cách trong ô cho dễ đọc
                        pdfTable.AddCell(cell);
                    }

                    // Thêm dữ liệu từ Viewdata vào bảng PDF
                    foreach (DataGridViewRow row in Viewdata.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "không có", font));
                            pdfCell.Padding = 5; // Tạo khoảng cách trong ô cho dữ liệu dễ đọc
                            pdfTable.AddCell(pdfCell);
                        }
                    }

                    // Thêm bảng vào document
                    document.Add(pdfTable);
                    document.Close();

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xuất dữ liệu: " + ex.Message);
                }
            }
        }

    }
}
