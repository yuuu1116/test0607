using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410921896_楊舒語.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(string name, string number)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if(number.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入1~7數字";
            }
            return View();
        }
    }
}