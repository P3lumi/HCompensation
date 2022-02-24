using HCompensation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Data
{
    public class FuelStationRepo : IFuelStationRepo<FuelStation>
    {
        private readonly HCompensationContext _context;

        public FuelStationRepo(HCompensationContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(FuelStation entity)
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
