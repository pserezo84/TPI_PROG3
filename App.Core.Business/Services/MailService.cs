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

        //################################################################//
        //####### Obtener bandeja de entrada por id ######################//
        public IEnumerable<Mail> GetEntradaById(int userId) 
        {
            return _mailRepository.GetEntradaById(userId);
        }

        //################################################################//
        //###### Buscar texto en bandeja de entrada ####################//
        public IEnumerable<Mail> SearchString(string textToSearch)
        {
            return _mailRepository.SearchString(textToSearch);
        }

        //################################################################//
        //###### Buscar texto en bandeja de enviados ####################//
        public IEnumerable<Mail> SearchStringEnviados(string textToSearch)
        {
            return _mailRepository.SearchStringEnviados(textToSearch);
        }

        //################################################################//
        //####### Obtener bandeja de salida por id ######################//
        public IEnumerable<Mail> GetEnviadosById(int userId)
        {
            return _mailRepository.GetEnviadosById(userId); ;
        }

        //################################################################//
        //############### Agregar nuevo Mail #############################//
        public void AddMail(Mail mail)
        {
            _mailRepository.AddMail(mail);
        }

        public int GetMaxMailIdByRemitenteId(int remitenteId)
        {
            return _mailRepository.GetMaxMailIdByRemitenteId(remitenteId);
        }

        public void AddDestinatario(Destinatario destinatario)
        {
            _mailRepository.AddDestinatario(destinatario);
        }


    }
}