using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lws.Domain.Abstract
{
    public interface IValuesRepository
    {
        IQueryable<Value> GetAll();
        Value Get(string ssn);
        void Create(Value item);
        void Update(Value item);
        void Delete(string ssn);
    }
}
