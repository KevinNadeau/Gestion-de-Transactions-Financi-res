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
        public bool Validate(Transaction transaction)
        {
            //limite de dépôt de 50000€
            if (transaction is Depot && transaction.Amount > 50000)
            {
                Console.WriteLine("Le dépôt dépasse le montant maximum autorisé.");
                return false;
            }
            return true;
        }
    }
}
