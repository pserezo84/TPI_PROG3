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

        public IActionResult bandeja()
        {
           
            return View();
        }
    }
}
