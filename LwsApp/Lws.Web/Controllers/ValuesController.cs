﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lws.Domain;
using Lws.Domain.Concrete;
using Lws.Domain.Abstract;
using Lws.Web.Models;

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
            db = new Domain.LwsDbContext();
            this.sensorsRepo = new SensorsRepository(db);
            this.valuesRepo = new ValuesRepository(db);
        }
        public IEnumerable<Value> GetValues(string ssn)
        {
            IList<Value> values = new List<Value>();
            values = valuesRepo.GetAll().Where(e => e.SensorSsn == ssn).ToList();
            return values;
        }
        [HttpPost]
        public void PostValues(Value value)
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
