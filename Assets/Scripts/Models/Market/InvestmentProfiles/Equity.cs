using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Market
{
    public struct Equity
    {
        private float _risk;
        private float _constistancy;
        private float _winRate;

        public float CalculatePercentageReturn(MarketState state, Sector sector)
        {
            float basis = CalculateBasisReturn(state, sector);

            basis += returnCalc() * _winRate > Random.value ? 1 : -1;

            return basis;
        }
        private float CalculateBasisReturn(MarketState state, Sector sector)
        {
            return 0;
        }
        private float returnCalc()
        {
            float x = Random.value;
            return _risk * (Mathf.Pow(x, _constistancy) + (x / _constistancy));
        }
    }
}
