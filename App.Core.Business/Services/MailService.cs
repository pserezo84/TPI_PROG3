using App.Core.Business.Interfaces;
using App.Core.Data;
using App.Core.Entities;

namespace App.Core.Business.Services
{
    public class MailService: IMailService
    {
        private readonly MailRepository _mailRepository;

        public int userId { get; set; }

        


        public MailService()
        {
            _mailRepository = new MailRepository();
            this.userId = 1;
        }


        //public List<Mail> Search(string textToSearch) {

        //    //Validar textToSearch
        //    //Paginar

        //    return _mailRepository.Search(textToSearch); ;
        //}

        public IEnumerable<Mail> GetAllMails(int userId) 
        {
            return _mailRepository.GetAll(userId);
        }

        public IEnumerable<Mail> SearchString(string textToSearch)
        {
            return _mailRepository.SearchString(textToSearch);
        }

        public IEnumerable<Mail> GetMailRemitenteById(int userId)
        {
            return _mailRepository.GetByRemitenteId(userId); ;
        }

        public void AddMail(Mail mail)
        {
            _mailRepository.Add(mail);
        }

        //SearchString



    }
}