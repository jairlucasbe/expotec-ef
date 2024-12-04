using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace expotec_ef.Modules.BusinessExecutives.Models.Dtos
{
    public class CreateBusinessExecutiveDto
    {
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required]
        [StringLength(8)]
        public required string Dni { get; set; }

        [StringLength(50)]
        public string? Type { get; set; }

        [Column(TypeName = "CHAR(36)")]
        public string? PartnerId { get; set; }
    }
}
