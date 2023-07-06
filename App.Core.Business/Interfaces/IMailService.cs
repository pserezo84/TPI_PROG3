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
        IEnumerable<Mail> GetAllMails();
        IEnumerable<Mail> GetMailById(int id);
        void AddMail(Mail mail);
    }
}
