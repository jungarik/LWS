using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lws.Domain;
using Lws.Domain.Concrete;
using Lws.Domain.Abstract;
using System.Data.Entity;


namespace Lws.Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ISensorsRepository sensorsRepo;
        private readonly IValuesRepository valuesRepo;

        LwsDbContext db;
        // GET: Sensor
        public ServiceController()
        {
            db = new Domain.LwsDbContext();
            this.sensorsRepo = new SensorsRepository(db);
            this.valuesRepo = new ValuesRepository(db);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sensors()
        {
            var sensors = sensorsRepo.GetAll();
            return View(sensors);
        }
        public ActionResult Details(string ssn)
        {
            Sensor sensor = sensorsRepo.Get(ssn);
            return PartialView("_Details", sensor);
        }
        public ActionResult Values(string ssn)
        {
            var values = valuesRepo.GetAll().Where(value => value.SensorSsn == ssn);
            return PartialView("_Values", values);
        }
        public ActionResult States(string ssn)
        {
            var sensor = sensorsRepo.Get(ssn);
            //var state = sensor.States.First();
            return PartialView("_States", sensor.States);
        }
        public ActionResult Map(string ssn)
        {
            var sensor = sensorsRepo.Get(ssn);
            return PartialView("_Map", sensor);
        }
        public ActionResult Edit(string ssn)
        {
            var sensor = sensorsRepo.Get(ssn);
            return View();
        }
        //[HttpPost]
        //public ActionResult Edit(Sensor sensor)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }
        //}
    }
}