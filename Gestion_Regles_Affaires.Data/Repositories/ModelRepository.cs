using Gestion_Regles_Affaires.Data.Context;
using Gestion_Regles_Affaires.Data.interfaces;
using Gestion_Regles_Affaires.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gestion_Regles_Affaires.Data.Repositories
{
    public class ModelRepository : GenericRepository<Modele>, IModelRepository
    {
        public ModelRepository(ReglesAffairesContext context) : base(context)
        {
        }

        public IEnumerable<BroadcastCampaign> GetAllCampaigns()
        {
            var broadcastCampaignsList = this._context.BroadcastCampaigns.ToList();

            if(broadcastCampaignsList == null)
            {
                throw new Exception("Broadcast campaigns list is null!");
            }

            return broadcastCampaignsList;
        }

        public IEnumerable<BroadcastCampaignDetails> GetCampaignDetailsById(int idBroadcastCampaign)
        {
            var broadcastCampaignDetailsList = this._context.BroadcastCampaigns
                .Include(m => m.BroadcastCampaignDetails).FirstOrDefault(bc => bc.Id == idBroadcastCampaign).BroadcastCampaignDetails.ToList();

            if (broadcastCampaignDetailsList == null)
            {
                throw new Exception($"Broadcast campaign details with id {idBroadcastCampaign} not found!");
            }

            return broadcastCampaignDetailsList;
        }

        public Modele GetModelDetails(int modelId)
        {
            Modele model = this._context.Models
                .Include(m => m.ModelBusinessRules)
                .ThenInclude(b => b.BusinessRules)
                .FirstOrDefault(m => m.ModelId == modelId);

            if (model == null)
            {
                throw new Exception($"Model with id {modelId} not found!");
            }

            return model;
        }

        public string Translate(string code, string laguage)
        {
            var a = this._context.Translations
                .FirstOrDefault(t => t.Key == code && t.Culture == laguage);

            if (a == null) 
                return null;

            return a.Value;
        }

        public void UpdateOfferResponse(int broadcastCampaignId, int empId, bool isConfirmed)
        {
            var b = this._context.BroadcastCampaignDetails
                .First(b => b.BroadcastCampaignId == broadcastCampaignId && b.EmployeeId == empId);

            if (b != null)
                b.IsConfirmed = isConfirmed;

            _context.SaveChanges();
                
        }
    }
}
