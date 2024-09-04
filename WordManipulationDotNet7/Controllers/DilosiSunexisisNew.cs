using Microsoft.AspNetCore.Mvc;
using Ionic.Zip;
using System.IO;
using WordManipulationDotNet7.Models;
using WordManipulationDotNet7.Services;
using WordManipulationDotNet7.ViewModels;

namespace WordManipulationDotNet7.Controllers
{
    public class DilosiSunexisisNew : Controller
    {
        private readonly DocXService _docXService;

        public DilosiSunexisisNew(DocXService docXService)
        {
            _docXService = docXService;
        }

        public IActionResult CreateDilosi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDilosi(DilosiSunexisisVm vm)
        {
            var generator = new DropDownGenerator();
            var summary = new Summary(_docXService);
            var model = new DilosiSunexisisModel(vm);
            var zipFiles = generator.GetZipFiles();

            using (var stream = new MemoryStream())
            {
                using (var zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in zipFiles)
                    {
                        model.fillZipEntries(doc);
                        var entryName = GetEntryName(doc);
                        zip.AddEntry(entryName, summary.CreateDilosiSunexisis(model));
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", $"{vm.Debtor}.zip");
            }
        }

        private string GetEntryName(EkthesiEpidoshsModel doc)
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
