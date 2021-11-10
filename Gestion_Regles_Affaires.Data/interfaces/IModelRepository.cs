using Gestion_Regles_Affaires.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.interfaces
{
    public interface IModelRepository : IGenericRepository<Modele>
    {
        Modele GetModelDetails(int modelId);
        string Translate(string code, string laguage);
        void UpdateOfferResponse(int broadcastCampaignId, int empId, bool isConfirmed);
        IEnumerable<BroadcastCampaign> GetAllCampaigns();
        IEnumerable<BroadcastCampaignDetails> GetCampaignDetailsById(int idBroadcastCampaign);
    }
}
