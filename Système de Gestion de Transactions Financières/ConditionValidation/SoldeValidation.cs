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
        private decimal _soldeActuel;
        private const decimal SoldeMinimum = -5000; // Limite de découvert autorisé

        // Constructeur pour initialiser le solde actuel
        public SoldeValidation(decimal soldeActuel)
        {
            _soldeActuel = soldeActuel;
        }

        public bool Validate(Transaction transaction)
        {
            if (transaction is Retrait)
            {
                // On calcule le nouveau solde après le retrait
                decimal NouveauSolde = _soldeActuel - transaction.Montant;

                if (NouveauSolde < SoldeMinimum)
                {
                    Console.WriteLine($"Retrait refusé : le solde ne peut pas être inférieur à {SoldeMinimum} €.");
                    return false;
                }
                //Mise à jour du solde si le retrait est validé
                _soldeActuel = NouveauSolde;
                if (transaction.Montant > _soldeActuel)
                {
                    Console.WriteLine("refusé: Le montant du retrait dépasse votre solde disponible.");
                    return false;
                }
            }            
            return true;
        }
    }
}
