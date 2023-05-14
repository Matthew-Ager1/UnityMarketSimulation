using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models.Investment;
using Models.Global;

namespace Models.Market
{
    public class InvestmentProfile
    {
        private int _ownerId;
        public int OwnerId
        {
            get
            {
                return _ownerId;
            }
        }
        private float _value;
        public float Value
        {
            get
            {
                return _value;
            }
        }
        private ReturnProfile _profile;
        private Sector _sector;

        public InvestmentProfile(int ownerId, Sector sector, int riskLevel)
        {
            _profile = Investments.GetProfile(sector, riskLevel);
            _sector = sector;
            _ownerId = ownerId;
        }

        
    }
}

