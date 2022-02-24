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
    }
}
