using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Personal
{
    public class PersonalInformation
    {
        public float FinancialIQ
        {
            get
            {
                return Mathf.Min(Mathf.Pow(Age / _financialAptitude, 2) * _childhoodFinancialInformation, 100);
            }
        }
        private float _financialAptitude;
        private float _childhoodFinancialInformation;

        public float StandardOfLiving
        {
            get
            {
                return (Age / 100 * _lifestyleCreepRate) * _basicDiscresionarySpending;
            }
        }
        private float _lifestyleCreepRate;
        private float _basicDiscresionarySpending;

        public float Responsibility
        {
            get
            {
                return Mathf.Min((Age / 100) * _basicResponsibility * _childHoodResponsibility, 100);
            }
        }
        private float _basicResponsibility;
        private float _childHoodResponsibility;

        public Vector3 NeedsWantsSavesProfile
        {
            get
            {
                return getNeedsWantsSaves();
            }
        }

        public float RiskApetite
        {
            get
            {
                return getRiskApetite();
            }
        }
        public float DiversityApetite
        {
            get
            {
                return getDiversityApetite();
            }
        }
        public float DebtApetite
        {
            get
            {
                return getDebtApetite();
            }
        }
        public int Age;

        private List<Trait> _traits;
        private Vector3 getNeedsWantsSaves()
        {
            Vector3 needsWantsSaves = Vector3.zero;
            for (int i = 0; i < _traits.Count; i++)
            {
                needsWantsSaves += new Vector3(_traits[i].NeedsModifer, _traits[i].WantsModifier, _traits[i].SavingModifier);
            }
            return needsWantsSaves;
        }
        private float getRiskApetite()
        {
            float risk = 0;
            for (int i = 0; i < _traits.Count; i++)
            {
                risk += _traits[i].RiskModifier;
            }
            return risk;
        }
        private float getDiversityApetite()
        {
            float diversity = 0;
            for (int i = 0; i < _traits.Count; i++)
            {
                diversity += _traits[i].DiversityModifier;
            }
            return diversity;
        }
        private float getDebtApetite()
        {
            float debt = 0;
            for (int i = 0; i < _traits.Count; i++)
            {
                debt += _traits[i].DebtModifier;
            }
            return debt;
        }
    }

    public enum StandardOfLiving //expenses
    {
        Extravagent, // = a few houses for personal use, maybe a boat, over 500,000 avg spend per year
        High, //= maybe 2 houses, a couple cars, nice things, 250,000 spend per year
        Upper, //= single home, single or maybe 2 cars, decent things, 100,000 spend per year
        Middle, //= renting, single car, decent things, 55,000 spend per year
        Lower, //= renting, no car, not many things, 25,000 spend per year
        Poverty //= homeless/social home, no car, very few things, 5000 spend per year
    }
}

