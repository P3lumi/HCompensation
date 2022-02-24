using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Data
{
    public interface IFuelStationRepo<T>
    {
        Task<bool> Add(T entity);
        Task<bool> SaveChanges();
    }
}
