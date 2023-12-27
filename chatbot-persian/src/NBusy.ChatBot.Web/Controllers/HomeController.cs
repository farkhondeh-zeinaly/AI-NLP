using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NBusy.ChatBot.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }


        public ActionResult Index()
        {
            if (Session["ChatBot"] == null)
            {
                Session["ChatBot"] = new ChatBot("ConsoleUser", Server.MapPath("~/bin"), "settings.xml");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ربات چت فارسی";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "تماس با ما";

            return View();
        }

        [HttpPost]
        public JsonResult Chat(string inputText)
        {
            string response = "";

            if (Session["ChatBot"] != null)
            {
                var chatBot = (ChatBot)Session["ChatBot"];
                response = chatBot.Chat(inputText);
            }

            return Json(response);

        }
    }
}