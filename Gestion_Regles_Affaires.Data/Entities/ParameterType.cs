using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class ParameterType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<BusinessRules> BusinessRules { get; set; }
    }
}
