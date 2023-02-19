using System;


namespace BankAccount
{
    //Delegate
    public delegate void Notify();
    public  class Account
    {
        int _AccountNumber;
        String _CustomerName;
        double _CustomerBalance;

        public event Notify UnderBalance;
        public event Notify BalanceZero;
        public Account(int AccountNumber,String CustomerName, double CustomerBalance ) 
        {
            this._AccountNumber = AccountNumber;
            this._CustomerName = CustomerName;
            this._CustomerBalance = CustomerBalance;
        }
        
        public void Withdraw(int amount)
        {
            if(_CustomerBalance>=amount) 
            {
                _CustomerBalance -= amount;
                if(_CustomerBalance == 0)
                {
                    BalanceZero();
                }
            }
            else
            {
                UnderBalance();
            }
        }
        public void Deposit(int amount) 
        {
            _CustomerBalance += amount;
        }
        //Raise Event
        protected virtual void OnUnderBalance() 
        {
            UnderBalance?.Invoke();
        }
        protected virtual void OnBalanceZero() 
        {
            BalanceZero?.Invoke();
        }
        
        //Event Handler
        public static void Obj_UnderBalance()
        {
            Console.WriteLine("You don't have enough balace in your account to withdraw!");
        }
        public static void Obj_BalanceZero()
        {
            Console.WriteLine("Your account balance is zero now!");
        }
       


    }
}
