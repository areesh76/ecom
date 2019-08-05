using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Commerce.DataServices;
using eCommerce.Models.Services;

namespace eCommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult a() {
            return View();
        }
        public ActionResult singleBlog() {
            return View();
        }
        public ActionResult services() {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult blog() {
            return View();
        }

        public ActionResult Contact() {
            return View();
        }

        public ActionResult AboutView() {
            return View();
        }
        public ActionResult Portfolio() {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult user() {
            return View();
        }
        public JsonResult NewUser(user model) {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            string msg = string.Empty;
            try { 
                if (model != null)
                {
                    DMLOperations.Instance.NewUser(model);
                    msg = "Sucessfully Added!";
                }
                else {
                    msg = "Model is empty";
                }
            }
            catch(Exception ex){
                msg = ex.Message;
            }
            result.Data = msg;
            return result;
        }
    }
}