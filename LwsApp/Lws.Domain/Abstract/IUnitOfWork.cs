namespace Lws.Domain.Abstract
{
    public interface IUnitOfWork
    {
        ISensorsRepository Sensors { get; }
        IValuesRepository Values { get; }
        void Save();
    }
}
