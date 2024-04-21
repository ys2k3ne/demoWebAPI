using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
