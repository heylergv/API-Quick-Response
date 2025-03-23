using API_Quick_Response.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Quick_Response.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}