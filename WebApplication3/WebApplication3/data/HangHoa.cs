using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]

        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public double Dongia { get; set; }

        public byte GiamGia { get; set; }

        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
