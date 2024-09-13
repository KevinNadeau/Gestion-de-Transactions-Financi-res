using System;
using Système_de_Gestion_de_Transactions_Financières.ConditionValidation;
using Système_de_Gestion_de_Transactions_Financières.Services;
using Système_de_Gestion_de_Transactions_Financières.Typetransaction;

namespace Système_de_Gestion_de_Transactions_Financières
{
    class Pricipale
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("hello tlm");

            var gestionTransaction = new TransactionService();

            //ajout des règles et du solde
            gestionTransaction.AddRule(new DepotMaximum());
            gestionTransaction.AddRule(new SoldeValidation(800));

            //création des transactions
            var depot = new Depot("Depôt", 60000, DateTime.Now);
            var retrait = new Retrait("Retrait", 8000, DateTime.Now);

            //Lancement des transactions
            gestionTransaction.ExecutionTransaction(depot);
            gestionTransaction.ExecutionTransaction(retrait);


        }
    }

}