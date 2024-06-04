namespace FirmaSiparis.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        public string SiparisVeren { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public ICollection<Firma> Firmas { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}
