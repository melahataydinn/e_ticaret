﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace maku_eticaret.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Ürün Rengi")]
        public int Renk { get; set; }
        [Display(Name = "Ürün Bedeni")]
        public int Beden { get; set; }
        [Display(Name = "Ürün Cinsiyeti")]
        public int Cinsiyet { get; set; }
        [Display(Name = "Ürün Adı")]
        public string? ProductName { get; set; } = string.Empty;
        [Display(Name = "Ürün Kodu")]
        public int? ProductCode { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string? ProductDescription { get; set; } = string.Empty;
        [Display(Name = "Ürün Resmi")]
        public string? ProductPicture { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public int? ProductPrice { get; set; }
        [Display(Name = "Ürün Kategorisi")]
        public int? CategoryId { get; set; }
        virtual public Category? Category { get; set; }
        [NotMapped]
        public IFormFile? ImageUpload { get; set; }


    }
}
