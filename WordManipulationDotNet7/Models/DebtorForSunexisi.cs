using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class DebtorForSunexisi
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Description { get; set; }
    }
}
