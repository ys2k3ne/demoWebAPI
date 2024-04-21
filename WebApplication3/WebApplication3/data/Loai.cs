using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int Maloai { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<HangHoa> HangHoas { get; set; }

    }
}
