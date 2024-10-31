using BankSystem.Controllers;
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

namespace BankSystem.Views
{
    public partial class Deposit : Form, IView
    {
        AccountController acc = new AccountController();
        CustomerController cr = new CustomerController();
        BranchController b = new BranchController();
        TransactionController trancs = new TransactionController();
        ErrorProvider errorProvider = new ErrorProvider();
        public int CurrentEmployeeId { get; set; }
        private float originalAmount;
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public Deposit(int employeeId)
        {
            InitializeComponent();
            comboBranch.SelectedIndexChanged += comboBranch_SelectedIndexChanged;
            textAmount.Validating += textAmount_Validating;
            textFromAccount.TextChanged += textFromAccount_TextChanged;
            CurrentEmployeeId = employeeId;

            List<string> accountList = acc.GetAccount();
            List<string> brList = b.GetBranchNames();

            comboBranch.DataSource = brList;

            SetupAutoComplete(textFromAccount, accountList);
        }
        private void SetupAutoComplete(TextBox textBox, List<string> sourceList)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(sourceList.ToArray());

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void comboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBranchName = comboBranch.SelectedItem.ToString();
            string branchId = b.GetBranchIdByName(selectedBranchName);
        }
        private void textAmount_Leave(object sender, EventArgs e)
        {
            string cleanedInput = textAmount.Text.Replace(".", ".").Replace(",", ".");

            if (float.TryParse(cleanedInput, NumberStyles.Any, CultureInfo.InvariantCulture, out float amount))
            {
                originalAmount = amount;
                textAmount.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} VNĐ", amount * 1000);
            }
        }
        private void textAmount_Validating(object sender, CancelEventArgs e)
        {
            string input = textAmount.Text;

            string errorMessage;
            if (!trancs.ValidateAmount(input, out decimal amount, out errorMessage))
            {
                errorProvider.SetError(textAmount, errorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textAmount, "");
            }
        }

        private void textFromAccount_TextChanged(object sender, EventArgs e)
        {
            string accountId = textFromAccount.Text;

            if (!string.IsNullOrEmpty(accountId))
            {
                string customerName = cr.GetCustomerNameByAccountId(accountId);
                textFromName.Text = customerName;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFromAccount.Text) ||
                string.IsNullOrWhiteSpace(textFromName.Text) ||
                string.IsNullOrWhiteSpace(textAmount.Text) ||
                string.IsNullOrWhiteSpace(comboBranch.Text) ||
                string.IsNullOrWhiteSpace(textContent.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            long accountId = long.Parse(textFromAccount.Text);
            int idaccountfr = acc.GetAccountIdByCustomerId(accountId);
            string cont = textContent.Text;

            float amount = originalAmount;
            string selectedBranchName = comboBranch.SelectedItem.ToString();
            string branchId = b.GetBranchIdByName(selectedBranchName);
            string pin = textPin.Text;
            string resultMessage = trancs.Deposit(idaccountfr, branchId, amount, pin, CurrentEmployeeId, cont);
            MessageBox.Show(resultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textFromAccount.Clear();
            textFromName.Clear();
            textPin.Clear();
            textContent.Clear();
            textAmount.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
