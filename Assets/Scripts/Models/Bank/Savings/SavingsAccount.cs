using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Bank
{
    public class SavingsAccount
    {
        public float InterestRate;
        public float Balance;

        private int _ownerID = -1;
        public int OwnerID
        {
            get 
            {
                return _ownerID;
            }
            set
            {
                if (_ownerID != -1) { _ownerID = value; }
            }
        }
        public SavingsAccount(int ownerID)
        {
            this._ownerID = ownerID;
        }
        public void Deposit(float value)
        {
            Balance += value;
        }
    }
}

