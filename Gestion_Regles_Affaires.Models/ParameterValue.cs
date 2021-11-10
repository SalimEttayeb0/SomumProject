using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Regles_Affaires.Models
{
    public class ParameterValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusinessRuleId { get; set; }
    }
}
