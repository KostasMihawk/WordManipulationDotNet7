using Ionic.Zip;
using Microsoft.AspNetCore.Mvc;
using WordManipulationDotNet7.Models;
using WordManipulationDotNet7.Services;
using WordManipulationDotNet7.ViewModels;

namespace WordManipulationDotNet7.Controllers
{
    public class SunexisiPlistriasmouController : Controller
    {
        private readonly DocXService _docXService;
        public SunexisiPlistriasmouController(DocXService docXService)
        {
            _docXService = docXService;
        }
        public IActionResult CreateSunexisiPlistiriasmou()
        {
            return View();
        }
        [HttpPost()]
        public ActionResult CreateSunexisiPlistiriasmou(SunexisiPlistirasmouViewmodel vm)
        {
            DropDownGenerator generator = new DropDownGenerator();
            Summary s = new Summary(_docXService);

            SunexisiPlistiriasmouModel model = new SunexisiPlistiriasmouModel(vm);



            var ZipFiles = new List<EkthesiEpidoshsModel>();
            ZipFiles = generator.GetZipFiles();
            using (MemoryStream stream = new MemoryStream())
            {
                using (ZipFile zip = new ZipFile(System.Text.Encoding.UTF8))
                {
                    zip.AlternateEncodingUsage = ZipOption.AsNecessary;
                    foreach (var doc in ZipFiles)
                    {

                        model.fillZipEntries(doc);
                        if (doc.Name.Contains("Εφοριες"))
                        {
                            zip.AddEntry("Εφορίες/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else if (doc.Name.Contains("Cepal"))
                        {
                            zip.AddEntry("Cepal/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else if (doc.Name.Contains("doValue"))
                        {
                            zip.AddEntry("doValue/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else if (doc.Name.Contains("Intrum"))
                        {
                            zip.AddEntry("Intrum/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else if (doc.Name.Contains("QQuant"))
                        {
                            zip.AddEntry("QQuant/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else if (doc.Name.Contains("ALfa"))
                        {
                            zip.AddEntry("Αλφα/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else if (doc.Name.Contains("pqh"))
                        {
                            zip.AddEntry("pqh/" + doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                        else
                        {
                            zip.AddEntry(doc.Name + ".docx", s.CreateEntoliSunexisisPlistiriasmou(model));
                        }
                    }
                    zip.Save(stream);
                }
                return File(stream.ToArray(), "application/zip", vm.Debtor + ".zip");
            }
        }
    }
}
