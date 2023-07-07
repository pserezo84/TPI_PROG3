﻿using App.Core.Business.Interfaces;
using App.Core.Data;
using App.Core.Entities;
using X.PagedList;

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
            return _mailRepository.GetEntradaById(1);
        }

        public IPagedList<Mail> GetEntradaById(int userId, int page = 1, int pageSize = 10)
        {
            var mails = _mailRepository.GetEntradaById(1);
            return mails.ToPagedList(page, pageSize);
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
            return _mailRepository.GetEnviadosById(1); ;
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