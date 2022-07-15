using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_Manager
{

    public partial class Form1 : Form
    {
        BankAccount account = new BankAccount(1362.59M, "000302019");     


        public Form1()
        {
            InitializeComponent();
            string accountNumber = account.accountNumber;
            var accountBalance = account.GetAccountBalance();
    
            accountBalanceBox.Text = BankAccount.GetFormattedCurrency(account.GetAccountBalance());
            accountNumberBox.Text = accountNumber;
            account.balanceHistory.Add(BankAccount.GetFormattedCurrency(account.GetAccountBalance()));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getHistoryButton_Click(object sender, EventArgs e)
        {
            accountHistoryBox.Items.Clear();
            for (int i = 0; i < account.balanceHistory.Count; i++)
            
            {
                accountHistoryBox.Items.Insert(0, account.balanceHistory.ElementAt(i));
            }
        }

        private void getStatusButton_Click(object sender, EventArgs e)
        {
            if (BankAccount.GetAccountStatus(account.GetAccountBalance()) == status.Ok) {
                MessageBox.Show("Your account is in good standing", "Account Status");
            }
            if (BankAccount.GetAccountStatus(account.GetAccountBalance()) == status.Overdrawn)
            {
                MessageBox.Show("Your account is overdrawn", "Account Status");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            if (validateInput() == false) {
                transactionStatusBox.Text = "Invalid input";
            }

            //deposit selected
            else if (depositButton.Checked) {
                if ((Convert.ToDecimal(transactionAmountBox.Text)) <= 0){
                    transactionStatusBox.Text = "Deposit value must be positive";
                }
                else if (account.Deposit(transactionAmountBox.Text) == status.Ok) {
                    transactionStatusBox.Text = "Transaction successful";
                    decimal deposit = Convert.ToDecimal(transactionAmountBox.Text);
                    accountBalanceBox.Text = BankAccount.GetFormattedCurrency(account.GetAccountBalance());
                }
                
                else if (account.Deposit(transactionAmountBox.Text) == status.DepositTooLarge)
                {
                    transactionStatusBox.Text = "Deposit too large";
                }
            }

            //withdraw selected
            else {
                status check = account.Withdrawal(transactionAmountBox.Text, account.GetAccountBalance());

                if (check == status.Ok)
                {
                    transactionStatusBox.Text = "Transaction successful";
                    decimal deposit = Convert.ToDecimal(transactionAmountBox.Text);
                    accountBalanceBox.Text = BankAccount.GetFormattedCurrency(account.GetAccountBalance());
                }
                else if (check == status.Overdrawn)
                {
                    transactionStatusBox.Text = "Account is overdrawn";
                    decimal deposit = Convert.ToDecimal(transactionAmountBox.Text);
                    accountBalanceBox.Text = BankAccount.GetFormattedCurrency(account.GetAccountBalance());
                }
                else if (check == status.InsufficentFunds) {
                    transactionStatusBox.Text = "Insufficent funds";
                }
            }
        }

        //validate user input is decimal
        private bool validateInput()
        {
            decimal value;
            return decimal.TryParse(transactionAmountBox.Text, out value);
        }

    }
}
