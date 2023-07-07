using Microsoft.EntityFrameworkCore;
using FDMC.Models;
using FDMC.Models.FDMC.Models;

namespace FDMC.Data
{
    public class FDMCContext : DbContext
    {
        public FDMCContext(DbContextOptions<FDMCContext> options) : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }
    }
}
