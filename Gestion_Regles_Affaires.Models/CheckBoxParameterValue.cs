using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Regles_Affaires.Models
{
    public class CheckBoxParameterValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusinessRuleId { get; set; }

        public bool IsChecked { get; set; }
    }
}
