using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Data
{
   public interface ICarServiceRepo
    {
        Task<bool> Add (Task entity);
        Task<bool> SaveChanges();
    }
}
