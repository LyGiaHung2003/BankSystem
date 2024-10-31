using BankSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystem.Views
{
    public partial class Transaction : Form, IView
    {
        AccountController acc = new AccountController();
        CustomerController cr = new CustomerController();
        BranchController b = new BranchController();
        TransactionController trancs = new TransactionController();
        ErrorProvider errorProvider = new ErrorProvider();
        public void SetDataToText(Object item)
        {

        }
        public void GetDataFromText()
        {

        }
        public int CurrentEmployeeId { get; set; }
        private float originalAmount;

        public Transaction(int employeeId)
        {
            InitializeComponent();
            comboBranch.SelectedIndexChanged += comboBranch_SelectedIndexChanged;
            textAmount.Leave += textAmount_Leave;
            textFromAccount.TextChanged += textFromAccount_TextChanged;
            textToAccount.TextChanged += textToAccount_TextChanged;
            CurrentEmployeeId = employeeId;

            List<string> accountList = acc.GetAccount();
            List<string> brList = b.GetBranchNames();

            comboBranch.DataSource = brList;

            SetupAutoComplete(textFromAccount, accountList);
            SetupAutoComplete(textToAccount, accountList);
        }

        private void SetupAutoComplete(TextBox textBox, List<string> sourceList)
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(sourceList.ToArray());

            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void textAmount_Leave(object sender, EventArgs e)
        {
            string cleanedInput = textAmount.Text.Replace(".", ",").Replace(",", ".");

            if (float.TryParse(cleanedInput, NumberStyles.Any, CultureInfo.InvariantCulture, out float amount))
            {
                originalAmount = amount;
                textAmount.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} VNĐ", amount * 1000);
            }
        }
        private void textAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void textToAccount_TextChanged(object sender, EventArgs e)
        {
            string accountId = textToAccount.Text;

            if (!string.IsNullOrEmpty(accountId))
            {
                string customerName = cr.GetCustomerNameByAccountId(accountId);
                textToName.Text = customerName;
            }
        }
        private void comboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBranchName = comboBranch.SelectedItem.ToString();
            string branchId = b.GetBranchIdByName(selectedBranchName);
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFromAccount.Text) ||
                string.IsNullOrWhiteSpace(textToAccount.Text) ||
                string.IsNullOrWhiteSpace(textToName.Text) ||
                string.IsNullOrWhiteSpace(textFromName.Text) ||
                string.IsNullOrWhiteSpace(textAmount.Text) ||
                string.IsNullOrWhiteSpace(comboBranch.Text) ||
                string.IsNullOrWhiteSpace(textContent.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            long accountId = long.Parse(textFromAccount.Text);
            long accountToDepositId = long.Parse(textToAccount.Text);
            int idaccountfr = acc.GetAccountIdByCustomerId(accountId);
            int idaccounto = acc.GetAccountIdByCustomerId(accountToDepositId);
            string cont = textContent.Text;

            float amount = originalAmount;
            string selectedBranchName = comboBranch.SelectedItem.ToString();
            string branchId = b.GetBranchIdByName(selectedBranchName);

            string pin = textPin.Text;
            string resultMessage = trancs.Transaction(idaccountfr, branchId, amount, pin, idaccounto, CurrentEmployeeId, cont);
            MessageBox.Show(resultMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textFromAccount.Clear();
            textToAccount.Clear();
            textFromName.Clear();
            textToName.Clear();
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
