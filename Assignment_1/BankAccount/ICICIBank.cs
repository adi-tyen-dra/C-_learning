using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //Delegate
    public delegate void ICICINotify();
    public  class ICICIBank
    {
        int _AccountNumber;
        String _CustomerName;
        double _CustomerBalance;

        public event ICICINotify UnderBalance;
        public event ICICINotify BalanceZero;
        public ICICIBank(int AccountNumber, String CustomerName, double CustomerBalance)
        {
            this._AccountNumber = AccountNumber;
            this._CustomerName = CustomerName;
            this._CustomerBalance = CustomerBalance;

            UnderBalance += Obj_UnderBalance;
            BalanceZero += Obj_BalanceZero;
        }

        public void Withdraw(int amount)
        {
            if (_CustomerBalance >= amount)
            {
                _CustomerBalance -= amount;
                if(_CustomerBalance==0)
                {
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
            Console.WriteLine("Transaction cannot be continued as balance is insufficient!");
        }
        public static void Obj_BalanceZero()
        {
            Console.WriteLine("Transaction cannot be continued as balance is now zero!");
        }

    }
}
