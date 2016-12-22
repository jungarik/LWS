using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lws.Domain.Abstract
{
    public interface IRepositoryFactory
    {
        ISensorsRepository CreateSensorsRepository(LwsDbContext context);
        IValuesRepository CreateValuesRepository(LwsDbContext context);
    }
}
