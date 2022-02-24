using AutoMapper;
using HCompensation.Models;
using HCompensation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Utility
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarOwner, CarOwnerVM>();
        }

        public static CarOwner Map(CarOwnerVM model, string[] urls)
        {
            return new CarOwner
            {
                FullName = model.FullName,
                Email = model.Email,
                OwnershipUrl = urls[0],
                PurchaseUrl = urls[1]
            };
        }

        public static FuelStation Map(FuelStationVM model, string url)
        {
            return new FuelStation
            {
                BusinessName = model.BusinessName,
                Email = model.Email,
                LastSupplyDetails = model.LastSupplyDetails,
                TicketUrl= url,
                Location = model.Location
            };
        }

    }
}
