using System.ComponentModel.DataAnnotations;

namespace StormShop.API.Models
{
    public class Base
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
