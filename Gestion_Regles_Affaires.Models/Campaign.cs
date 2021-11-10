using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Regles_Affaires.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime endDate { get; set; }
        public string Status { get; set; }
    }
}
