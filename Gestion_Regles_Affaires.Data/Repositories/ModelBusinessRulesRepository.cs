using Gestion_Regles_Affaires.Data.Context;
using Gestion_Regles_Affaires.Data.Entities;
using Gestion_Regles_Affaires.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Repositories
{
    public class ModelBusinessRulesRepository : GenericRepository<ModelBusinessRules>, IModelBusinessRulesRepository
    {
        public ModelBusinessRulesRepository(ReglesAffairesContext context) : base(context)
        {
        }
    }
}
