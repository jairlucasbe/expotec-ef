using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using expotec_ef.Modules.BusinessExecutives.Models;

namespace expotec_ef.Models
{
    public class Company
    {
        [Key]
        [Column(TypeName = "CHAR(36)")]
        public string Id { get; set; } = Guid.NewGuid().ToString(); 

        [Required]
        [StringLength(50)]
        [Column("name")]
        public required string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Column("ruc")]
        public required string Ruc { get; set; }

        [StringLength(100)]
        [Column("address")]
        public string? Address { get; set; }

        [StringLength(50)]
        [Column("district")]
        public string? District { get; set; }

        [StringLength(50)]
        [Column("region")]
        public string? Region { get; set; }

        [Column(TypeName = "CHAR(36)")]
        [ForeignKey("BusinessExecutive")]
        public string? BusinessExecutiveId { get; set; }
        public BusinessExecutive? BusinessExecutive { get; set; }
    }

}