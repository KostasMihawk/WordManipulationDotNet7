using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WordManipulationDotNet7.Data;
using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AdminController> _logger;

        public AdminController(ApplicationDbContext context, ILogger<AdminController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // Dashboard
        public IActionResult Index()
        {
            try
            {
                _logger.LogInformation("Admin Index accessed");

                var model = new AdminDashboardViewModel
                {
                    BaillifCount = _context.Baillifs.Count(),
                    AttorneyCount = _context.Attorneys.Count(),
                    FundCount = _context.Funds.Count(),
                    ZoneCount = _context.Zones.Count(),
                    BankCount = _context.Banks.Count(),
                    DebtorCount = _context.DebtorsForSunexisi.Count(),
                    DocumentCount = _context.EkthesiEpidoshsModels.Count()
                };

                _logger.LogInformation("Admin dashboard model created successfully");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading admin dashboard");
                return Content($"Error loading admin: {ex.Message}");
            }
        }

        // Simple test endpoint
        public IActionResult Test()
        {
            return Content("Admin controller is working!");
        }

        // ==================== BAILLIFS ====================

        public IActionResult Baillifs()
        {
            var baillifs = _context.Baillifs.OrderBy(b => b.Id).ToList();
            return View(baillifs);
        }

        [HttpPost]
        public IActionResult AddBaillif(Baillif model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = _context.Baillifs.Any()
                        ? _context.Baillifs.Max(b => b.Id) + 1
                        : 1;

                    _context.Baillifs.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Ο επιμελητής προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding bailiff");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη επιμελητή.";
            }

            return RedirectToAction(nameof(Baillifs));
        }

        [HttpPost]
        public IActionResult DeleteBaillif(int id)
        {
            try
            {
                var baillif = _context.Baillifs.Find(id);
                if (baillif != null)
                {
                    _context.Baillifs.Remove(baillif);
                    _context.SaveChanges();
                    TempData["Success"] = "Ο επιμελητής διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting bailiff {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή επιμελητή.";
            }

            return RedirectToAction(nameof(Baillifs));
        }

        [HttpGet]
        public IActionResult EditBaillif(int id)
        {
            var baillif = _context.Baillifs.Find(id);
            if (baillif == null)
            {
                TempData["Error"] = "Ο επιμελητής δεν βρέθηκε.";
                return RedirectToAction(nameof(Baillifs));
            }
            return View(baillif);
        }

        [HttpPost]
        public IActionResult EditBaillif(Baillif model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.Baillifs.Find(model.Id);
                    if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.City = model.City;
                        existing.AFM = model.AFM;

                        _context.SaveChanges();
                        TempData["Success"] = "Ο επιμελητής ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Baillifs));
                    }
                    else
                    {
                        TempData["Error"] = "Ο επιμελητής δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing bailiff {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση επιμελητή.";
            }

            return View(model);
        }

        // ==================== ATTORNEYS ====================

        public IActionResult Attorneys()
        {
            var attorneys = _context.Attorneys.OrderBy(a => a.Id).ToList();
            ViewBag.AttorneyTypes = new List<SelectListItem>
            {
                new SelectListItem { Value = "Notary", Text = "Συμβολαιογράφος (GetNotaries)" },
                new SelectListItem { Value = "NotaryNew", Text = "Νέος Συμβολαιογράφος (GetNotariesNew)" },
                new SelectListItem { Value = "Attorney", Text = "Δικηγόρος (GetAttorneysList)" }
            };
            return View(attorneys);
        }

        [HttpPost]
        public IActionResult AddAttorney(Attorney model, string AttorneyType)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = AttorneyType switch
                    {
                        "Notary" => _context.Attorneys.Where(a => a.Id < 100).Any()
                            ? _context.Attorneys.Where(a => a.Id < 100).Max(a => a.Id) + 1
                            : 1,
                        "NotaryNew" => _context.Attorneys.Where(a => a.Id >= 100 && a.Id < 200).Any()
                            ? _context.Attorneys.Where(a => a.Id >= 100 && a.Id < 200).Max(a => a.Id) + 1
                            : 100,
                        "Attorney" => _context.Attorneys.Where(a => a.Id >= 200).Any()
                            ? _context.Attorneys.Where(a => a.Id >= 200).Max(a => a.Id) + 1
                            : 200,
                        _ => 200
                    };

                    _context.Attorneys.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Ο δικηγόρος/συμβολαιογράφος προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding attorney");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη δικηγόρου/συμβολαιογράφου.";
            }

            return RedirectToAction(nameof(Attorneys));
        }

        [HttpPost]
        public IActionResult DeleteAttorney(int id)
        {
            try
            {
                var attorney = _context.Attorneys.Find(id);
                if (attorney != null)
                {
                    _context.Attorneys.Remove(attorney);
                    _context.SaveChanges();
                    TempData["Success"] = "Ο δικηγόρος/συμβολαιογράφος διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting attorney {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή δικηγόρου/συμβολαιογράφου.";
            }

            return RedirectToAction(nameof(Attorneys));
        }

        [HttpGet]
        public IActionResult EditAttorney(int id)
        {
            var attorney = _context.Attorneys.Find(id);
            if (attorney == null)
            {
                TempData["Error"] = "Ο δικηγόρος/συμβολαιογράφος δεν βρέθηκε.";
                return RedirectToAction(nameof(Attorneys));
            }

            // Determine attorney type based on ID range
            ViewBag.AttorneyType = id switch
            {
                < 100 => "Notary",
                >= 100 and < 200 => "NotaryNew",
                _ => "Attorney"
            };

            ViewBag.AttorneyTypes = new List<SelectListItem>
            {
                new SelectListItem { Value = "Notary", Text = "Συμβολαιογράφος (GetNotaries)" },
                new SelectListItem { Value = "NotaryNew", Text = "Νέος Συμβολαιογράφος (GetNotariesNew)" },
                new SelectListItem { Value = "Attorney", Text = "Δικηγόρος (GetAttorneysList)" }
            };

            return View(attorney);
        }

        [HttpPost]
        public IActionResult EditAttorney(Attorney model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.Attorneys.Find(model.Id);
                    if (existing != null)
                    {
                        // Update properties but preserve ID (cannot change attorney type)
                        existing.Name = model.Name;
                        existing.City = model.City;
                        existing.Pronoun = model.Pronoun;
                        existing.Description = model.Description;
                        existing.GiaSunexisi = model.GiaSunexisi;

                        _context.SaveChanges();
                        TempData["Success"] = "Ο δικηγόρος/συμβολαιογράφος ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Attorneys));
                    }
                    else
                    {
                        TempData["Error"] = "Ο δικηγόρος/συμβολαιογράφος δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing attorney {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση δικηγόρου/συμβολαιογράφου.";
            }

            // Re-populate ViewBag for error case
            ViewBag.AttorneyType = model.Id switch
            {
                < 100 => "Notary",
                >= 100 and < 200 => "NotaryNew",
                _ => "Attorney"
            };

            ViewBag.AttorneyTypes = new List<SelectListItem>
            {
                new SelectListItem { Value = "Notary", Text = "Συμβολαιογράφος (GetNotaries)" },
                new SelectListItem { Value = "NotaryNew", Text = "Νέος Συμβολαιογράφος (GetNotariesNew)" },
                new SelectListItem { Value = "Attorney", Text = "Δικηγόρος (GetAttorneysList)" }
            };

            return View(model);
        }

        // ==================== FUNDS ====================

        public IActionResult Funds()
        {
            var funds = _context.Funds.OrderBy(f => f.Id).ToList();
            return View(funds);
        }

        [HttpPost]
        public IActionResult AddFund(Fund model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = _context.Funds.Any()
                        ? _context.Funds.Max(f => f.Id) + 1
                        : 1;

                    _context.Funds.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Το ταμείο προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding fund");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη ταμείου.";
            }

            return RedirectToAction(nameof(Funds));
        }

        [HttpPost]
        public IActionResult DeleteFund(int id)
        {
            try
            {
                var fund = _context.Funds.Find(id);
                if (fund != null)
                {
                    _context.Funds.Remove(fund);
                    _context.SaveChanges();
                    TempData["Success"] = "Το ταμείο διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting fund {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή ταμείου.";
            }

            return RedirectToAction(nameof(Funds));
        }

        [HttpGet]
        public IActionResult EditFund(int id)
        {
            var fund = _context.Funds.Find(id);
            if (fund == null)
            {
                TempData["Error"] = "Το ταμείο δεν βρέθηκε.";
                return RedirectToAction(nameof(Funds));
            }
            return View(fund);
        }

        [HttpPost]
        public IActionResult EditFund(Fund model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.Funds.Find(model.Id);
                    if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Description = model.Description;
                        existing.MAEDAP = model.MAEDAP;
                        existing.MAEDAPAdress = model.MAEDAPAdress;

                        _context.SaveChanges();
                        TempData["Success"] = "Το ταμείο ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Funds));
                    }
                    else
                    {
                        TempData["Error"] = "Το ταμείο δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing fund {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση ταμείου.";
            }

            return View(model);
        }

        // ==================== ZONES ====================

        public IActionResult Zones()
        {
            var zones = _context.Zones.OrderBy(z => z.Id).ToList();
            return View(zones);
        }

        [HttpPost]
        public IActionResult AddZone(Zone model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = _context.Zones.Any()
                        ? _context.Zones.Max(z => z.Id) + 1
                        : 1;

                    _context.Zones.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Η ζώνη προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding zone");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη ζώνης.";
            }

            return RedirectToAction(nameof(Zones));
        }

        [HttpGet]
        public IActionResult EditZone(int id)
        {
            var zone = _context.Zones.Find(id);
            if (zone == null)
            {
                TempData["Error"] = "Η ζώνη δεν βρέθηκε.";
                return RedirectToAction(nameof(Zones));
            }
            return View(zone);
        }

        [HttpPost]
        public IActionResult EditZone(Zone model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.Zones.Find(model.Id);
                    if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Value = model.Value;
                        existing.Tax = model.Tax;
                        existing.TaxedValue = model.TaxedValue;

                        _context.SaveChanges();
                        TempData["Success"] = "Η ζώνη ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Zones));
                    }
                    else
                    {
                        TempData["Error"] = "Η ζώνη δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing zone {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση ζώνης.";
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteZone(int id)
        {
            try
            {
                var zone = _context.Zones.Find(id);
                if (zone != null)
                {
                    _context.Zones.Remove(zone);
                    _context.SaveChanges();
                    TempData["Success"] = "Η ζώνη διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting zone {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή ζώνης.";
            }

            return RedirectToAction(nameof(Zones));
        }

        // ==================== BANKS ====================

        public IActionResult Banks()
        {
            var banks = _context.Banks.OrderBy(b => b.Id).ToList();
            return View(banks);
        }

        [HttpPost]
        public IActionResult AddBank(PistotikaIdrymataUpoEkkatharisi model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = _context.Banks.Any()
                        ? _context.Banks.Max(b => b.Id) + 1
                        : 1;

                    _context.Banks.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Το πιστωτικό ίδρυμα προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding bank");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη πιστωτικού ιδρύματος.";
            }

            return RedirectToAction(nameof(Banks));
        }

        [HttpGet]
        public IActionResult EditBank(int id)
        {
            var bank = _context.Banks.Find(id);
            if (bank == null)
            {
                TempData["Error"] = "Το πιστωτικό ίδρυμα δεν βρέθηκε.";
                return RedirectToAction(nameof(Banks));
            }
            return View(bank);
        }

        [HttpPost]
        public IActionResult EditBank(PistotikaIdrymataUpoEkkatharisi model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.Banks.Find(model.Id);
                    if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.DiakritikosTitlos = model.DiakritikosTitlos;
                        existing.Edra = model.Edra;
                        existing.AFM = model.AFM;

                        _context.SaveChanges();
                        TempData["Success"] = "Το πιστωτικό ίδρυμα ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Banks));
                    }
                    else
                    {
                        TempData["Error"] = "Το πιστωτικό ίδρυμα δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing bank {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση πιστωτικού ιδρύματος.";
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteBank(int id)
        {
            try
            {
                var bank = _context.Banks.Find(id);
                if (bank != null)
                {
                    _context.Banks.Remove(bank);
                    _context.SaveChanges();
                    TempData["Success"] = "Το πιστωτικό ίδρυμα διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting bank {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή πιστωτικού ιδρύματος.";
            }

            return RedirectToAction(nameof(Banks));
        }

        // ==================== DEBTORS ====================

        public IActionResult Debtors()
        {
            var debtors = _context.DebtorsForSunexisi.OrderBy(d => d.Id).ToList();
            return View(debtors);
        }

        [HttpPost]
        public IActionResult AddDebtor(DebtorForSunexisi model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = _context.DebtorsForSunexisi.Any()
                        ? _context.DebtorsForSunexisi.Max(d => d.Id) + 1
                        : 1;

                    _context.DebtorsForSunexisi.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Ο οφειλέτης προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding debtor");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη οφειλέτη.";
            }

            return RedirectToAction(nameof(Debtors));
        }

        [HttpGet]
        public IActionResult EditDebtor(int id)
        {
            var debtor = _context.DebtorsForSunexisi.Find(id);
            if (debtor == null)
            {
                TempData["Error"] = "Ο οφειλέτης δεν βρέθηκε.";
                return RedirectToAction(nameof(Debtors));
            }
            return View(debtor);
        }

        [HttpPost]
        public IActionResult EditDebtor(DebtorForSunexisi model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.DebtorsForSunexisi.Find(model.Id);
                    if (existing != null)
                    {
                        existing.Name = model.Name;
                        existing.Description = model.Description;

                        _context.SaveChanges();
                        TempData["Success"] = "Ο οφειλέτης ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Debtors));
                    }
                    else
                    {
                        TempData["Error"] = "Ο οφειλέτης δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing debtor {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση οφειλέτη.";
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteDebtor(int id)
        {
            try
            {
                var debtor = _context.DebtorsForSunexisi.Find(id);
                if (debtor != null)
                {
                    _context.DebtorsForSunexisi.Remove(debtor);
                    _context.SaveChanges();
                    TempData["Success"] = "Ο οφειλέτης διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting debtor {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή οφειλέτη.";
            }

            return RedirectToAction(nameof(Debtors));
        }

        // ==================== DOCUMENTS (Templates) ====================

        public IActionResult Documents()
        {
            var documents = _context.EkthesiEpidoshsModels.OrderBy(d => d.PriorityNumber).ThenBy(d => d.Name).ToList();
            return View(documents);
        }

        [HttpPost]
        public IActionResult AddDocument(EkthesiEpidoshsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = _context.EkthesiEpidoshsModels.Any()
                        ? _context.EkthesiEpidoshsModels.Max(d => d.Id) + 1
                        : 1;

                    _context.EkthesiEpidoshsModels.Add(model);
                    _context.SaveChanges();

                    TempData["Success"] = "Το πρότυπο εγγράφου προστέθηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding document template");
                TempData["Error"] = "Σφάλμα κατά την προσθήκη προτύπου εγγράφου.";
            }

            return RedirectToAction(nameof(Documents));
        }

        [HttpGet]
        public IActionResult EditDocument(int id)
        {
            var document = _context.EkthesiEpidoshsModels.Find(id);
            if (document == null)
            {
                TempData["Error"] = "Το πρότυπο εγγράφου δεν βρέθηκε.";
                return RedirectToAction(nameof(Documents));
            }
            return View(document);
        }

        [HttpPost]
        public IActionResult EditDocument(EkthesiEpidoshsModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = _context.EkthesiEpidoshsModels.Find(model.Id);
                    if (existing != null)
                    {
                        existing.Location = model.Location;
                        existing.Name = model.Name;
                        existing.Perigrafh = model.Perigrafh;
                        existing.Praxh = model.Praxh;
                        existing.FusikoProswpo = model.FusikoProswpo;
                        existing.Kleisimo = model.Kleisimo;
                        existing.HasKleisimo = model.HasKleisimo;
                        existing.Signature = model.Signature;
                        existing.ZoneB = model.ZoneB;
                        existing.PriorityNumber = model.PriorityNumber;

                        _context.SaveChanges();
                        TempData["Success"] = "Το πρότυπο εγγράφου ενημερώθηκε επιτυχώς!";
                        return RedirectToAction(nameof(Documents));
                    }
                    else
                    {
                        TempData["Error"] = "Το πρότυπο εγγράφου δεν βρέθηκε.";
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error editing document template {Id}", model.Id);
                TempData["Error"] = "Σφάλμα κατά την ενημέρωση προτύπου εγγράφου.";
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteDocument(int id)
        {
            try
            {
                var document = _context.EkthesiEpidoshsModels.Find(id);
                if (document != null)
                {
                    _context.EkthesiEpidoshsModels.Remove(document);
                    _context.SaveChanges();
                    TempData["Success"] = "Το πρότυπο εγγράφου διαγράφηκε επιτυχώς!";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting document template {Id}", id);
                TempData["Error"] = "Σφάλμα κατά τη διαγραφή προτύπου εγγράφου.";
            }

            return RedirectToAction(nameof(Documents));
        }
    }

    // ViewModel for Dashboard
    public class AdminDashboardViewModel
    {
        public int BaillifCount { get; set; }
        public int AttorneyCount { get; set; }
        public int FundCount { get; set; }
        public int ZoneCount { get; set; }
        public int BankCount { get; set; }
        public int DebtorCount { get; set; }
        public int DocumentCount { get; set; }
    }
}
