using System.ComponentModel.DataAnnotations;

namespace WordManipulationDotNet7.Models
{
    public class Zone
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(0, double.MaxValue)]
        public double Value { get; set; }

        [Range(0, double.MaxValue)]
        public double Tax { get; set; }

        [Range(0, double.MaxValue)]
        public double TaxedValue { get; set; }
    }
}
