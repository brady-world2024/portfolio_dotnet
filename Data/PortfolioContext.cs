using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project>Projects {get;set;}
    }
}