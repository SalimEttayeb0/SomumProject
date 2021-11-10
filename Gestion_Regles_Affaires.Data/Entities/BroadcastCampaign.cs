using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class BroadcastCampaign
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // needs to be changed with another table contains all status
        public string Status { get; set; }

        public virtual ICollection<BroadcastCampaignDetails> BroadcastCampaignDetails { get; set; }
    }
}
