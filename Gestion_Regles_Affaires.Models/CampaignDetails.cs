using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Regles_Affaires.Models
{
    public class CampaignDetails
    {
        public int Id { get; set; }
        public int BroadcastCampaignId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string OfferResponse { get; set; }
        public string ConfirmationType { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
