using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models.Market;
using Models.Global;
using System;

namespace Models.Investment
{
    /// <summary>
    ///     An account is the base of every account and tracks what
    /// </summary>
    public class InvestmentAccount
    {
        public float Balance
        {
            get
            {
                return _shares * Profile.Value;
            }
        }
        private float _shares;

        public int OwnerId
        {
            get
            {
                return _ownerId;
            }
        }
        private int _ownerId;

        public ReturnProfile Profile;

        public void StepMonth()
        {
            Profile.StepMonth();
        }

        public InvestmentAccount(int ownerId, Enum sector, int riskLevel)
        {
            _ownerId = ownerId;
            Profile = Investments.GetProfile((Sector)sector, riskLevel);
        }

        public Transaction Deposit(float value)
        {
            _shares += value / Profile.Value;

            Transaction transaction = TransactionCreator.CreateTransaction("investment-deposit", value, OwnerId, Global.DateTime.Now());
            transaction.Process();

            return transaction;
        }
        public Transaction Withdraw(float value)
        {
            _shares -= value / Profile.Value;

            Transaction transaction = TransactionCreator.CreateTransaction("investment-withdrawl", value, OwnerId, Global.DateTime.Now());
            transaction.Process();

            return transaction;
        }
    }
}

