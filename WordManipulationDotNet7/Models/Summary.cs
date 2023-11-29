using WordManipulationDotNet7.Interfaces;
using WordManipulationDotNet7.Services;

namespace WordManipulationDotNet7.Models
{
    public class Summary
    {
        //private readonly IDocXManager docXManager;
        private readonly DocXService docXManager;
        public Summary(DocXService docXService)
        {
            docXManager = docXService;
        }



        public MemoryStream CreateSunexisiPlistiriasmou(LoanerInvitationModel model)
        {
            return docXManager.PraxiPlistiriasmou(model);
        }

        public MemoryStream CreateEntoliSunexisisPlistiriasmou(SunexisiPlistiriasmouModel model)
        {
            return docXManager.EntoliSunexisisPlistiriasmou(model);
        }

        public MemoryStream CreateDilosiSunexisis(DilosiSunexisisModel model)
        {
            return docXManager.DilosiSunexisis(model);
        }


        //public MemoryStream CreateKatasxetiria(KatasxetirioModel model)
        //{
        //    return docXManager.Katasxetiria(model);
        //}

        public string EpiloghGenousKatw(Gender gender)
        {
            if (gender == Gender.Man)
                return "του ";
            else
                return "της ";
        }

        public string EpiloghGenousPanw(Gender gender)
        {
            if (gender == Gender.Man)
                return "τον ";
            else if (gender == Gender.Woman)
                return "την ";
            else
                return "την ";
        }

        public string EpiloghGenousOfeileti(Gender gender)
        {
            if (gender == Gender.Man)
                return " οφειλέτη ";
            else if (gender == Gender.Woman)
                return " οφειλέτιδος ";
            else
                return "οφειλέτριας ";
        }

        public string DisplayEpwnumiaEtaireias(Gender gender)
        {
            if (gender == Gender.Etaireia)
                return "εταιρείας με την επωνυμία ";
            else
                return "";
        }

        public string IsBankEmpty(bool isBankEmpty)
        {
            if (isBankEmpty)
            {
                return "";
            }
            else
            {
                return " μετά από επίσπευση της Εθνικής Τράπεζας της Ελλάδος Α.Ε.";
            }
        }

        public string isPinakas(bool isPinakas)
        {
            if (isPinakas)
            {
                return "(ΠΙΝΑΚΑ ΚΑΤΑΤΑΞΗΣ ΔΑΝΕΙΣΤΩΝ - ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
            }
            else
            {
                return "(ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
            }
        }



    }
}

