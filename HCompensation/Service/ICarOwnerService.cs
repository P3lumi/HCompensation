using HCompensation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models
{
    public interface ICarOwnerService
    {
        Task<bool> AddCarOwner(CarOwnerVM carOwnerVM);
    }
}
