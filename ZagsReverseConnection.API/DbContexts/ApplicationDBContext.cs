using Microsoft.EntityFrameworkCore;
using ZagsReverseConnection.API.Models;

namespace ZagsReverseConnection.API.DbContexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<GetFamilyModel> familyModels { get; set; }
    }
}
