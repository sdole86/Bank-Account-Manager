using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account_Manager
{
    public enum status {Ok, Overdrawn, InsufficentFunds, DepositTooLarge };

    class BankAccount
    {
        private decimal _accountBalance; 
        private string _accountNumber;
        private List<String> _balanceHistory = new List<string> { };

        public BankAccount(decimal balance, string accountNumber) {
            _accountBalance = balance;
            _accountNumber = accountNumber;
        }

        public decimal accountBalance
        {
            get { return _accountBalance; }
            set { _accountBalance = value; }
        }
        public string accountNumber
        {
            get { return _accountNumber; }
        }
        public List<String> balanceHistory
        {
            get { return _balanceHistory; }
            set { _balanceHistory = value; }
        }


        //deposit money into account
        public  status Deposit(string value)
        {
            decimal deposit = Convert.ToDecimal(value);
            if (deposit > 10000) { return status.DepositTooLarge; }

            else
            {
                _accountBalance += (Convert.ToDecimal(value));
                _balanceHistory.Add(GetFormattedCurrency(_accountBalance));
                return status.Ok;
            }
        }

        //withdraw money from account
        public status Withdrawal(string value, decimal balance)
        {
            decimal deposit = Convert.ToDecimal(value);
            if ((balance - deposit) < -100) 
            {
                return status.InsufficentFunds; 
            }
            else if ((balance - (deposit) < 0))
            {
                _accountBalance -= (deposit);
                _balanceHistory.Add(GetFormattedCurrency(_accountBalance));
                return status.Overdrawn;
            }
            else
            {
                _accountBalance -= (deposit);
                _balanceHistory.Add(GetFormattedCurrency(_accountBalance));
                return status.Ok;
            }
            
        }

        //retrieve current status of account
        public static status GetAccountStatus(decimal value)
        {
            if (Convert.ToDecimal(value) >= 0) { return status.Ok; }
            else return status.Overdrawn;            
        }

        //retrieve current balance of account
        public decimal GetAccountBalance()
        {

            decimal value = _accountBalance;
            return value;
        }

        //format decimal into string w/ currency format for GUI
        public static string GetFormattedCurrency(decimal currency)
        {

            string formattedCurrency = string.Format("{0:C}", currency);
            return formattedCurrency;
        }

    }


}
