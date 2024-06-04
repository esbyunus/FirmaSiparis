using FirmaSiparis.Data;
using FirmaSiparis.Models;

namespace FirmaSiparis.Repository
{
    public class FirmaRepository
    {
        private readonly DataContext _context;

        public FirmaRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Firma> GetFirmas() 
        {
            return _context.Firma.OrderBy(p => p.Id).ToList();
        }

    }
}
