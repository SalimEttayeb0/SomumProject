using Gestion_Regles_Affaires.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.interfaces
{
    public interface IBusinessRulesRepository : IGenericRepository<BusinessRules>
    {
        BusinessRules GetBusinessRulesByCode(string title);
    }
}
