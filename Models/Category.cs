using System.ComponentModel.DataAnnotations;

namespace maku_eticaret.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu Alan Boş Bırakılmaz")]
        public string? CategoryName { get; set; }
        virtual public List<Products>? Products { get; set; }
    }
}
