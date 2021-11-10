using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class ModelBusinessRules
    {
        public int ModelId { get; set; }
        public Modele Model { get; set; }

        public int BusinessRulesId { get; set; }
        public BusinessRules BusinessRules { get; set; }

        // additional fields
        public string Value { get; set; }
        
    }
}
