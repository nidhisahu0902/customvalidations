using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using customValidations.Models;

namespace customValidations.Controllers
{ 

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Index(Employee emp)
    {
        if (ModelState.IsValid)
        {
            ModelState.Clear();  //for clearing data after submission
            return View();
        }
        return View();
    }
}
}
    