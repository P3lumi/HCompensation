using HCompensation.Data;
using HCompensation.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Models
{
    public class CarOwnerService : ICarOwnerService
    {
        private readonly ICarServiceRepo _carServiceRepo;
        public CarOwnerService(ICarServiceRepo carServiceRepo)
        {
            _carServiceRepo = carServiceRepo;
        }
        public async Task<bool> AddCarOwner(CarOwnerVM carOwnerVM)
        {
            var c = new CarOwner();


            var response = await _carServiceRepo.Add(c);
            if (!response)
                return false;

            return true;

        }
    }
}
