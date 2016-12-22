using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lws.Domain.Abstract;
using Lws.Domain.Concrete;
using System.Data.Entity;
using Lws.Domain;

namespace Lws.Web.Controllers
{
    public class HomeController : Controller
    {
        //IUnitOfWork unitOfWork;
       
        //public HomeController(IUnitOfWork unitOfWork)// Здесь надо использовать DI Ninj
        public HomeController()
        {}
        public ActionResult Index()
        {
            return View();
        }
    }
}