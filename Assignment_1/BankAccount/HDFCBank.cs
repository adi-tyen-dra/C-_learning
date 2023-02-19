using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //Delegate
    public delegate void HDFCNotify();
    public  class HDFCBank
    {
        int _AccountNumber;
        String _CustomerName;
        double _CustomerBalance;

        //Events
        public event HDFCNotify UnderBalance;
        public event HDFCNotify BalanceZero;
        public HDFCBank(int AccountNumber, String CustomerName, double CustomerBalance)
        {
            this._AccountNumber = AccountNumber;
            this._CustomerName = CustomerName;
            this._CustomerBalance = CustomerBalance;

            UnderBalance += HDFCBank.Obj_UnderBalance;
            BalanceZero += HDFCBank.Obj_BalanceZero;
        }

        public void Withdraw(int amount)
        {
            if (_CustomerBalance >= amount && _CustomerBalance-amount >= 1000)
            {
                _CustomerBalance -= amount;
                if(_CustomerBalance==0)
                {
                    //Raise Event
                    BalanceZero.Invoke();
                }
            }
            else
            {
                //Raise Event
                UnderBalance.Invoke();
            }
        }
        public void Deposit(int amount)
        {
            _CustomerBalance += amount;
        }
        //Event Handler
        public static void Obj_UnderBalance()
        {
            Console.WriteLine("Transaction cannot be continued below specified limit of\tRs.-1000");
        }
        public static void Obj_BalanceZero()
        {
            Console.WriteLine("Your Current balance is now zero!");
        }
    }
}
