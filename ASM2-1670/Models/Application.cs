using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM2_1670.Models
{
    [Table("Application")]
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; } // Primary key
        [Required]
        public string CoverLetter { get; set; }
        public string? CV { get; set; }
        public string? ApplicationStatus { get; set; }
        public int JobId { get; set; } // Foreign key
        [ForeignKey(nameof(JobId))]
        [ValidateNever]
        public Listing Listing { get; set; }
    }
}
