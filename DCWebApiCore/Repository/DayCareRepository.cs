using DCWebApiCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace DCWebApiCore.Repository
{
    public class DayCareRepository : DbContext
    {
        public DayCareRepository(DbContextOptions<DayCareRepository> options) : base(options)
        {
        }

        public DbSet<DayCareEntity> DayCareEntities { get; set; }
    }
}
