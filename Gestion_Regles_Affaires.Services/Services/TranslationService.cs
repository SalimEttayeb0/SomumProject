using Gestion_Regles_Affaires.Data.interfaces;
using Gestion_Regles_Affaires.Models;
using Gestion_Regles_Affaires.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Services.Services
{
    public class TranslationService : ITranslationService
    {
        public readonly IModelRepository _modelRepository;
        public TranslationService(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }
        public string Translate(string key, string laguage)
        {
            return _modelRepository.Translate(key, laguage);
        }
    }
}
