using System.ComponentModel.DataAnnotations;

namespace COMP003B.SP25.Assignment3.Models
{
    public class JobApplication
    {
        [Required]
        [MinLength(5)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [Range(0, 40)]
        public int ExperienceYears { get; set; }

        [Required]
        public string Position { get; set; }

        [Url]
        public string? PortfolioURL { get; set; }

        [Required]
        [MaxLength(1000)]
        public string CoverLetter { get; set; }
    }
}
