using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Entities;
using App.Core.Business.Services;
using X.PagedList;

namespace App.Core.Business.Interfaces
{
    internal interface IMailService
    {
        IEnumerable<Mail> GetEntradaById(int userId);
        IPagedList<Mail> GetEntradaById(int userId, int page = 1, int pageSize = 10);
        IEnumerable<Mail> SearchString(string textToSearch);
        IEnumerable<Mail> SearchStringEnviados(string textToSearch);
        IEnumerable<Mail> GetEnviadosById(int userId);
        void AddMail(Mail mail);                
        int GetMaxMailIdByRemitenteId(int remitenteId);
        void AddDestinatario(Destinatario destinatario);
    }
}
