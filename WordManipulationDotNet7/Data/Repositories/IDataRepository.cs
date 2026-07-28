using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data.Repositories
{
    public interface IDataRepository
    {
        // Baillifs
        Task<List<Baillif>> GetBaillifsAsync();
        Task<Baillif?> GetBaillifByIdAsync(int id);
        Task AddBaillifAsync(Baillif baillif);
        Task UpdateBaillifAsync(Baillif baillif);
        Task DeleteBaillifAsync(int id);

        // Attorneys
        Task<List<Attorney>> GetAttorneysAsync();
        Task<List<Attorney>> GetNotariesAsync();
        Task<List<Attorney>> GetNotariesNewAsync();
        Task<List<Attorney>> GetAttorneysListAsync();
        Task<Attorney?> GetAttorneyByIdAsync(int id);
        Task AddAttorneyAsync(Attorney attorney);
        Task UpdateAttorneyAsync(Attorney attorney);
        Task DeleteAttorneyAsync(int id);

        // Funds
        Task<List<Fund>> GetFundsAsync();
        Task<Fund?> GetFundByIdAsync(int id);
        Task AddFundAsync(Fund fund);
        Task UpdateFundAsync(Fund fund);
        Task DeleteFundAsync(int id);

        // Zones
        Task<List<Zone>> GetZonesAsync();
        Task<Zone?> GetZoneByIdAsync(int id);
        Task AddZoneAsync(Zone zone);
        Task UpdateZoneAsync(Zone zone);
        Task DeleteZoneAsync(int id);

        // EkthesiEpidoshsModels
        Task<List<EkthesiEpidoshsModel>> GetEkthesiEpidoshsModelsAsync();
        Task<EkthesiEpidoshsModel?> GetEkthesiEpidoshsModelByIdAsync(int id);
        Task AddEkthesiEpidoshsModelAsync(EkthesiEpidoshsModel model);
        Task UpdateEkthesiEpidoshsModelAsync(EkthesiEpidoshsModel model);
        Task DeleteEkthesiEpidoshsModelAsync(int id);

        // DebtorsForSunexisi
        Task<List<DebtorForSunexisi>> GetDebtorsForSunexisiAsync();
        Task<DebtorForSunexisi?> GetDebtorForSunexisiByIdAsync(int id);
        Task AddDebtorForSunexisiAsync(DebtorForSunexisi debtor);
        Task UpdateDebtorForSunexisiAsync(DebtorForSunexisi debtor);
        Task DeleteDebtorForSunexisiAsync(int id);

        // Banks
        Task<List<PistotikaIdrymataUpoEkkatharisi>> GetBanksAsync();
        Task<PistotikaIdrymataUpoEkkatharisi?> GetBankByIdAsync(int id);
        Task AddBankAsync(PistotikaIdrymataUpoEkkatharisi bank);
        Task UpdateBankAsync(PistotikaIdrymataUpoEkkatharisi bank);
        Task DeleteBankAsync(int id);
    }
}
