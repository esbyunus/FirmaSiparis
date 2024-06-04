using FirmaSiparis.Models;

namespace FirmaSiparis.Interfaces
{
    public interface FirmaRepo
    {
        ICollection<Firma> GetFirmas();
    }
}
