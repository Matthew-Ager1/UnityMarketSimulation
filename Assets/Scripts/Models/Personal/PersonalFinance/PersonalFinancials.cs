using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Processes.Tax;
using Models.Investment;
using Models.Global.Util;
using Models.Market;

namespace Models.Personal 
{
    public class PersonalFinancials
    {
        public List<Career> Careers;
        public List<Investment.InvestmentAccount> InvestmentAccounts;
        public Bank.SavingsAccount SavingsAccount;
        public Bank.CheckingAccount CheckingAccount;
        public List<Bank.DebtAccount> DebtAccounts;
        public PersonalInformation Personal;

        private int _ownerID;

        public void Update()
        {
            float income = 0;
            float maxIncome = 0;
            for (int i = 0; i < Careers.Count; i++)
            {
                income += Careers[i].MonthlyIncome;
            }

            income -= Tax.getTax(income);
            maxIncome = income;

            for (int i = 0; i < DebtAccounts.Count; i++)
            {
                income -= DebtAccounts[i].MinimumPayment;
            }

            for (int i = 0; i < InvestmentAccounts.Count; i++)
            {
                InvestmentAccounts[i].StepMonth();
            }

            Vector3 spending = GetSpending(income, maxIncome);

            float needs = spending.x;
            float wants = spending.y;
            float saves = spending.z;

            DistributeSavings(saves);

            income -= spending.x;
            income -= spending.y;
            income -= spending.z;

            if (income < 0)
            {
                float deptIncurred = -income;
                DrawFromCreditCard(income);
            }
        }

        public Vector3 GetSpending(float remainingIncome, float maxIncome)
        {
            float wants = Personal.StandardOfLiving * (1 - Personal.Responsibility);
            float needs = Personal.StandardOfLiving * Personal.Responsibility;
            float saves = maxIncome * (Personal.FinancialIQ * Personal.Responsibility);

            Vector3 needsWantsSaves = Personal.NeedsWantsSavesProfile;
            needsWantsSaves += new Vector3(needs, wants, saves);
            needsWantsSaves.Normalize();

            float wantsSpending = remainingIncome * wants;
            float needsSpending = remainingIncome * needs;
            float savesSpending = remainingIncome * saves;

            float overWantsSpend = 0;
            float overNeedsSpend = 0;

            if (wants < wantsSpending)
            {
                overWantsSpend = (wants - wantsSpending) / ((1 - Personal.Responsibility) + .5f);
                wantsSpending += overWantsSpend;
            }
            if (needs < needsSpending)
            {
                overNeedsSpend = (needs - needsSpending) / ((1 - Personal.Responsibility) + .5f);
                needsSpending += overNeedsSpend;
            }

            if (needsSpending + wantsSpending > remainingIncome)
            {
                float totalOverSpend = (needsSpending + wantsSpending) - remainingIncome;
                savesSpending -= totalOverSpend;
                savesSpending = saves < 0 ? 0 : saves;
            }

            return new Vector3(wantsSpending, needsSpending, savesSpending);
        }

        public void DistributeSavings(float savings)
        {
            if (Personal.FinancialIQ < 35)
            {
                CheckingAccount.Deposit(savings);
                return;
            }
            if (Personal.FinancialIQ < 50)
            {
                CheckingAccount.Deposit(savings * .25f);
                SavingsAccount.Deposit(savings * .75f);
            }
            if (Personal.FinancialIQ < 65)
            {
                CheckingAccount.Deposit(savings * .25f);
                SavingsAccount.Deposit(savings * .25f);
                DistributeInvestments(savings * .50f);
            }
            if (Personal.FinancialIQ < 70)
            {
                CheckingAccount.Deposit(savings * .04f);
                DistributeInvestments(savings * .96f);
            }
            if (Personal.FinancialIQ < 90)
            {
                SavingsAccount.Deposit(savings * .2f);
                DistributeInvestments(savings * .8f);
            }
            else
            {
                if (SavingsAccount.Balance + CheckingAccount.Balance < 20000 * Personal.Responsibility)
                {
                    SavingsAccount.Deposit(savings);
                }
                DistributeInvestments(savings);
            }
        }

        public void DistributeInvestments(float investment) //and pay off debts
        {
            int desiredInvestments = (int)Personal.DiversityApetite;
            int currentInvestments = InvestmentAccounts.Count;
            if (desiredInvestments < currentInvestments)
            {
                InvestmentAccounts.Add(new InvestmentAccount(_ownerID, typeof(Sector).GetRandomEnumValue(), (int)Personal.RiskApetite));
                InvestmentAccounts[InvestmentAccounts.Count - 1].Deposit(investment);
            }
            else
            {
                for (int i = 0; i < desiredInvestments; i++)
                {
                    InvestmentAccounts[i].Deposit(investment / desiredInvestments);
                }
            }
        }

        public void DrawFromCreditCard(float value)
        {
            for (int i = 0; i < DebtAccounts.Count; i++)
            {
                if (DebtAccounts[i].Type == Bank.DebtType.CreditCard)
                {
                    float remainingCredit = DebtAccounts[i].MaxBalance - DebtAccounts[i].Balance;
                    if (remainingCredit > value)
                    {
                        DebtAccounts[i].TakeOut(value);
                    }
                    else
                    {
                        DebtAccounts[i].TakeOut(remainingCredit);
                    }
                    value -= remainingCredit;
                    continue;
                }
            }
            if (value > 0)
            {
                if (DebtAccounts.Count < 10)
                {
                    DebtAccounts.Add(new Bank.DebtAccount(_ownerID));
                }
                else
                {
                    //bankrupt
                }
            }
        }
    }
}
