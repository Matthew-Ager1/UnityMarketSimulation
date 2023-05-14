using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Market
{
    public class ReturnProfile
    {
        public string Name;
        public string Description;
        public float Value
        {
            get
            {
                return _value;
            }
        }
        private Sector _primarySector;
        private Sector _secondarySector;
        private Sector _tertiarySector;

        private float _value;

        private float _growthMod;
        private float _volitilityMod;

        public ReturnProfile(float averageAnualReturnMod, float volitilityMod, Sector primarySector, Sector secondarySector, Sector tertiarySector, string name)
        {
            _growthMod = averageAnualReturnMod;
            _volitilityMod = volitilityMod;
            _primarySector = primarySector;
            _secondarySector = secondarySector;
            _tertiarySector = tertiarySector;
        }

        public void StepMonth()
        {
            _value += GetPercentChange() * _value;
            if (_value <= 0)
            {
                Delist();
            }
        }
        private float GetPercentChange()
        {
            return MarketState.GetReturnsOn(_primarySector, _secondarySector, _tertiarySector, _volitilityMod, _growthMod);
        }
        private void Delist()
        {

        }
    }
}
