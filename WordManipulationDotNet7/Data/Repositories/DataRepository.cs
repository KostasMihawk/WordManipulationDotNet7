using Microsoft.EntityFrameworkCore;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly ApplicationDbContext _context;

        public DataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Baillifs
        public async Task<List<Baillif>> GetBaillifsAsync()
        {
            return await _context.Baillifs.OrderBy(b => b.Id).ToListAsync();
        }

        public async Task<Baillif?> GetBaillifByIdAsync(int id)
        {
            return await _context.Baillifs.FindAsync(id);
        }

        public async Task AddBaillifAsync(Baillif baillif)
        {
            _context.Baillifs.Add(baillif);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBaillifAsync(Baillif baillif)
        {
            _context.Baillifs.Update(baillif);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBaillifAsync(int id)
        {
            var baillif = await _context.Baillifs.FindAsync(id);
            if (baillif != null)
            {
                _context.Baillifs.Remove(baillif);
                await _context.SaveChangesAsync();
            }
        }

        // Attorneys
        public async Task<List<Attorney>> GetAttorneysAsync()
        {
            return await _context.Attorneys.OrderBy(a => a.Id).ToListAsync();
        }

        public async Task<List<Attorney>> GetNotariesAsync()
        {
            return await _context.Attorneys
                .Where(a => a.Id >= 1 && a.Id < 100)
                .OrderBy(a => a.Id)
                .ToListAsync();
        }

        public async Task<List<Attorney>> GetNotariesNewAsync()
        {
            return await _context.Attorneys
                .Where(a => a.Id >= 100 && a.Id < 200)
                .OrderBy(a => a.Id)
                .ToListAsync();
        }

        public async Task<List<Attorney>> GetAttorneysListAsync()
        {
            return await _context.Attorneys
                .Where(a => a.Id >= 200)
                .OrderBy(a => a.Id)
                .ToListAsync();
        }

        public async Task<Attorney?> GetAttorneyByIdAsync(int id)
        {
            return await _context.Attorneys.FindAsync(id);
        }

        public async Task AddAttorneyAsync(Attorney attorney)
        {
            _context.Attorneys.Add(attorney);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAttorneyAsync(Attorney attorney)
        {
            _context.Attorneys.Update(attorney);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAttorneyAsync(int id)
        {
            var attorney = await _context.Attorneys.FindAsync(id);
            if (attorney != null)
            {
                _context.Attorneys.Remove(attorney);
                await _context.SaveChangesAsync();
            }
        }

        // Funds
        public async Task<List<Fund>> GetFundsAsync()
        {
            return await _context.Funds.OrderBy(f => f.Id).ToListAsync();
        }

        public async Task<Fund?> GetFundByIdAsync(int id)
        {
            return await _context.Funds.FindAsync(id);
        }

        public async Task AddFundAsync(Fund fund)
        {
            _context.Funds.Add(fund);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFundAsync(Fund fund)
        {
            _context.Funds.Update(fund);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFundAsync(int id)
        {
            var fund = await _context.Funds.FindAsync(id);
            if (fund != null)
            {
                _context.Funds.Remove(fund);
                await _context.SaveChangesAsync();
            }
        }

        // Zones
        public async Task<List<Zone>> GetZonesAsync()
        {
            return await _context.Zones.OrderBy(z => z.Id).ToListAsync();
        }

        public async Task<Zone?> GetZoneByIdAsync(int id)
        {
            return await _context.Zones.FindAsync(id);
        }

        public async Task AddZoneAsync(Zone zone)
        {
            _context.Zones.Add(zone);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateZoneAsync(Zone zone)
        {
            _context.Zones.Update(zone);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteZoneAsync(int id)
        {
            var zone = await _context.Zones.FindAsync(id);
            if (zone != null)
            {
                _context.Zones.Remove(zone);
                await _context.SaveChangesAsync();
            }
        }

        // EkthesiEpidoshsModels
        public async Task<List<EkthesiEpidoshsModel>> GetEkthesiEpidoshsModelsAsync()
        {
            return await _context.EkthesiEpidoshsModels
                .OrderBy(e => e.PriorityNumber)
                .ThenBy(e => e.Id)
                .ToListAsync();
        }

        public async Task<EkthesiEpidoshsModel?> GetEkthesiEpidoshsModelByIdAsync(int id)
        {
            return await _context.EkthesiEpidoshsModels.FindAsync(id);
        }

        public async Task AddEkthesiEpidoshsModelAsync(EkthesiEpidoshsModel model)
        {
            _context.EkthesiEpidoshsModels.Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEkthesiEpidoshsModelAsync(EkthesiEpidoshsModel model)
        {
            _context.EkthesiEpidoshsModels.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEkthesiEpidoshsModelAsync(int id)
        {
            var model = await _context.EkthesiEpidoshsModels.FindAsync(id);
            if (model != null)
            {
                _context.EkthesiEpidoshsModels.Remove(model);
                await _context.SaveChangesAsync();
            }
        }

        // DebtorsForSunexisi
        public async Task<List<DebtorForSunexisi>> GetDebtorsForSunexisiAsync()
        {
            return await _context.DebtorsForSunexisi.OrderBy(d => d.Id).ToListAsync();
        }

        public async Task<DebtorForSunexisi?> GetDebtorForSunexisiByIdAsync(int id)
        {
            return await _context.DebtorsForSunexisi.FindAsync(id);
        }

        public async Task AddDebtorForSunexisiAsync(DebtorForSunexisi debtor)
        {
            _context.DebtorsForSunexisi.Add(debtor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDebtorForSunexisiAsync(DebtorForSunexisi debtor)
        {
            _context.DebtorsForSunexisi.Update(debtor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDebtorForSunexisiAsync(int id)
        {
            var debtor = await _context.DebtorsForSunexisi.FindAsync(id);
            if (debtor != null)
            {
                _context.DebtorsForSunexisi.Remove(debtor);
                await _context.SaveChangesAsync();
            }
        }

        // Banks
        public async Task<List<PistotikaIdrymataUpoEkkatharisi>> GetBanksAsync()
        {
            return await _context.Banks.OrderBy(b => b.Id).ToListAsync();
        }

        public async Task<PistotikaIdrymataUpoEkkatharisi?> GetBankByIdAsync(int id)
        {
            return await _context.Banks.FindAsync(id);
        }

        public async Task AddBankAsync(PistotikaIdrymataUpoEkkatharisi bank)
        {
            _context.Banks.Add(bank);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBankAsync(PistotikaIdrymataUpoEkkatharisi bank)
        {
            _context.Banks.Update(bank);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBankAsync(int id)
        {
            var bank = await _context.Banks.FindAsync(id);
            if (bank != null)
            {
                _context.Banks.Remove(bank);
                await _context.SaveChangesAsync();
            }
        }
    }
}
