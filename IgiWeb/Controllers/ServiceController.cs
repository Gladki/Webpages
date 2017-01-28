using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IgiWeb.Controllers
{
    public class ServiceController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

		public ActionResult OsobyPrywatne()
		{
			return View();
		}

		public ActionResult MSP()
		{
			return View();
		}

		public ActionResult KlienciKorporacyjni()
		{
			return View();
		}
    }
}
