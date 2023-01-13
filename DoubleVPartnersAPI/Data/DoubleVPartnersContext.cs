using DoubleVPartnersAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoubleVPartnersAPI.Data
{
    public class DoubleVPartnersContext : DbContext
    {
        public DoubleVPartnersContext(DbContextOptions<DoubleVPartnersContext> options) : base(options)
        {

        }
        public DbSet<TKS_TICKETS> TKS_TICKETS { get; set; }
    }
}
