using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_de_Transactions_Financières.Typetransaction
{
    public abstract class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(int id, decimal amount, DateTime date)
        {
            Id = id;
            Amount = amount;
            Date = date;
        }

        public abstract string GetTransactionType();
    }
}
