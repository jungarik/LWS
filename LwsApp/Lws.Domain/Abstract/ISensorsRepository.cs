using System.Linq;
using Lws.Domain.Models;

namespace Lws.Domain.Abstract
{
    public interface ISensorsRepository
    {

        IQueryable<Sensor> GetAll();
        Sensor Get(int id);
        void Create(Sensor item);
        void Update(Sensor item);
        void Delete(int id);
    }
}
