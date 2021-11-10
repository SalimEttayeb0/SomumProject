using Gestion_Regles_Affaires.Data.interfaces;
using Gestion_Regles_Affaires.Data.Entities;
using Gestion_Regles_Affaires.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Regles_Affaires.Models;
using System.Reflection;

namespace Gestion_Regles_Affaires.Services.Services
{
    public class ModelServices : IModelServices
    {
        public readonly IModelRepository _modelRepository;
        public readonly IBusinessRulesRepository _businessRulesRepository;
        public readonly IModelBusinessRulesRepository _modelBusinessRulesRepository;
        public readonly ITranslationService _translationService;

        public ModelServices(ITranslationService translationService, IModelRepository modelRepository, IBusinessRulesRepository businessRulesRepository, IModelBusinessRulesRepository modelBusinessRulesRepository)
        {
            _modelRepository = modelRepository;
            _businessRulesRepository = businessRulesRepository;
            _modelBusinessRulesRepository = modelBusinessRulesRepository;
            _translationService = translationService;
        }

        public IEnumerable<Modele> GetAllModels()
        {
            return _modelRepository.GetAll();
        }

        public void AddModelBusinessRules(BusinessRulesList businessRulesList)
        {
            Modele model = new Modele();
            model.ModelName = businessRulesList.Name;
            model.CreationDate = DateTime.Now;
            model.ModelBusinessRules = new List<ModelBusinessRules>();

            foreach (PropertyInfo propertyInfo in businessRulesList.GetType().GetProperties())
            {
                if (propertyInfo.Name == "Name")
                {
                    continue;
                }

                BusinessRules businessRule = this._businessRulesRepository.GetBusinessRulesByCode(propertyInfo.Name);

                if (businessRule == null)
                {
                    throw new Exception($"Could not found Business Rule with Code {propertyInfo.Name}");
                }
                object x = propertyInfo.GetValue(businessRulesList);

                if(x != null)
                {
                    model.ModelBusinessRules.Add(new ModelBusinessRules { BusinessRules = businessRule, Value = x.ToString() });
                }
            }

            _modelRepository.Add(model);
            _modelRepository.Save();
        }

        public void DeleteModelById(int modelId)
        {
            Modele model = _modelRepository.GetById(modelId);
            if(model == null)
            {
                throw new Exception($"Could not found a model with an id {modelId}");
            }

            _modelRepository.Delete(model.ModelId);
            _modelRepository.Save();
        }

