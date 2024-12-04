using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using expotec_ef.Modules.BusinessExecutives.Models;

namespace expotec_ef.Models
{
    public class Confirmation
    {
        [Key]
        [Column(TypeName = "CHAR(36)")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column("confirmation_date")]
        public DateTime? ConfirmationDate { get; set; }

        [Required]
        [StringLength(30)]
        [Column("confirmation_response")]
        public required string ConfirmationResponse { get; set; }
        
        [Required]
        [Column(TypeName = "CHAR(36)")]
        [ForeignKey("Participant")]
        public required string ParticipantId { get; set; }
        public Participant? Participant { get; set; }

        [Column(TypeName = "CHAR(36)")]
        [ForeignKey("BusinessExecutive")]
        public string? BusinessExecutiveId { get; set; }
        public BusinessExecutive? BusinessExecutive { get; set; }
    }

}
