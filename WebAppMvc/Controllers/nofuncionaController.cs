using App.Core.Business.Services;
using App.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc.Controllers
{
    public class nofuncionaController : Controller
    {
        public MailService mailService { get; set; }


        public nofuncionaController(MailService mailService)
        {
            this.mailService = mailService;
        }


        // GET: nofuncionaController
        public IActionResult Index()
        {
            //var mails = mailService.GetAllMails();
            return View();
        }

        // GET: nofuncionaController/Details/5
        public IActionResult Detalle(int id)
        {   
            var mail = new Mail() 
            { 
                Id = id,
                Asunto=$"Asunto {id}",
                Contenido =$"Contenido {id}"
            }; 
            return View(mail);
        }

      

        //// GET: nofuncionaController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: nofuncionaController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: HomeController1/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: nofuncionaController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: nofuncionaController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: HomeController1/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
