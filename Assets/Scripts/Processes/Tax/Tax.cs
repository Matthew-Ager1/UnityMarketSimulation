using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Processes.Tax 
{
    public static class Tax
    {
        private static int[] TaxBrackets = new int[]
        {
            10275,
            41775,
            89075,
            170050,
            215950,
            539900
        };

        public static float getTax(float monthlyIncome)
        {
            return getStateIncomeTax(monthlyIncome) + getFederalIncomeTax(monthlyIncome); 
        }

        private static float getStateIncomeTax(float monthlyIncome)
        {
            return monthlyIncome * .0295f; //some small tax rate
        }
        private static float getFederalIncomeTax(float monthlyIncome)
        {
            if (monthlyIncome < TaxBrackets[0]) { return monthlyIncome * .1f; }
            if (monthlyIncome < TaxBrackets[1]) { return calcuateFederalIncomeTax(1027.50f,   12, monthlyIncome, TaxBrackets[0]); }
            if (monthlyIncome < TaxBrackets[2]) { return calcuateFederalIncomeTax(4807.50f,   22, monthlyIncome, TaxBrackets[1]); }
            if (monthlyIncome < TaxBrackets[3]) { return calcuateFederalIncomeTax(15213.50f,  24, monthlyIncome, TaxBrackets[2]); }
            if (monthlyIncome < TaxBrackets[4]) { return calcuateFederalIncomeTax(34647.50f,  32, monthlyIncome, TaxBrackets[3]); }
            if (monthlyIncome < TaxBrackets[5]) { return calcuateFederalIncomeTax(49335.50f,  35, monthlyIncome, TaxBrackets[4]); }
            else                                { return calcuateFederalIncomeTax(162718.00f, 37, monthlyIncome, TaxBrackets[5]); }

        }

        private static float calcuateFederalIncomeTax(float baseTax, float percentageTax, float income, float overValue)
        {
            return baseTax + percentageTax * (income - overValue);
        }
    }
}


