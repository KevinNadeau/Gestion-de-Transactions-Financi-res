using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Système_de_Gestion_de_Transactions_Financières.Typetransaction;

namespace Système_de_Gestion_de_Transactions_Financières.ConditionValidation
{
    public interface IValidationCondition
    {
        bool Validate(Transaction transaction);
    }
}
