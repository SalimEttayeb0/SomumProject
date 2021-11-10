using Gestion_Regles_Affaires.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Gestion_Regles_Affaires.Models;
using Gestion_Regles_Affaires.Services.Email_Service;
using Microsoft.AspNetCore.Authorization;

namespace Gestion_Regles_Affaires.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelServices _modelServices;
        private readonly IEmailSender _emailSender;

        public ModelController(IModelServices modelServices, IEmailSender emailSender)
        {
            _modelServices = modelServices;
            _emailSender = emailSender;
        }

        [HttpGet("GetAllModels")]
        public IActionResult GetAllModele()
        {

            var listModels = _modelServices.GetAllModels();
            return Ok(listModels);
        }

        [HttpPost("AddModelBusinessRules")]
        public IActionResult AddModelBusinessRules(BusinessRulesList businessRulesList)
        {
            _modelServices.AddModelBusinessRules(businessRulesList);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteModelById")]
        public IActionResult DeleteModel(int modelId)
        {
            _modelServices.DeleteModelById(modelId);
            return Ok();
        }

        [HttpGet]
        [Route("GetModelDetails/{modelId:int}")]
        public IActionResult GetModelDetails(int modelId)
        {
            BusinessRulesList businessRulesList = _modelServices.GetModelDetails(modelId);
            return Ok(businessRulesList);
        }

        [HttpGet]
        [Route("GetCallsScheduleModel")]
        public IActionResult GetCallsScheduleModel(string languageCode)
        {
            var callsScheduleModel = _modelServices.GetCallsScheduleModel(languageCode);
            return Ok(callsScheduleModel);
        }

        [HttpGet]
        [Route("GetContactGroups")]
        public IActionResult GetContactGroups(string languageCode)
        {
            var contactGroups = _modelServices.GetContactGroups(languageCode);
            return Ok(contactGroups);
        }

        [HttpGet]
        [Route("GetEmployeeClassifications")]
        public IActionResult GetEmployeeClassifications(string languageCode)
        {
            var employeeClassifications = _modelServices.GetEmployeeClassifications(languageCode);
            return Ok(employeeClassifications);
        }

        [HttpGet]
        [Route("GetAllAssistants")]
        public IActionResult GetAllAssistants(string languageCode)
        {
            var assistants = _modelServices.GetAllAssistants(languageCode);
            return Ok(assistants);
        }

        [HttpGet]
        [Route("SendEmailNotification")]
        public IActionResult SendEmailNotification ()
        {
            var message = new Message(new string[] { "haythem.khlifi@wijaa.com" }, "Confirmer offre", "This is the content from our email.");
            _emailSender.SendEmail(message);
            return Ok();
        }

        [HttpGet]
        [Route("UpdateOfferResponse/{broadcastCampaignId}/{empId}/{isConfirmed}")]
        public IActionResult UpdateOfferResponse(int broadcastCampaignId, int empId, bool isConfirmed)
        {
            _modelServices.UpdateOfferResponse(broadcastCampaignId, empId, isConfirmed);
            return Ok();
        }

        [HttpGet]
        [Route("GetAllCampaigns")]
        public IActionResult GetAllCampaigns()
        {
            var result = _modelServices.GetAllCampaigns();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCampaignDetailsById/{idBroadcastCampaign:int}")]
        public IActionResult GetCampaignDetailsById(int idBroadcastCampaign)
        {
            var result = _modelServices.GetCampaignDetailsById(idBroadcastCampaign);
            return Ok(result);
        }
    }
}
