using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Système_de_Gestion_de_Transactions_Financières.Typetransaction;

namespace Système_de_Gestion_de_Transactions_Financières.ConditionValidation
{
    public class SoldeValidation : IValidationCondition
    {
        private decimal _currentBalance;

        public SoldeValidation(decimal currentBalance)
        {
            _currentBalance = currentBalance;
        }

        public bool Validate(Transaction transaction)
        {
            if (transaction is Retrait && transaction.Amount > _currentBalance)
            {
                Console.WriteLine("refusé: Le montant du retrait dépasse votre solde disponible.");
                return false;
            }
            return true;
        }
    }
}
