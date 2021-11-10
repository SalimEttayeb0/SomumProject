using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class BusinessRules
    {
        public int BusinessRulesId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool HasParameter { get; set; }
        public bool IsRequired { get; set; }

        [ForeignKey("ParameterTypeId")]
        public ParameterType ParameterType { get; set; }

        public int ParameterTypeId { get; set; }

        public virtual ICollection<ModelBusinessRules> ModelBusinessRules { get; set; }
        
        public virtual ICollection<BusinessRulesParameterValue> BusinessRulesParameterValues { get; set; }
        

    }
}
