using App.Core.Business.Interfaces;
using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business.Services
{
    public class MailService: IMailService
    {
        private readonly MailRepository _mailRepository;


        public MailService()
        {
            _mailRepository = new MailRepository();
        }


        //public List<Mail> Search(string textToSearch) {

        //    //Validar textToSearch
        //    //Paginar

        //    return _mailRepository.Search(textToSearch); ;
        //}

        public IEnumerable<Mail> GetAllMails()
        {
            return _mailRepository.GetAll();
        }

        public Mail GetMailById(int id)
        {
            return _mailRepository.GetById(id); ;
        }

        public void AddMail(Mail mail)
        {
            _mailRepository.Add(mail);
        }

    }
}