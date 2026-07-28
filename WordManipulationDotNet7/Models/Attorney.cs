using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class Attorney
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Pronoun { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(1000)]
        public string? GiaSunexisi { get; set; }
    }
}
