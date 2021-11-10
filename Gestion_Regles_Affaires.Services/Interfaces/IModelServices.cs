using Gestion_Regles_Affaires.Data.Entities;
using Gestion_Regles_Affaires.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Services.Interfaces
{
    public interface IModelServices
    {
        IEnumerable<Modele> GetAllModels();
        void AddModelBusinessRules(BusinessRulesList businessRulesList);
        void DeleteModelById(int modelId);
        BusinessRulesList GetModelDetails(int modelId); 
        IEnumerable<ParameterValue> GetCallsScheduleModel(string languageCode);
        IEnumerable<ParameterValue> GetContactGroups(string languageCode);
        IEnumerable<CheckBoxParameterValue> GetEmployeeClassifications(string languageCode);
        IEnumerable<ParameterValue> GetAllAssistants(string languageCode);
        void UpdateOfferResponse(int broadcastCampaignId, int empId, bool isConfirmed);
        IEnumerable<Campaign> GetAllCampaigns();
        IEnumerable<CampaignDetails> GetCampaignDetailsById(int idBroadcastCampaign);
    }

}
