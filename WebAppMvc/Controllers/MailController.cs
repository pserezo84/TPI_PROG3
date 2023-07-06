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
            var mails = mailService.GetAllMails();
            return View(mails);
        }

        public IActionResult BandejaDeEntrada()
        {
            var mails = mailService.GetMailById(1);
            return View(mails);
            
        }
        public IActionResult ElementosEnviados()
        {

            return View();
        }

        public IActionResult GetAsunto()
        {
            var mails = mailService.GetMailById(4);
            return View(mails);
        }
    }
}
