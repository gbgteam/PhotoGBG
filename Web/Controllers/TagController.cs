using DataAccessAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class TagController : Controller
    {
        //
        // GET: /Tag/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllTags()
        {
            var model = "x";
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddTag(ITag tag)
        {
            return Json("test",JsonRequestBehavior.AllowGet);
        }

        public JsonResult EditTag(ITag tag)
        {
            return Json("Test",JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteTag(int id)
        {
            return Json("test",JsonRequestBehavior.AllowGet);
        }

    }
}
