using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expotec_ef.Models
{
    public class Participant
    {
        [Key]
        [Column(TypeName = "CHAR(36)")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(100)]
        [Column("name")]
        public required string Name { get; set; }

        [StringLength(100)]
        [Column("position")]
        public string? Position { get; set; }

        [StringLength(100)]
        [Column("area")]
        public string? Area { get; set; }

        [StringLength(20)]
        [Column("phone")]
        public string? Phone { get; set; }

        [StringLength(100)]
        [Column("email")]
        public string? Email { get; set; }

        [Column(TypeName = "CHAR(36)")]
        [ForeignKey("Company")]
        public required string CompanyId { get; set; }
        public Company? Company { get; set; }

        [StringLength(20)]
        [Column("type")]
        public string? Type { get; set; }

        [StringLength(255)]
        [Column("comments")]
        public string? Comments { get; set; }

        [Column("attended")]
        public bool Attended { get; set; } = false;

        [Column("is_candidate_for_coktail")]
        public bool IsCandidateForCoktail { get; set; } = false;

        [Column("number_confirmations")]
        public int NumberConfirmations { get; set; } = 0;

        [Column("is_active_confirmation")]
        public bool IsActiveConfirmation { get; set; } = true;
    }

}
