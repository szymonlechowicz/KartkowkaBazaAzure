using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KartkowkaBazaAzure.Models;

namespace KartkowkaBazaAzure.Data
{
    public class KartkowkaBazaAzureContext : DbContext
    {
        public KartkowkaBazaAzureContext (DbContextOptions<KartkowkaBazaAzureContext> options)
            : base(options)
        {
        }

        public DbSet<KartkowkaBazaAzure.Models.Song> Song { get; set; }
    }
}
