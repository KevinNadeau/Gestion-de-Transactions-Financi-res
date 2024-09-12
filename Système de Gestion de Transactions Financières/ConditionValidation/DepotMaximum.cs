using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Système_de_Gestion_de_Transactions_Financières.Typetransaction;

namespace Système_de_Gestion_de_Transactions_Financières.ConditionValidation
{
    public class DepotMaximum : IValidationCondition
    {
        private const decimal MaxDepot = 10000;
        public bool Validate(Transaction transaction)
        {
            if (transaction is Depot && transaction.Amount > MaxDepot)
            {
                Console.WriteLine("Le dépôt dépasse le montant maximum autorisé.");
                return false;
            }
            return true;
        }
    }
}
