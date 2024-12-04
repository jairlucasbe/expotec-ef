using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace expotec_ef.Modules.BusinessExecutives.Models.Dtos
{
    public class UpdateBusinessExecutiveDto
    {
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(8)]
        public string? Dni { get; set; }

        [StringLength(50)]
        public string? Type { get; set; }

        [Column(TypeName = "CHAR(36)")]
        public string? PartnerId { get; set; }
    }
}
