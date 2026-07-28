using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class EkthesiEpidoshsModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Perigrafh { get; set; }

        public bool? Praxh { get; set; }

        public bool FusikoProswpo { get; set; }

        [StringLength(200)]
        public string? Kleisimo { get; set; }

        public Kleisimo HasKleisimo { get; set; }

        public Signature Signature { get; set; }

        public bool? ZoneB { get; set; }

        public int PriorityNumber { get; set; }
    }

    public enum Signature
    {
        paredros,
        ypallilos,
        paralavon,
        genericMartyras
    }
}
