using HCompensation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCompensation.Data
{
    public class HCompensationContext: DbContext
    {
        public HCompensationContext(DbContextOptions<HCompensationContext> options) : base(options)
        {

        }

        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<FuelStation> FuelStations { get; set; }

    }
}
