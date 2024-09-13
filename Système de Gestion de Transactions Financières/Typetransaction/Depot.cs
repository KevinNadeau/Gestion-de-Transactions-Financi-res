using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_de_Transactions_Financières.Typetransaction
{
    public class Depot : Transaction
    {
        public Depot(string type, decimal montant, DateTime date)
            : base(type, montant, date) { }

        public override string GetTransactionType()
        {
            return "Depôt";
        }
    }
}
