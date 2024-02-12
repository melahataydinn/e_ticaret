using System.ComponentModel.DataAnnotations;

namespace maku_eticaret.Models
{
    public class Kullanici
    {
        [Key]
        public int Kullanici_id { get; set; }
        public string e_posta { get; set; }
        public string ad { get; set; }
        public string sifre { get; set; }
    }
}
