using Gestion_Regles_Affaires.Data.Context;
using Gestion_Regles_Affaires.Data.interfaces;
using Gestion_Regles_Affaires.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gestion_Regles_Affaires.Data.Repositories
{
    public class BusinessRulesRepository : GenericRepository<BusinessRules>, IBusinessRulesRepository
    {
        public BusinessRulesRepository(ReglesAffairesContext context) : base(context)
        {
        }

        public BusinessRules GetBusinessRulesByCode(string code)
        {
            BusinessRules businessRules = this._context.BusinessRules
                .Include(br => br.BusinessRulesParameterValues)
                .FirstOrDefault(br => br.Code == code);

            return businessRules;
        }
    }
}
