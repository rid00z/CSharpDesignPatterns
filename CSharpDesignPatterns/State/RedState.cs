using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDesignPatterns.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn
    /// </remarks>
    /// </summary>
    class RedState : State
    {
        private double _serviceFee;

        // Constructor
        public RedState(State state)
        {
            this._balance = state.Balance;
            this._account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            _interest = 0.0;
            _lowerLimit = -100.0;
            _upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            _balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (_balance > _upperLimit)
            {
                _account.State = new SilverState(this);
            }
        }
    }
}
