using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_de_Transactions_Financières.Typetransaction
{
    public abstract class Transaction
    {
        //mettre les setter en private
        public string Type { get; set; } 
        public decimal Montant { get; set; }// Il est de type decimal, car c’est le type de données le plus approprié pour des calculs financiers
        public DateTime Date { get; set; }

        public Transaction(string type, decimal montant, DateTime date)
        {
            Type = type;
            Montant = montant;
            Date = date;
        }

        public abstract string GetTransactionType();
    }
}
