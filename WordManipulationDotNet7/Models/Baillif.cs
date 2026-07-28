using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class Baillif
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [StringLength(50)]
        public string? AFM { get; set; }
    }
}
