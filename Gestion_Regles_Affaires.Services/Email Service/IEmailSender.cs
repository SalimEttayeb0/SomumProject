using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Services.Email_Service
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
