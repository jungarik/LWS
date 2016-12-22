using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lws.Domain.Abstract
{
    public interface ISensorsRepository
    {

        IQueryable<Sensor> GetAll();
        Sensor Get(string ssn);
        void Create(Sensor item);
        void Update(Sensor item);
        void Delete(string ssn);
    }
}
