namespace WordManipulationDotNet7.Services
{
    public interface ILocalizationService
    {
        string GetGreekMonthName(DateTime date);
        string GetGenderArticle(Gender gender);
        string GetGenderArticleGenitive(Gender gender);
        string GetDebtorByGender(Gender gender);
    }

    public class LocalizationService : ILocalizationService
    {
        public string GetGreekMonthName(DateTime date)
        {
            if (date.Day > 24)
            {
                return "..............................";
            }

            return date.Month switch
            {
                1 => "Ιανουαρίου",
                2 => "Φεβρουαρίου",
                3 => "Μαρτίου",
                4 => "Απριλίου",
                5 => "Μαϊου",
                6 => "Ιουνίου",
                7 => "Ιουλίου",
                8 => "Αυγούστου",
                9 => "Σεπτεμβρίου",
                10 => "Οκτωβρίου",
                11 => "Νοεμβρίου",
                12 => "Δεκεμβρίου",
                _ => string.Empty
            };
        }

        public string GetGenderArticle(Gender gender)
        {
            return gender switch
            {
                Gender.Man => "του ",
                Gender.Woman => "της ",
                _ => "της"
            };
        }

        public string GetGenderArticleGenitive(Gender gender)
        {
            return gender switch
            {
                Gender.Man => "τον ",
                Gender.Woman => "την ",
                _ => "την"
            };
        }

        public string GetDebtorByGender(Gender gender)
        {
            return gender == Gender.Man ? "του οφειλέτη" : "της οφειλέτιδας";
        }
    }
}
