using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ASM2_1670.Models
{
    [Table("Listing")]
    public class Listing
    {
        [Key]
        public int JobId { get; set; } // Primary key
        [Required]
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public string OtherDetails { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]

        public Category Category { get; set; }
    }
}
