namespace FirmaSiparis.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public ICollection<Firma> Firmas { get; set; }
    }
}
