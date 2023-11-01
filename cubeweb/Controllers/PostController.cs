using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cubeweb.Controllers
{
    public class PostController : Controller
    {
        /// <summary>
        /// 글목록
        /// </summary>
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// 글보기
        /// </summary>
        public ActionResult ViewPost()
        {
            return View();
        }

        /// <summary>
        /// 글쓰기
        /// </summary>
        public ActionResult Write()
        {
            return View();
        }
    }
}