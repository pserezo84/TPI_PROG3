using Microsoft.AspNetCore.Mvc;
using App.Core.Business;
using App.Core.Business.Services;
using App.Core.Entities;
using System.Collections.Generic;

namespace App.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController : ControllerBase
    {
        
        private MailService _mailService;
        public MailController(MailService mailService) {
            _mailService = mailService;
        }

        [HttpGet("bandejaEntrada/{userId}")]
        public IActionResult GetBandejaEntrada(int userId)
        {
            var mails = _mailService.GetEntradaById(userId);
            return Ok(mails);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
