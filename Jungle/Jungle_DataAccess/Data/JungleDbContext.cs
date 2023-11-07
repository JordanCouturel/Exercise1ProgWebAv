using Jungle_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_DataAccess.Data
{
    public class JungleDbContext: DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<TravelRecommendation> TravelRecommendations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Option> Options { get; set; }
        public JungleDbContext(DbContextOptions<JungleDbContext> options): base(options)
        {

        }
    }
}
