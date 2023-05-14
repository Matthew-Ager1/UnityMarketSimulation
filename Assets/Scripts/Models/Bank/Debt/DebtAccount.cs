using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Bank
{
    public class DebtAccount
    {
        public float MonthlyInterestRate;
        public float Balance;
        public DebtType Type;
        public float MaxBalance;

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
        public float MinimumPayment
        {
            get
            {
                return Balance * MonthlyInterestRate;
            }
        }
        public DebtAccount(int ownerID)
        {
            this._ownerID = ownerID;
        }
        public void PayOff(float value)
        {
            Balance -= value;
        }
        public void TakeOut(float value)
        {
            Balance += value;
        }
    }

    public enum DebtType
    {
        CreditCard,
        Mortagea
    }
}
