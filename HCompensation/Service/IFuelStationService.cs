using HCompensation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Service
{
    public interface IFuelStationService
    {
        Task<bool> AddFuelStation(FuelStationVM fuelStationVM);
    }
}
