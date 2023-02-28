using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        { }

        public DbSet<Hotels> Hotels { get; set; }

        public DbSet<WebApplication1.Models.Booking> Booking { get; set; }
    }
}
