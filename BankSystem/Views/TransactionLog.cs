using BankSystem.Controllers;
using BankSystem.Models;
using System.Data;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BankSystem.Views
{
    public partial class TransactionLog : Form, IView
    {
        TransactionController trans = new TransactionController();
        BranchController br = new BranchController();
        AccountController acc = new AccountController();
        EmployeeController emp = new EmployeeController();
        CustomerController customer = new CustomerController();
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public TransactionLog()
        {
            InitializeComponent();
            dateTimedate.Format = DateTimePickerFormat.Custom;
            dateTimedate.CustomFormat = "dd/MM/yyyy";
            Showdata();
        }
        private void Showdata()
        {
            try
            {
                trans.Load();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("from_account_id", typeof(string));
                dataTable.Columns.Add("FromCustomerName", typeof(string));
                dataTable.Columns.Add("to_account_id", typeof(string));
                dataTable.Columns.Add("ToCustomerName", typeof(string));
                dataTable.Columns.Add("branch_id", typeof(string));
                dataTable.Columns.Add("date_of_trans", typeof(string));
                dataTable.Columns.Add("amount", typeof(string));
                dataTable.Columns.Add("employee_id", typeof(string));
                dataTable.Columns.Add("id_type", typeof(string));
                dataTable.Columns.Add("content", typeof(string));

                foreach (TransactionModel transaction in trans.Items)
                {
                    string fromCustomerName = customer.GetCustomerName(transaction.From_account_id);
                    string toCustomerName = customer.GetCustomerName(transaction.To_account_id);
                    string employeeName = emp.GetNameEmp(transaction.Employee_id);
                    string typeName = trans.GetNameType(transaction.id_type);
                    string branchName = br.GetNameBr(transaction.Branch_id);
                    long accountNumberFr = acc.GetAccountNumber(transaction.From_account_id);
                    long accountNumberTo = acc.GetAccountNumber(transaction.To_account_id);
                    float amountInVND = transaction.Amount * 1000;

                    string formattedAmount = amountInVND.ToString("N0") + " VNĐ";

                    dataTable.Rows.Add(transaction.Id, accountNumberFr, fromCustomerName, accountNumberTo != 0 ? accountNumberTo.ToString() : "Không có tài khoản",
                            accountNumberTo != 0 ? toCustomerName : "Không có khách hàng", branchName, transaction.Date_of_trans.ToString("dd/MM/yyyy"), formattedAmount, employeeName, typeName,transaction.content);

                }
                Viewdata.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
            Viewdata.Columns["date_of_trans"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void Viewdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Viewdata.Rows[e.RowIndex];

                txtId.Text = row.Cells["id"].Value.ToString();
                txtEmpId.Text = row.Cells["employee_id"].Value.ToString();
                txtFromAcc.Text = row.Cells["from_account_id"].Value.ToString();
                txtToAcc.Text = row.Cells["To_account_id"].Value.ToString();
                txtFromName.Text = row.Cells["FromName"].Value.ToString();
                txtToName.Text = row.Cells["ToName"].Value.ToString();
                txtType.Text = row.Cells["Type"].Value.ToString();

                if (decimal.TryParse(row.Cells["amount"].Value.ToString().Replace(" VNĐ", "").Replace(".", "").Trim(), out decimal amount))
                {
                    txtAmount.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} VNĐ", amount);
                }

                txtContent.Text = row.Cells["content"].Value.ToString();

                txtBranch.Text = row.Cells["branch_id"].Value.ToString();
                string dateValue = row.Cells["date_of_trans"].Value.ToString();
                DateTime selectedDate = DateTime.ParseExact(dateValue, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dateTimedate.Value = selectedDate;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string fileName = $"Transactionlog_{DateTime.Now:dd-MM-yyyy}.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string arialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bfArial = BaseFont.CreateFont(arialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bfArial, 12); 

                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    PdfPTable pdfTable = new PdfPTable(Viewdata.Columns.Count);
                    pdfTable.WidthPercentage = 100; 

                    float[] columnWidths = new float[] { 10f, 15f, 30f, 15f, 30f, 20f, 15f, 20f, 30f, 40f, 50f };
                    pdfTable.SetWidths(columnWidths);

                    foreach (DataGridViewColumn column in Viewdata.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        cell.Padding = 5;
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in Viewdata.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "không có", font));
                            pdfCell.Padding = 5; 
                            pdfTable.AddCell(pdfCell);
                        }
                    }
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
