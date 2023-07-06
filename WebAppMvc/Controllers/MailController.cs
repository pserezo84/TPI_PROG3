using Microsoft.AspNetCore.Mvc;
using App.Core.Business;
using App.Core.Business.Services;


namespace WebAppMvc.Controllers
{
    public class MailController : Controller
    {

        private readonly MailService mailService;

        public MailController(MailService mailService)
        {
            this.mailService = mailService;
        }

        public IActionResult Index()
        {
            var mails = mailService.GetAllMails(1);
            return View(mails);
        }

        public IActionResult BandejaDeEntrada()
        {
            var mails = mailService.GetAllMails(1);
            return View(mails);
            
        }
        public IActionResult BandejaDeEntradaFiltro(string textToSearch)
        {
            var mails = mailService.SearchString(textToSearch);
            return View(mails);

        }
        public IActionResult ElementosEnviados()
        {
            var mails = mailService.GetMailRemitenteById(1);
            return View(mails);
        }
        public IActionResult EnviarCorreo()
        {            
            return View();
        }
        public IActionResult GetAsunto()
        {            
            return View();
        }
    }
}
