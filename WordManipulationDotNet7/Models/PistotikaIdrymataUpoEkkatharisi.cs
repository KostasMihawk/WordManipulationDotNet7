using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class PistotikaIdrymataUpoEkkatharisi
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(200)]
        public string? DiakritikosTitlos { get; set; }

        [StringLength(300)]
        public string? Edra { get; set; }

        [StringLength(50)]
        public string? AFM { get; set; }
    }
}
