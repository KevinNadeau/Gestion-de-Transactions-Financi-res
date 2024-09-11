using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Système_de_Gestion_de_Transactions_Financières.ConditionValidation;
using Système_de_Gestion_de_Transactions_Financières.Typetransaction;

namespace Système_de_Gestion_de_Transactions_Financières.Services
{
    public class GestionTransaction
    {
        private List<IValidationCondition> _regles = new List<IValidationCondition>();

        public void AddRule(IValidationCondition regle)
        {
            _regles.Add(regle);
        }

        public bool ExecutionTransaction(Transaction transaction)
        {
            foreach (var rule in _regles)
            {
                if (!rule.Validate(transaction))
                {
                    Console.WriteLine($"Transaction {transaction.GetTransactionType()} échec de la transaction.");
                    return false;
                }
            }
            Console.WriteLine($"Transaction {transaction.GetTransactionType()} transaction effectuée.");
            return true;
        }
    }
}
