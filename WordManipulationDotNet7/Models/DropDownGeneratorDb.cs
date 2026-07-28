using System;
using System.Diagnostics;
using WordManipulationDotNet7.Data;

namespace WordManipulationDotNet7.Models
{
    public class DropDownGeneratorDb
    {
        private readonly ApplicationDbContext _context;

        public DropDownGeneratorDb(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Baillif> GetBaillifs()
        {
            return _context.Baillifs.OrderBy(b => b.Id).ToList();
        }

        public List<Attorney> GetNotaries()
        {
            return _context.Attorneys
                .Where(a => a.Id >= 1 && a.Id < 100)
                .OrderBy(a => a.Id)
                .ToList();
        }

        public List<Attorney> GetNotariesNew()
        {
            return _context.Attorneys
                .Where(a => a.Id >= 100 && a.Id < 200)
                .OrderBy(a => a.Id)
                .ToList();
        }

        public List<Attorney> GetAttorneysList()
        {
            return _context.Attorneys
                .Where(a => a.Id >= 200)
                .OrderBy(a => a.Id)
                .ToList();
        }

        public List<Fund> GetFunds()
        {
            return _context.Funds.OrderBy(f => f.Id).ToList();
        }

        public List<Zone> GetZones()
        {
            return _context.Zones.OrderBy(z => z.Id).ToList();
        }

        public List<EkthesiEpidoshsModel> GetZipFiles()
        {
            return _context.EkthesiEpidoshsModels.OrderBy(e => e.PriorityNumber).ThenBy(e => e.Id).ToList();
        }

        public List<DebtorForSunexisi> GetDebtorsForSunexisi()
        {
            return _context.DebtorsForSunexisi.OrderBy(d => d.Id).ToList();
        }

        public List<PistotikaIdrymataUpoEkkatharisi> GetBanks()
        {
            return _context.Banks.OrderBy(b => b.Id).ToList();
        }
    }
}
