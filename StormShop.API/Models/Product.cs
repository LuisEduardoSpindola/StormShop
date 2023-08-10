using StormShop.API.CategoryTypes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StormShop.API.Models
{
    [Table("Products")]
    public class Product : Base
    {
        [MaxLength(255)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Foto")]
        public string Img { get; set; }

        // Enum para CategoryBase

        [Required]
        [Display(Name = "Categoria")]
        public CategoryBaseEnum CategoryBase { get; set; }

        [Display(Name = "Marca")]
        public CategoryTypeOne? CategoryTypeOne { get; set; }

        [Display(Name = "Modelo")]
        public CategoryTypeTwo? CategoryTypeTwo { get; set; }

        [Display(Name = "Cor")]
        public CategoryTypeThree? CategoryTypeThree { get; set; }
    }
}
