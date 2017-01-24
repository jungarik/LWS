using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lws.Domain.Models;
using Lws.Domain.Concrete;
using Lws.Domain.Abstract;
using Lws.Web.Models;
using AutoMapper;
using Lws.Web.Models.Values;

namespace Lws.Web.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ISensorsRepository sensorsRepo;
        private readonly IValuesRepository valuesRepo;

        LwsDbContext db;
        // GET: Sensor
        public ValuesController()
        {
            db = new LwsDbContext();
            this.sensorsRepo = new SensorsRepository(db);
            this.valuesRepo = new ValuesRepository(db);
        }
        public IEnumerable<ValueViewModel> GetValues(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Value, ValueViewModel>());
            //IList<Value> values = new List<Value>();
            var values = valuesRepo.GetAll().Where(v => v.SensorId == id);
            var viewModel = Mapper.Map<IEnumerable<Value>, List<ValueViewModel>>(values.ToList());
            return viewModel;
        }
        [HttpPost]
        public void PostValues([FromBody]Value value)
        {
            if (ModelState.IsValid)
            {
                value.ServerDate = DateTime.Now;
                valuesRepo.Create(value);
                db.SaveChanges();
            }
        }

    }
}
