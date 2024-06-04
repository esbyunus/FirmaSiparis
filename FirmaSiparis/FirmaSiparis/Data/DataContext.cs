using FirmaSiparis.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace FirmaSiparis.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Siparis>Sipariss { get; set; }
        public DbSet<Urun>Uruns { get; set; }

    }
}
