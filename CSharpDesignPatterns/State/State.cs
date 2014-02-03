using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    abstract class State
    {
        protected Account _account;
        protected double _balance;

        protected double _interest;
        protected double _lowerLimit;
        protected double _upperLimit;

        // Properties
        public Account Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
