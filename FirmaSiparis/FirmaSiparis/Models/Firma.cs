namespace FirmaSiparis.Models
{
    public class Firma
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public bool OnayDurumu { get; set; }
        public TimeSpan SiparisIzinBaslangicSaati { get; set; }
        public TimeSpan SiparisIzinBitisSaati { get; set; }
    }
}
