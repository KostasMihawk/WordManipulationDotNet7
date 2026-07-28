using Microsoft.AspNetCore.Mvc;
using System.IO.Compression;
using WordManipulationDotNet7.Models;
using WordManipulationDotNet7.Services;
using WordManipulationDotNet7.ViewModels;

namespace WordManipulationDotNet7.Controllers
{
    public class SunexisiPlistriasmouController : Controller
    {
        private readonly DocXService _docXService;
        private readonly ILogger<SunexisiPlistriasmouController> _logger;
        private readonly DropDownGeneratorDb _dropDownGenerator;

        public SunexisiPlistriasmouController(
            DocXService docXService, 
            ILogger<SunexisiPlistriasmouController> logger,
            DropDownGeneratorDb dropDownGenerator)
        {
            _docXService = docXService ?? throw new ArgumentNullException(nameof(docXService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dropDownGenerator = dropDownGenerator ?? throw new ArgumentNullException(nameof(dropDownGenerator));
        }
        public IActionResult CreateSunexisiPlistiriasmou()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult CreateSunexisiPlistiriasmou(SunexisiPlistirasmouViewmodel vm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(vm);
                }

                var generator = new DropDownGenerator();
                var summary = new Summary(_docXService);
                var model = new SunexisiPlistiriasmouModel(vm);
                var zipFiles = _dropDownGenerator.GetZipFiles();

                using var memoryStream = new MemoryStream();
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var doc in zipFiles)
                    {
                        model.fillZipEntries(doc);
                        var entryName = GetEntryName(doc);
                        var entry = archive.CreateEntry(entryName);

                        using var entryStream = entry.Open();
                        using var documentStream = summary.CreateEntoliSunexisisPlistiriasmou(model);
                        documentStream.CopyTo(entryStream);
                    }
                }

                memoryStream.Position = 0;
                return File(memoryStream.ToArray(), "application/zip", $"{vm.Debtor}.zip");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating Sunexisi Plistiriasmou for debtor: {Debtor}", vm?.Debtor);
                return StatusCode(500, "An error occurred while creating the document.");
            }
        }

        private static string GetEntryName(EkthesiEpidoshsModel doc)
        {
            return doc.Name switch
            {
                var name when name.Contains("Εφοριες") => $"Εφορίες/{name}.docx",
                var name when name.Contains("Cepal") => $"Cepal/{name}.docx",
                var name when name.Contains("doValue") => $"doValue/{name}.docx",
                var name when name.Contains("Intrum") => $"Intrum/{name}.docx",
                var name when name.Contains("QQuant") => $"QQuant/{name}.docx",
                var name when name.Contains("ALfa") => $"Αλφα/{name}.docx",
                var name when name.Contains("pqh") => $"pqh/{name}.docx",
                _ => $"{doc.Name}.docx",
            };
        }
    }
}
