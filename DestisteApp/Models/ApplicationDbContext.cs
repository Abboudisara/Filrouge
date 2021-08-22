using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }

        public DbSet<OperationModel> operations { get; set; }
        public DbSet<ReservationModel> Reservations { get; set; }
        public DbSet<DestisteApp.Models.ReservationModel> reservation { get; set; }
    }
}
