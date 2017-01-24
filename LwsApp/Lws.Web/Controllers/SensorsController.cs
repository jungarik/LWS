using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Lws.Domain;
using Lws.Domain.Concrete;
using Lws.Domain.Abstract;
using Lws.Domain.Models;

namespace Lws.Web.Controllers
{
    public class SensorsController : ApiController
    {
        private readonly ISensorsRepository sensorsRepo;
        LwsDbContext db;
        public SensorsController()
        {
            db = new LwsDbContext();
            this.sensorsRepo = new SensorsRepository(db);
        }
        public IEnumerable<Sensor> GetSensors()
        {
            return sensorsRepo.GetAll().Include(e => e.User.UserProfile);
        }
    }
}
