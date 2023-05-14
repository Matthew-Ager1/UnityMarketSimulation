using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models.Personal;
using Models.Global;
using Models.Bank;
using Models.Investment;
using Models.Market;

namespace Processes.Personal 
{
    public class DescisionAgent
    {
        public PersonalFinancials Financials;

        public void StepMonth()
        {
            Financials.Update();
        }
    }
}