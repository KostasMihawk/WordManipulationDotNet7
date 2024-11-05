using System.ComponentModel.DataAnnotations;
using WordManipulationDotNet7.Services;
using WordManipulationDotNet7.ViewModels;

namespace WordManipulationDotNet7.Models
{
    public class LoanerInvitationModel
    {
        public Baillif Baillif { get; set; }
        public Attorney Notary { get; set; }
        public Zone Zone { get; set; }
        public string CaseNumber { get; set; }
        public string Debtor { get; set; }
        public Gender Gender { get; set; }
        public string Location { get; set; }
        public bool PraxhPelath { get; set; }
        public KEAO KEAO { get; set; }
        public bool IsTable { get; set; }
        public bool IsBank { get; set; }
        public bool IsAnaplistiriasmos { get; set; }
        public bool IsEikazomenon { get; set; }

        //We need the following attributes to fill up the zip procedure
        public bool IsFusikoProsopo { get; set; }
        public string Address { get; set; }
        public string Upiresia { get; set; }
        public string KeimenoPraxis { get; set; }
        public bool? PraxiUpiresias { get; set; }
        public Kleisimo HasKleisimo { get; set; }
        public Signature Signature { get; set; }
        public bool? ZoneB { get; set; }


        public LoanerInvitationModel()
        {

        }
        public LoanerInvitationModel(LoanerInvitationViewmodel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            this.Baillif = generator.GetBaillifs().SingleOrDefault(b => b.Id == vm.Baillif);
            this.Notary = generator.GetNotaries().SingleOrDefault(n => n.Id == vm.Notary);
            this.Zone = generator.GetZones().SingleOrDefault(a => a.Id == vm.Zone);
            this.CaseNumber = vm.CaseNumber;
            this.Debtor = vm.Debtor;
            this.Gender = vm.Gender;
            this.Location = vm.Location;
            this.KEAO = vm.KEAO;
            this.IsTable = vm.IsTable;
            this.IsBank = vm.IsBank;
            this.PraxhPelath = vm.Praxi;
            this.IsAnaplistiriasmos = vm.IsAnaplistiriasmos;
            this.IsEikazomenon = vm.IsEikazomenon;
        }

        public void fillZipEntries(EkthesiEpidoshsModel zipEntry)
        {
            this.Upiresia = zipEntry.Perigrafh;
            this.IsFusikoProsopo = zipEntry.FusikoProswpo;
            this.PraxiUpiresias = zipEntry.Praxh;
            this.Address = zipEntry.Location;
            this.KeimenoPraxis = zipEntry.Kleisimo;
            this.Signature = zipEntry.Signature;
            this.HasKleisimo = zipEntry.HasKleisimo;
            this.ZoneB = zipEntry.ZoneB;
        }

    }
    public enum KEAO
    {
        [Display(Name = "Α Αθήνας")]
        AAthina,
        [Display(Name = "Β Αθήνας")]
        BAthina,
        [Display(Name = "Πειραιά")]
        Peireas,
        [Display(Name = "Ελευσίνας")]
        Eleusina
    }
}

