using System.ComponentModel.DataAnnotations;
using WordManipulationDotNet7.Services;

namespace WordManipulationDotNet7.ViewModels
{
    public class DilosiSunexisisVm
    {
        [Display(Name = "Τοποθεσία")]
        [Required(ErrorMessage = "Η τοποθεσία είναι υποχρεωτική")]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;

        [Display(Name = "Συμβολαιογράφος")]
        [Required(ErrorMessage = "Ο συμβολαιογράφος είναι υποχρεωτικός")]
        public int Notary { get; set; }

        [Display(Name = "Ζώνη")]
        [Required(ErrorMessage = "Η ζώνη είναι υποχρεωτική")]
        public int Zone { get; set; }

        [Display(Name = "Αριθμός")]
        [Required(ErrorMessage = "Ο αριθμός είναι υποχρεωτικός")]
        [StringLength(50)]
        public string CaseNumber { get; set; } = string.Empty;

        [Display(Name = "Οφειλέτης")]
        [Required(ErrorMessage = "Ο οφειλέτης είναι υποχρεωτικός")]
        [StringLength(200)]
        public string Debtor { get; set; } = string.Empty;

        [Display(Name = "Γένος")]
        [Required(ErrorMessage = "Το γένος είναι υποχρεωτικό")]
        public Gender Gender { get; set; }

        [Display(Name = "Άρθρο 966")]
        public bool Ar8ro966 { get; set; }

        [Display(Name = "Ημερομηνία Παραγγελίας")]
        [Required(ErrorMessage = "Η ημερομηνία παραγγελίας είναι υποχρεωτική")]
        [StringLength(50)]
        public string DateOfOrder { get; set; } = string.Empty;

        [Display(Name = "Ημερομηνία Κατάσχεσης")]
        [Required(ErrorMessage = "Η ημερομηνία κατάσχεσης είναι υποχρεωτική")]
        [StringLength(50)]
        public string DateOfConfiscation { get; set; } = string.Empty;

        [Display(Name = "Fund")]
        [Required(ErrorMessage = "Το fund είναι υποχρεωτικό")]
        public int Fund { get; set; }
    }
}
