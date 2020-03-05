using Microsoft.EntityFrameworkCore;
using SharentAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Data
{
    public class DomainContext : DbContext
    {
        public DomainContext(DbContextOptions<DomainContext> options): base(options)
        {   }

        public DbSet<User> Users { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Realty> Realties { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}
