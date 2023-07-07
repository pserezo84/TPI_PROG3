using Microsoft.AspNetCore.Mvc;
using App.Core.Business;
using App.Core.Business.Services;
using App.Core.Entities;
using X.PagedList;

namespace WebAppMvc.Controllers
{
    public class MailController : Controller
    {

        private readonly MailService mailService;

        public int userID { get; set; }

        public MailController(MailService mailService)
        {
            this.mailService = mailService;
            this.userID = 2;
        }

        public IActionResult Index()
        {
            var mails = mailService.GetEntradaById(userID);
            return View(mails);
        }
        //##################################################//
        //##### Bandeja de entrada #########################//
        //public IActionResult BandejaDeEntrada(string? textToSearch)
        //{
        //    if (textToSearch is null)
        //    {
        //        var mails = mailService.GetEntradaById(userID);
        //        return View(mails);               
        //    }
        //    else {
        //        var mails = mailService.SearchString(textToSearch);
        //        return View(mails);
        //    }           

        //}
        public IActionResult BandejaDeEntrada(string? textToSearch, int page = 1, int pageSize = 5)
        {
            IPagedList<Mail> pagedMails;

            if (textToSearch is null)
            {
                var mails = mailService.GetEntradaById(userID);
                pagedMails = mails.ToPagedList(page, pageSize);
            }
            else
            {
                var mails = mailService.SearchString(textToSearch);
                pagedMails = mails.ToPagedList(page, pageSize);
            }

            return View(pagedMails);
        }

            //##################################################//
            //############## Elementos Enviados ################//
            public IActionResult ElementosEnviados(string? textToSearch)
        {
            if (textToSearch is null)
            {
                var mails = mailService.GetEnviadosById(userID);
                return View(mails);
            }
            else {
                var mails = mailService.SearchStringEnviados(textToSearch);
                return View(mails);
            }
        }


        //##################################################//
        //############## Enviar Mail #######################//
        public IActionResult EnviarCorreo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnviarCorreo(int destinatario_id, string asunto, string contenido)
        {
            DateTime ss = DateTime.Now;
            var objMail = new Mail()
            {
                Remitente_id = userID,
                Asunto = asunto,
                Contenido = contenido,
                FechaEnvio = ss
            };

            mailService.AddMail(objMail);
            
            var maxId = mailService.GetMaxMailIdByRemitenteId(userID);

            //Aca se debe recorrer si hay mas de un destinatario for del input

            var objDestinatario = new Destinatario()
            {
                Mail_id = maxId,
                Contacto_id = destinatario_id
            };

            mailService.AddDestinatario(objDestinatario);
            //aca termina el bucle

            return View();
                        
        }


    }
}
