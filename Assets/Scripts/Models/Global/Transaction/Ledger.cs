using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Global
{
    public static class Ledger
    {
        private static List<Transaction> Transactions;
        public static void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
