using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Final_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearCuenta()
        {
            return View("~/Views/Home/Profesional.cshtml");
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

        public ActionResult ContactoLogueado()
        {
            return View();
        }
    }
}