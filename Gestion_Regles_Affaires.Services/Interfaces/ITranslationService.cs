using Gestion_Regles_Affaires.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Services.Interfaces
{
    public interface ITranslationService
    {
        string Translate(string key , string laguage); 
    }
}
