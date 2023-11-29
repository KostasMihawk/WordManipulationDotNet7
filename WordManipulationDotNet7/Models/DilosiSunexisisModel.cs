using System;
using WordManipulationDotNet7.Services;
using WordManipulationDotNet7.ViewModels;

namespace WordManipulationDotNet7.Models
{
    public class DilosiSunexisisModel
    {
        public Attorney Notary { get; set; }
        public Baillif Baillif { get; set; }
        public Zone Zone { get; set; }
        public Fund Fund { get; set; }
        public string CaseNumber { get; set; }
        public string Debtor { get; set; }
        public Gender Gender { get; set; }
        public string Location { get; set; }
        public string Epispeudon { get; set; }
        public bool Ar8ro966 { get; set; }
        public string DateOfOrder { get; set; }
        public string DateOfConfiscation { get; set; }

        //We need the following attributes to fill up the zip procedure
        public bool IsFusikoProsopo { get; set; }
        public string Address { get; set; }
        public string Upiresia { get; set; }
        public string KeimenoPraxis { get; set; }
        public bool? PraxiUpiresias { get; set; }
        public Kleisimo HasKleisimo { get; set; }
        public Signature Signature { get; set; }
        public bool ZoneB { get; set; }


        public DilosiSunexisisModel()
        {

        }
        public DilosiSunexisisModel(DilosiSunexisisVm vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            this.Notary = generator.GetNotariesNew().SingleOrDefault(n => n.Id == vm.Notary);
            this.Zone = generator.GetZones().SingleOrDefault(a => a.Id == vm.Zone);
            this.Fund = generator.GetFunds().SingleOrDefault(f => f.Id == vm.Fund);
            this.CaseNumber = vm.CaseNumber;
            this.Debtor = vm.Debtor;
            this.Gender = vm.Gender;
            this.Location = vm.Location;
            this.Ar8ro966 = vm.Ar8ro966;
            this.DateOfOrder = vm.DateOfOrder;
            this.DateOfConfiscation = vm.DateOfConfiscation;

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
}

