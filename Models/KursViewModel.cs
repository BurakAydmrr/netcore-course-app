using System.ComponentModel.DataAnnotations;
using efcoreApp.Data;

namespace efcoreApp.Models
{
    public class KursViewModel
    {
        public int KursId { get; set; }
        [Required(ErrorMessage = "Başlık alanı boş geçilemez.")]
        public string? Baslik { get; set; }

        [Required(ErrorMessage = "Öğretmen alanı boş geçilemez.")]
        public int? OgretmenId { get; set; }
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();

    }
}