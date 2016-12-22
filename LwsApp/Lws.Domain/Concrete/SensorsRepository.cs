using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lws.Domain.Abstract;
using System.Data.Entity;

namespace Lws.Domain.Concrete
{
    public class SensorsRepository: ISensorsRepository
    {
        private LwsDbContext db;

        public SensorsRepository(LwsDbContext context)
        {
            this.db = context;
        }

        public IQueryable<Sensor> GetAll()
        {
            return db.Sensors;
        }

        public Sensor Get(string ssn)
        {
            return db.Sensors.Find(ssn);
        }

        public void Create(Sensor sensor)
        {
            db.Sensors.Add(sensor);
        }

        public void Update(Sensor sensor)
        {
            db.Entry(sensor).State = EntityState.Modified;
        }

        public void Delete(string ssn)
        {
            Sensor sensor = db.Sensors.Find(ssn);
            if (sensor != null)
                db.Sensors.Remove(sensor);
        }
    }
}
