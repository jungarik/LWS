using Lws.Domain.Models;

namespace Lws.Domain.Abstract
{
    public interface IRepositoryFactory
    {
        ISensorsRepository CreateSensorsRepository(LwsDbContext context);
        IValuesRepository CreateValuesRepository(LwsDbContext context);
    }
}
