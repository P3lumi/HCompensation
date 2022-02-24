using HCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Data
{
    public class CarServiceRepo: ICarServiceRepo<CarOwner>
    {

        private readonly HCompensationContext _context;

        public CarServiceRepo(HCompensationContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(CarOwner entity)
        {
            _context.Add(entity);
                return await SaveChanges();
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }

}