        public BusinessRulesList GetModelDetails(int modelId)
        {
            Modele model = _modelRepository.GetModelDetails(modelId);

            BusinessRulesList result = new BusinessRulesList 
            { 
                Name = model.ModelName,
                PersonsNumber = int.Parse(model.ModelBusinessRules.First(mbr => mbr.BusinessRules.Code == "PersonsNumber").Value),
                StartDate = DateTime.Parse(model.ModelBusinessRules.First(mbr => mbr.BusinessRules.Code == "StartDate").Value),
                EndDate = DateTime.Parse(model.ModelBusinessRules.First(mbr => mbr.BusinessRules.Code == "EndDate").Value),
                WorkHoursNumber = int.Parse(model.ModelBusinessRules.First(mbr => mbr.BusinessRules.Code == "WorkHoursNumber").Value),
                PauseHoursNumber = int.Parse(model.ModelBusinessRules.First(mbr => mbr.BusinessRules.Code == "PauseHoursNumber").Value),
                MinimumHoursOutOfTotalHours = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "MinimumHoursOutOfTotalHours")?.Value),
                WorkingMaximumTotalHours = ToNullableDateTime(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "WorkingMaximumTotalHours")?.Value),
                CallBasedOnOvertime = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "CallBasedOnOvertime")?.Value),
                CallBasedOnSeniority = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "CallBasedOnSeniority")?.Value),
                CallBasedOnFullTimeEmployee = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "CallBasedOnFullTimeEmployee")?.Value),
                MaximumOvertime = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "MaximumOvertime")?.Value),
                MaximumWorkingHours = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "MaximumWorkingHours")?.Value),
                TimeBeforeShift = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "TimeBeforeShift")?.Value),
                TimeAfterShift = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "TimeAfterShift")?.Value),
                AttemptNumberOfNotJoined = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "AttemptNumberOfNotJoined")?.Value),
                AttemptNumberOfAllContacts = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "AttemptNumberOfAllContacts")?.Value),
                TimeBetweenCalls = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "TimeBetweenCalls")?.Value),
                BroadcastPriority = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "BroadcastPriority")?.Value),
                ManualContactEmails = model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "ManualContactEmails")?.Value,
                EmployeeClassification = model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "EmployeeClassification")?.Value,
                CallScheduleModel = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "CallScheduleModel")?.Value),
                ContactGroupsPriorities = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "ContactGroupsPriorities")?.Value),
                CallDuringWorkingHoursOnly = Convert.ToBoolean(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "CallDuringWorkingHoursOnly").Value),
                CompanyEmployeeFirst = Convert.ToBoolean(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "CompanyEmployeeFirst").Value),
                ContinueWithTheSameList = Convert.ToBoolean(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "ContinueWithTheSameList").Value),
                DoNotRecontactBlackListedMembersForTheSameDay = Convert.ToBoolean(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "DoNotRecontactBlackListedMembersForTheSameDay").Value),
                SplitTheCall = Convert.ToBoolean(model.ModelBusinessRules.FirstOrDefault(mbr => mbr.BusinessRules.Code == "SplitTheCall").Value),
                ChooseAssistant = ToNullableInt(model.ModelBusinessRules.FirstOrDefault(mbr =>mbr.BusinessRules.Code == "ChooseAssistant")?.Value)
            };

            return result;
        }

        public IEnumerable<ParameterValue> GetCallsScheduleModel(string languageCode)
        {
            BusinessRules businessRules = _businessRulesRepository.GetBusinessRulesByCode("CallScheduleModel");
            List<ParameterValue> parameterValues = new List<ParameterValue>();

            foreach (BusinessRulesParameterValue businessRulesParameterValue in businessRules.BusinessRulesParameterValues)
            {
                parameterValues.Add(
                    new ParameterValue {
                        Id = businessRulesParameterValue.Id,
                        BusinessRuleId = businessRulesParameterValue.BusinessRulesId,
                        Name = this._translationService.Translate(businessRulesParameterValue.Key, languageCode)
                    });
            }

            return parameterValues;
        }
        public IEnumerable<ParameterValue> GetContactGroups(string languageCode)
        {
            BusinessRules businessRules = _businessRulesRepository.GetBusinessRulesByCode("ContactGroupsPriorities");
            List<ParameterValue> parameterValues = new List<ParameterValue>();

            foreach (BusinessRulesParameterValue businessRulesParameterValue in businessRules.BusinessRulesParameterValues)
            {
                parameterValues.Add(
                    new ParameterValue
                    {
                        Id = businessRulesParameterValue.Id,
                        BusinessRuleId = businessRulesParameterValue.BusinessRulesId,
                        Name = this._translationService.Translate(businessRulesParameterValue.Key, languageCode)
                    });
            }

            return parameterValues;
        }

        public IEnumerable<CheckBoxParameterValue> GetEmployeeClassifications(string languageCode)
        {
            BusinessRules businessRules = _businessRulesRepository.GetBusinessRulesByCode("EmployeeClassification");
            List<CheckBoxParameterValue> parameterValues = new List<CheckBoxParameterValue>();

            foreach(BusinessRulesParameterValue businessRulesParameterValue in businessRules.BusinessRulesParameterValues)
            {
                parameterValues.Add(
                    new CheckBoxParameterValue
                    {
                        Id = businessRulesParameterValue.Id,
                        BusinessRuleId = businessRulesParameterValue.BusinessRulesId,
                        Name = this._translationService.Translate(businessRulesParameterValue.Key, languageCode),
                        IsChecked = false,
                    });
            }

            return parameterValues;
        }

        private int? ToNullableInt(string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

        private DateTime? ToNullableDateTime(string s)
        {
            DateTime i;
            if (DateTime.TryParse(s, out i)) return i;
            return null;
        }

        public IEnumerable<ParameterValue> GetAllAssistants(string languageCode)
        {
            BusinessRules businessRules = _businessRulesRepository.GetBusinessRulesByCode("ChooseAssistant");
            List<ParameterValue> parameterValues = new List<ParameterValue>();

            foreach (BusinessRulesParameterValue businessRulesParameterValue in businessRules.BusinessRulesParameterValues)
            {
                parameterValues.Add(
                    new ParameterValue
                    {
                        Id = businessRulesParameterValue.Id,
                        BusinessRuleId = businessRulesParameterValue.BusinessRulesId,
                        Name = this._translationService.Translate(businessRulesParameterValue.Key, languageCode)
                    });
            }

            return parameterValues;
        }

        public void UpdateOfferResponse(int broadcastCampaignId, int empId, bool isConfirmed)
        {
            _modelRepository.UpdateOfferResponse(broadcastCampaignId, empId, isConfirmed);
        }

        public IEnumerable<Campaign> GetAllCampaigns()
        {
            var broadcastCampaignList = _modelRepository.GetAllCampaigns();
            List<Campaign> broadcastCampaignsModel = new List<Campaign>();
            
            foreach (BroadcastCampaign broadcastCampaign in broadcastCampaignList)
            {
                broadcastCampaignsModel.Add(
                    new Campaign
                    {
                        Id = broadcastCampaign.Id,
                        StartDate = broadcastCampaign.StartDate,
                        endDate = broadcastCampaign.EndDate,
                        Status = broadcastCampaign.Status
                    });
            }

            return broadcastCampaignsModel;
        }

        public IEnumerable<CampaignDetails> GetCampaignDetailsById(int idBroadcastCampaign)
        {
            var broadcastCampaignDetailsList = _modelRepository.GetCampaignDetailsById(idBroadcastCampaign);
            List<CampaignDetails> broadcastCampaignsDetailsModel = new List<CampaignDetails>();

            foreach (BroadcastCampaignDetails broadcastCampaignDetails in broadcastCampaignDetailsList)
            {
                broadcastCampaignsDetailsModel.Add(
                    new CampaignDetails
                    {
                        Id = broadcastCampaignDetails.Id,
                        BroadcastCampaignId = broadcastCampaignDetails.BroadcastCampaignId,
                        ConfirmationType = broadcastCampaignDetails.ConfirmationType,
                        EmployeeId = broadcastCampaignDetails.EmployeeId,
                        EmployeeName = broadcastCampaignDetails.EmployeeName,
                        IsConfirmed = broadcastCampaignDetails.IsConfirmed,
                        OfferResponse = broadcastCampaignDetails.OfferResponse
                    });
            }

            return broadcastCampaignsDetailsModel;
        }
    }
}
