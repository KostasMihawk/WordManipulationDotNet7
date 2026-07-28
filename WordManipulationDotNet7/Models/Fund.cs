using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class Fund
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [StringLength(100)]
        public string? MAEDAP { get; set; }

        [StringLength(300)]
        public string? MAEDAPAdress { get; set; }
    }
}
