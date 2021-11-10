using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class Modele
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModelId { get; set; }

        public string ModelName { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual ICollection<ModelBusinessRules> ModelBusinessRules { get; set; }
    }
}
