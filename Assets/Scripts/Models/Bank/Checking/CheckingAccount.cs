using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Bank
{
    public class CheckingAccount
    {
        private float _balance;
        public float Balance
        {
            get
            {
                return _balance;
            }
        }
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

        public CheckingAccount(int ownerID)
        {
            _ownerID = ownerID;
        }

        public bool ModifyBalance(float change)
        {
            if (_balance + change < 0)
            {
                return false;
            }
            _balance += change;
            return true;
        }
        public void Deposit(float value)
        {
            _balance += value;
        }
    }
}

