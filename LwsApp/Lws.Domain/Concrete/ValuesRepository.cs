using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lws.Domain.Abstract;

namespace Lws.Domain.Concrete
{
    public class ValuesRepository:IValuesRepository
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
        public Value Get(string ssn)
        {
            return db.Values.Find(ssn);
        }

        public void Create(Value value)
        {
            db.Values.Add(value);
        }

        public void Update(Value value)
        {
            db.Entry(value).State = EntityState.Modified;
        }

        public void Delete(string ssn)
        {
            Value value = db.Values.Find(ssn);
            if (value != null)
                db.Values.Remove(value);
        }
    }
}
