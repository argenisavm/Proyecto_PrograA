using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrograAvanzada.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(Models.LoginModel model)
        {
            return View(); //Por mientras
        }
    }

}