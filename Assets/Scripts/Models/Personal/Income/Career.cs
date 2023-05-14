using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models.Personal
{
    public class Career
    {
        public float MonthlyIncome;
        private float _baseBonus;

        public Career(float monthlyIncome, float baseBonus)
        {
            MonthlyIncome = monthlyIncome;
            _baseBonus = baseBonus;
        }

        private float getBonus(float performance)
        {
            return _baseBonus * performance;
        }
    }
}
