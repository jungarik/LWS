using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Lws.Domain.Abstract;
using Lws.Domain.Models;

namespace Lws.Domain.Concrete
{
    public class ValuesRepository :  IValuesRepository
    {
        private LwsDbContext db;

        public ValuesRepository(LwsDbContext context)
        {
            this.db = context;
        }

        public IQueryable<Value> GetAll()
        {
            return db.Values;
        }
        //ошибка может быть несколько значений
        public Value Get(int id)
        {
            return db.Values.Find(id);
        }

        public void Create(Value value)
        {
            db.Values.Add(value);
        }

        public void Update(Value value)
        {
            db.Entry(value).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Value value = db.Values.Find(id);
            if (value != null)
                db.Values.Remove(value);
        }
    }
}
