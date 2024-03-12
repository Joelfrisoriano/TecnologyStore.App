using Microsoft.EntityFrameworkCore;

namespace TecnologyStoreApp.Data
{
    public class Context : DbContext
    {
        public DbSet<DetallesFactura> DetallesFacturas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=DetallesFactura.db");
    }
}
