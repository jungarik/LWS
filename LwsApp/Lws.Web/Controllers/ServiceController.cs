using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Lws.Domain.Concrete;
using Lws.Domain.Abstract;
using Lws.Domain.Models;


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
            db = new LwsDbContext();
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
        public ActionResult Details(int id)
        {
            Sensor sensor = sensorsRepo.Get(id);
            return PartialView("_Details", sensor);
        }
        public ActionResult Values(int id)
        {
            var values = valuesRepo.GetAll().Where(value => value.Id == id);
            return PartialView("_Values", values);
        }
        public ActionResult States(int id)
        {
            var sensor = sensorsRepo.Get(id);
            //var state = sensor.States.First();
            return PartialView("_States", sensor.States);
        }
        public ActionResult Map()
        {
            //var sensor = sensorsRepo.Get(ssn);
            return View("Map");
        }
        public ActionResult Edit(int id)
        {
            var sensor = sensorsRepo.Get(id);
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