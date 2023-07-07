using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Entities;
using App.Core.Business.Services;

namespace App.Core.Business.Interfaces
{
    internal interface IMailService
    {
        IEnumerable<Mail> GetEntradaById(int userId);
        IEnumerable<Mail> SearchString(string textToSearch);
        IEnumerable<Mail> SearchStringEnviados(string textToSearch);
        IEnumerable<Mail> GetEnviadosById(int userId);
        void AddMail(Mail mail);                
        int GetMaxMailIdByRemitenteId(int remitenteId);
        void AddDestinatario(Destinatario destinatario);
    }
}
