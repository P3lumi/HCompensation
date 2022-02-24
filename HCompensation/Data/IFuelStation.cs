using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Data
{
    public interface IFuelStation
    {
        Task<bool> Add(Task entity);
    }
}
