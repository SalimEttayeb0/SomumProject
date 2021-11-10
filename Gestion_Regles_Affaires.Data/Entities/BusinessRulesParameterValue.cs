using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class BusinessRulesParameterValue
    {
        [Key]
        public int Id { get; set; }

        public string Key { get; set; }

        public int BusinessRulesId { get; set; }

        [ForeignKey("BusinessRulesId")]
        public BusinessRules BusinessRules { get; set; }
    }
}
