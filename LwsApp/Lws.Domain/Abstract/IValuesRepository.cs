using System.Linq;
using Lws.Domain.Models;

namespace Lws.Domain.Abstract
{
    public interface IValuesRepository
    {
        IQueryable<Value> GetAll();
        Value Get(int id);
        void Create(Value item);
        void Update(Value item);
        void Delete(int id);
    }
}
