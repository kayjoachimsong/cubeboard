using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cubeweb.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 메인 홈
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
    }
}