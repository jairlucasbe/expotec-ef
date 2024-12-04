using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expotec_ef.Modules.BusinessExecutives.Models
{
    public class BusinessExecutive
    {
        [Key]
        [Column(TypeName = "CHAR(36)")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(50)]
        [Column("name")]
        public required string Name { get; set; }

        [Required]
        [StringLength(8)]
        [Column("dni")]
        public required string Dni { get; set; }

        [StringLength(50)]
        [Column("type")]
        public string? Type { get; set; }

        [Column(TypeName = "CHAR(36)")]
        [ForeignKey("Partner")]
        public string? PartnerId { get; set; }
        public BusinessExecutive? Partner { get; set; }
    }
}
