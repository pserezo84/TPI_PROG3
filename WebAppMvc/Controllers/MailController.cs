using Microsoft.AspNetCore.Mvc;
using App.Core.Business;
using App.Core.Business.Services;
using App.Core.Entities;

namespace WebAppMvc.Controllers
{
    public class MailController : Controller
    {

        private readonly MailService mailService;

        public int userID { get; set; }

        public MailController(MailService mailService)
        {
            this.mailService = mailService;
            this.userID = 1;
        }

        public IActionResult Index()
        {
            var mails = mailService.GetEntradaById(userID);
            return View(mails);
        }
        //##################################################//
        //##### Bandeja de entrada #########################//
        public IActionResult BandejaDeEntrada(string? textToSearch)
        {
            if (textToSearch is null)
            {
                var mails = mailService.GetEntradaById(userID);
                return View(mails);               
            }
            else {
                var mails = mailService.SearchString(textToSearch);
                return View(mails);
            }           

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

            var objDestinatario = new Destinatario()
            {
                Mail_id = maxId,
                Contacto_id = destinatario_id
            };

            mailService.AddDestinatario(objDestinatario);
            return View();
                        
        }


    }
}
