using Microsoft.EntityFrameworkCore;
using ProDotNet.API.Models;

namespace ProDotNet.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }
    }
}
