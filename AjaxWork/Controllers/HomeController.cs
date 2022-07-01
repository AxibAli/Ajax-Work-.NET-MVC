using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWork.Models;

namespace AjaxWork.Controllers
{
    public class HomeController : Controller
    {
        AjaxResponse ajaxResponse;
        string message = string.Empty;
        bool response;
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(AjaxModel aw)
        {
            if (ModelState.IsValid)
            {
                message = "Successfull";
                response = true;
            }
            else
            {
                message = "Not Successfull";
                response = false;
            }

            //ModelState.Clear();
            ajaxResponse = new AjaxResponse { Message = message, Response = response };
            //RedirectToAction("Index", "Home");
            return Json(ajaxResponse);




        }
        [HttpGet]
        public ActionResult addstudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addstudent(StudentModel stdmodel)
        {
            if (ModelState.IsValid)
            {
                message = "Successfull";
                response = true;
            }
            else
            {
                message = "Not Successfull";
                response = false;
            }
            
            ajaxResponse = new AjaxResponse { Message = message, Response = response };
            return Json(ajaxResponse);
        }
        [HttpGet]
        public ActionResult addteacher()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addteacher(TeacherModel teamodel)
        {

            if (ModelState.IsValid)
            {
                message = "Successfull";
                response = true;
            }
            else
            {
                message = "Not Successfull";
                response = false;
            }

            ajaxResponse = new AjaxResponse { Message = message, Response = response };
            return Json(ajaxResponse);

        }

    }
}