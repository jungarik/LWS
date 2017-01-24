using System;
using Lws.Domain.Abstract;
using Lws.Domain.Models;

namespace Lws.Domain.Concrete
{
    public class UoW : IUnitOfWork
    {
        // Агрегация
        private LwsDbContext db;
        private ISensorsRepository sensorsRepository;
        private IValuesRepository valuesRepository;

        IRepositoryFactory repoFactory;

        public UoW(IRepositoryFactory repoFactory)
        {
            this.repoFactory = repoFactory;
            db = new LwsDbContext();
        }

        public ISensorsRepository Sensors
        {
            get
            {
                if (sensorsRepository == null)
                    // Агрегация
                    sensorsRepository = repoFactory.CreateSensorsRepository(db);
                //new OwnerRepository(db);
                return sensorsRepository;
            }
        }

        public IValuesRepository Values
        {
            get
            {
                if (valuesRepository == null)
                    valuesRepository = repoFactory.CreateValuesRepository(db);
                return valuesRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
