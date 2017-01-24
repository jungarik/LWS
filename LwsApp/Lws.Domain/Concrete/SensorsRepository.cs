using System.Linq;
using System.Data.Entity;
using Lws.Domain.Models;
using Lws.Domain.Abstract;

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

        public Sensor Get(int id)
        {
            return db.Sensors.Find(id);
        }

        public void Create(Sensor sensor)
        {
            db.Sensors.Add(sensor);
        }

        public void Update(Sensor sensor)
        {
            db.Entry(sensor).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Sensor sensor = db.Sensors.Find(id);
            if (sensor != null)
                db.Sensors.Remove(sensor);
        }
    }
}
