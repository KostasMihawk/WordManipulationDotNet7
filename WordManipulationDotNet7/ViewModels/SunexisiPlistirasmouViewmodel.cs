using System.ComponentModel.DataAnnotations;
using WordManipulationDotNet7.Services;

namespace WordManipulationDotNet7.ViewModels
{
    public class SunexisiPlistirasmouViewmodel
    {
        [Display(Name = "Τοποθεσία")]
        public string Location { get; set; }
        [Display(Name = "Συμβολαιογράφος")]
        public int Notary { get; set; }
        [Display(Name = "Ζώνη")]
        public int Zone { get; set; }
        [Display(Name = "Αριθμός")]
        public string CaseNumber { get; set; }
        [Display(Name = "Οφειλέτης")]
        public string Debtor { get; set; }
        [Display(Name = "Γένος")]
        public Gender Gender { get; set; }
        [Display(Name = "Επισπεύδων (Φυσικό Πρόσωπο)")]
        public string Epispeudon { get; set; }
        [Display(Name = "966")]
        public bool Ar8ro966 { get; set; }

        [Display(Name = "Επισπευδον Δικηγορος")]
        public int DebtorForSunexisi { get; set; }
    }
}
