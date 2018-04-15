using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using davIT.Models;
using System.Threading;

namespace davIT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmailMessage log = new EmailMessage("Wywołanie Index", "Wywołanie Index", "Wywołanie Index", Request);
            //ThreadPool.QueueUserWorkItem(EmailMessage.Send, log);
            CompanyTexts.Name = CompanyTexts.GetIndexName();
            return View();
        }

        public ActionResult Futures()
        {
            CompanyTexts.Name = CompanyTexts.GetFuturesName();
            return View();
        }

        public ActionResult About()
        {
            CompanyTexts.Name = CompanyTexts.GetAboutName();
            return View();
        }

        public ActionResult Contact()
        {
            CompanyTexts.Name = CompanyTexts.GetContactName();
            return View();
        }

        [HttpPost]
        public ActionResult Contact(EmailMessage emailMessage)
        {
            emailMessage.Request = Request;
            EmailMessage.Send(emailMessage);
            return RedirectToAction("Contact");
        }

        public ActionResult Eat2Day()
        {
            //https://www.facebook.com/Eat2Day-268779546878264/
            //bla bla bla

            return View("Contact");
        }
    }
}
