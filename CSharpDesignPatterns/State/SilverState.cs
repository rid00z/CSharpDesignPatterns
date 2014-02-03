using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    class SilverState : State
    {
        // Overloaded constructors

        public SilverState(State state) :
            this(state.Balance, state.Account)
        {
        }

        public SilverState(double balance, Account account)
        {
            this._balance = balance;
            this._account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            _interest = 0.0;
            _lowerLimit = 0.0;
            _upperLimit = 1000.0;
        }

        public override void Deposit(double amount)
        {
            _balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            _balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            _balance += _interest * _balance;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (_balance < _lowerLimit)
            {
                _account.State = new RedState(this);
            }
            else if (_balance > _upperLimit)
            {
                _account.State = new GoldState(this);
            }
        }
    }
}
