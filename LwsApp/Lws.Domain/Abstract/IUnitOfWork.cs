using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lws.Domain.Abstract
{
    public interface IUnitOfWork
    {
        ISensorsRepository Sensors { get; }
        IValuesRepository Values { get; }
        void Save();
    }
}
