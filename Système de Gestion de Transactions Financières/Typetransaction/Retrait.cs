using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_de_Transactions_Financières.Typetransaction
{
    public class Retrait : Transaction
    {
        public Retrait(string montant, decimal amount, DateTime date)
            : base(montant, amount, date) { }

        public override string GetTransactionType()
        {
            return "Retrait";
        }
    }
}
