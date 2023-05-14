using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Global
{
    public class Transaction
    {
        public int PersonID;
        public int Month;
        public float Value;
        public int TimeStep;

        private bool _isProcessed = false;
        public Transaction(float value, int personID, int timeStep)
        {
            TimeStep = timeStep;
            Value = value;
            PersonID = personID;
            Month = Global.DateTime.Now();
        }
        public void Process()
        {
            if (_isProcessed)
            {
                Debug.LogError("Trying to process a transaction which has already been processed.");
                return;
            }

            Ledger.AddTransaction(this);
            _isProcessed = true;
        }
        public bool Success()
        {
            return false;
        }
    }
    public class InvestmentDepositTransaction : Transaction
    {
        public InvestmentDepositTransaction(float value, int personID, int TimeStep, float shareValue) : base(value, personID, TimeStep)
        {
            
        }
    }
    public class InvestmentWithdrawlTransaction : Transaction
    {
        public InvestmentWithdrawlTransaction(float value, int personID, int TimeStep, float shareValue) : base(value, personID, TimeStep)
        {

        }
    }
    public class DebtDepositTransaction : Transaction
    {
        public DebtDepositTransaction(float value, int personID, int TimeStep) : base(value, personID, TimeStep)
        {

        }
    }
    public class DebtWithdrawlTransaction : Transaction
    {
        public DebtWithdrawlTransaction(float value, int personID, int TimeStep) : base(value, personID, TimeStep)
        {

        }
    }
    public class SavingsDepositTransaction : Transaction
    {
        public SavingsDepositTransaction(float value, int personID, int TimeStep) : base(value, personID, TimeStep)
        {

        }
    }
    public class SavingsWithdrawlTransaction : Transaction
    {
        public SavingsWithdrawlTransaction(float value, int personID, int TimeStep) : base(value, personID, TimeStep)
        {

        }
    }
    public static class TransactionCreator
    {
        public static Transaction CreateTransaction(string transactionType, float value, int personID, int timeStep, float shareValue = -1)
        {
            switch (transactionType)             
            {
                case "investment-withdrawl":
                    return new InvestmentWithdrawlTransaction(value, personID, timeStep, shareValue: shareValue);
                case "investment-deposit":
                    return new InvestmentDepositTransaction(value, personID, timeStep, shareValue: shareValue);
                case "debt-withdrawl":
                    return new DebtWithdrawlTransaction(value, personID, timeStep);
                case "debt-deposit":
                    return new DebtDepositTransaction(value, personID, timeStep);
                case "savings-withdrawl":
                    return new SavingsWithdrawlTransaction(value, personID, timeStep);
                case "savings-deposit":
                    return new SavingsDepositTransaction(value, personID, timeStep);
                default:
                    Debug.LogError("No transaction of type: " + transactionType);
                    return null;
            }

        }
    }
}

