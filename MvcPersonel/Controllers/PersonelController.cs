using MvcPersonel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPersonel.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult SimplePage()
        {
            var personelinfo = new Personel();
            personelinfo.PersonelId = 8;
            personelinfo.PersonelName = "Samed";
            return View(personelinfo);
        }
    }
}