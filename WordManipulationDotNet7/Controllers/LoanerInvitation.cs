using Ionic.Zip;
using Microsoft.AspNetCore.Mvc;
using WordManipulationDotNet7.Models;
using WordManipulationDotNet7.Services;
using WordManipulationDotNet7.ViewModels;

namespace WordManipulationDotNet7.Controllers
{
    public class LoanerInvitation : Controller
    {
        private readonly DocXService _docXService;

        public LoanerInvitation(DocXService docXService)
        {
            _docXService = docXService;
        }

        public IActionResult CreateLoanerInvitation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateLoanerInvitation(LoanerInvitationViewmodel vm)
        {
            var generator = new DropDownGenerator();
            var summary = new Summary(_docXService);
            var loanerInvitationModel = new LoanerInvitationModel(vm);
            var zipFiles = generator.GetZipFiles();

            using (var stream = new MemoryStream())
            {
                using (var zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in zipFiles)
                    {
                        loanerInvitationModel.fillZipEntries(doc);
                        var entryName = GetEntryName(doc);
                        zip.AddEntry(entryName, summary.CreateSunexisiPlistiriasmou(loanerInvitationModel));
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
                var name when name.Contains("pqh") => $"Pqh/{name}.docx",
                var name when name.Contains("_") => $"ΒΑΣΙΚΑ/{name}.docx",
                _ => $"{doc.Name}.docx",
            };
        }
    }
}
