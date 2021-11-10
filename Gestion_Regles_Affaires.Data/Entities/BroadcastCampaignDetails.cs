using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public class BroadcastCampaignDetails
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        // needs to be changed with another table contains all responses
        public string OfferResponse { get; set; }

        // needs to be changed with another table contains all responses
        public string ConfirmationType { get; set; }

        public int BroadcastCampaignId { get; set; }

        public bool IsConfirmed { get; set; }

        [ForeignKey("BroadcastCampaignId")]
        public BroadcastCampaign BroadcastCampaign { get; set; }
    }
}
