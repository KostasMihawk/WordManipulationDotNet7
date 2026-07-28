using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Microsoft.Extensions.Options;
using WordManipulationDotNet7.Configuration;
using WordManipulationDotNet7.Models;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace WordManipulationDotNet7.Services
{
    public class DocXService
    {
        private readonly CompanySettings _companySettings;
        private readonly DocumentSettings _documentSettings;
        private readonly PricingSettings _pricingSettings;
        private readonly ILocalizationService _localizationService;
        private readonly ILogger<DocXService> _logger;

        private readonly double _fontSize;
        private readonly string _fontFamily;
        private readonly Formatting _formatting;

        public DocXService(
            IOptions<CompanySettings> companySettings,
            IOptions<DocumentSettings> documentSettings,
            IOptions<PricingSettings> pricingSettings,
            ILocalizationService localizationService,
            ILogger<DocXService> logger)
        {
            _companySettings = companySettings?.Value ?? throw new ArgumentNullException(nameof(companySettings));
            _documentSettings = documentSettings?.Value ?? throw new ArgumentNullException(nameof(documentSettings));
            _pricingSettings = pricingSettings?.Value ?? throw new ArgumentNullException(nameof(pricingSettings));
            _localizationService = localizationService ?? throw new ArgumentNullException(nameof(localizationService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _fontSize = _documentSettings.DefaultFontSize;
            _fontFamily = _documentSettings.DefaultFontFamily;
            _formatting = new Formatting
            {
                Spacing = _documentSettings.LineSpacing,
                Size = _documentSettings.DefaultFontSize
            };
        }

        public Paragraph AddToParagraph(Paragraph paragraph, string text)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            paragraph.Append(text).FontSize(_fontSize).Font(_fontFamily);
            return paragraph;
        }

        public Paragraph AddToParagraph(Paragraph paragraph, string text, double fontSize, string fontFamily)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            paragraph.Append(text).FontSize(fontSize).Font(fontFamily);
            return paragraph;
        }

        public Paragraph AddNewLine(Paragraph paragraph)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            return paragraph.AppendLine();
        }

        public Paragraph AddToParagraphBoldText(Paragraph paragraph, string text)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            paragraph.Append(text).Bold().FontSize(_fontSize).Font(_fontFamily);
            return paragraph;
        }

        public Paragraph AddToParagraphBoldAndUnderlinedText(Paragraph paragraph, string text)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            paragraph.Append(text).Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(_fontSize).Font(_fontFamily);
            return paragraph;
        }

        public Paragraph AddtoParagraphWithUnderlineText(Paragraph paragraph, string text)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            paragraph.Append(text).UnderlineStyle(UnderlineStyle.singleLine).FontSize(_fontSize).Font(_fontFamily);
            return paragraph;
        }

        public Paragraph AddtoParagraphWithItalic(Paragraph paragraph, string text)
        {
            ArgumentNullException.ThrowIfNull(paragraph);
            paragraph.Append(text).Italic().FontSize(_fontSize).Font(_fontFamily);
            return paragraph;
        }

        public string EpiloghArthrouBasiGenous(Gender gender)
        {
            return _localizationService.GetGenderArticle(gender);
        }

        public string EpilogiArthrouBasiGenousGenikiPtwsh(Gender gender)
        {
            return _localizationService.GetGenderArticleGenitive(gender);
        }

        public string EpilogiArthouOfileti(Gender gender)
        {
            return _localizationService.GetDebtorByGender(gender);
        }

        public string PraxiHPinakas(bool isPinakas)
        {
            return isPinakas ? "(ΠΙΝΑΚΑΣ ΚΑΤΑΤΑΞΗΣ - ΠΡΟΣΚΛΗΣΗ ΔΑΝΕΙΣΤΩΝ)" : "(ΠΡΟΣΚΛΗΣΗΣ ΔΑΝΕΙΣΤΩΝ)";
        }

        public string ArthroSunexisisPlistiriasmou(bool Article)
        {
            return Article ? "966" : "973";
        }

        public DocX CreatePricingAndNameTable(DocX doc, Zone zone, bool isFusikoProswpo, bool? ZoneB)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Table t = doc.AddTable(7, 2);
            doc.MarginBottom = 0;
            doc.MarginTop = 20;

            t.SetColumnWidth(0, 350d);
            t.SetColumnWidth(1, 110d);
            t.SetBorder(TableBorderType.InsideH, new Border(BorderStyle.Tcbs_none, BorderSize.one, 0, Color.AntiqueWhite));
            t.Alignment = Alignment.center;

            var companyInfo = $" {_companySettings.Name}";
            var addressInfo = $"Έδρα: {_companySettings.Address} - {_companySettings.City} {_companySettings.PostalCode}";
            var taxInfo = $"Α.Φ.Μ.: {_companySettings.TaxId} - Δ.Ο.Υ. {_companySettings.TaxOffice}";
            var phoneInfo = $"ΤΗΛ: {_companySettings.Phone}";
            var phone1Info = $"Π.Μιχοπούλου: {_companySettings.Phone1}";
            var phone2Info = $"Μ.Ζούζουλα: {_companySettings.Phone2}";
            var emailInfo = $"email: {_companySettings.Email}";

            if (isFusikoProswpo)
            {
                PopulateTableRows(t, "Ζώνη: " + zone.Name, (decimal)zone.Value, (decimal)zone.Tax, (decimal)zone.TaxedValue,
                    companyInfo, addressInfo, taxInfo, phoneInfo, phone1Info, phone2Info, emailInfo);
            }
            else if (ZoneB == true)
            {
                var zoneBPrice = _pricingSettings.ZoneBPrice;
                var zoneBTax = zoneBPrice * _pricingSettings.TaxRate;
                var zoneBTotal = zoneBPrice + zoneBTax;
                PopulateTableRows(t, "Ζώνη: Β", zoneBPrice, zoneBTax, zoneBTotal,
                    companyInfo, addressInfo, taxInfo, phoneInfo, phone1Info, phone2Info, emailInfo);
            }
            else if (ZoneB == false)
            {
                var zoneCPrice = _pricingSettings.ZoneCPrice;
                var zoneCTax = zoneCPrice * _pricingSettings.TaxRate;
                var zoneCTotal = zoneCPrice + zoneCTax;
                PopulateTableRows(t, "Ζώνη: Γ", zoneCPrice, zoneCTax, zoneCTotal,
                    companyInfo, addressInfo, taxInfo, phoneInfo, phone1Info, phone2Info, emailInfo);
            }
            else
            {
                var zoneAPrice = _pricingSettings.ZoneAPrice;
                var zoneATax = zoneAPrice * _pricingSettings.TaxRate;
                var zoneATotal = zoneAPrice + zoneATax;
                PopulateTableRows(t, "Ζώνη: A", zoneAPrice, zoneATax, zoneATotal,
                    companyInfo, addressInfo, taxInfo, phoneInfo, phone1Info, phone2Info, emailInfo);
            }

            var color = Color.AntiqueWhite;
            for (int i = 0; i < 7; i++)
            {
                t.Rows[i].Cells[0].FillColor = color;
                t.Rows[i].Cells[1].FillColor = color;
            }

            doc.InsertTable(t);
            return doc;
        }

        private void PopulateTableRows(Table t, string zoneText, decimal price, decimal tax, decimal total,
            string companyInfo, string addressInfo, string taxInfo, string phoneInfo,
            string phone1Info, string phone2Info, string emailInfo)
        {
            t.Rows[0].Cells[0].Paragraphs.First().Append(companyInfo).Font(_fontFamily).Bold().Alignment = Alignment.center;
            t.Rows[0].Cells[1].Paragraphs.First().Append(zoneText).Font(_fontFamily);
            t.Rows[1].Cells[0].Paragraphs.First().Append(addressInfo).Font(_fontFamily).Alignment = Alignment.center;
            t.Rows[1].Cells[1].Paragraphs.First().Append("").Font(_fontFamily);
            t.Rows[2].Cells[0].Paragraphs.First().Append(taxInfo).Font(_fontFamily).Alignment = Alignment.center;
            t.Rows[2].Cells[1].Paragraphs.First().Append($"ΑΜΟΙΒΗ: {price:F}").Font(_fontFamily);
            t.Rows[3].Cells[0].Paragraphs.First().Append(phoneInfo).Font(_fontFamily).Alignment = Alignment.center;
            t.Rows[3].Cells[1].Paragraphs.First().Append("").Font(_fontFamily);
            t.Rows[4].Cells[0].Paragraphs.First().Append(phone1Info).Font(_fontFamily).Alignment = Alignment.center;
            t.Rows[4].Cells[1].Paragraphs.First().Append($"ΦΠΑ {_pricingSettings.TaxRate * 100:F0}%: {tax:F}").Font(_fontFamily);
            t.Rows[5].Cells[0].Paragraphs.First().Append(phone2Info).Font(_fontFamily).Alignment = Alignment.center;
            t.Rows[5].Cells[1].Paragraphs.First().Append("").Font(_fontFamily);
            t.Rows[6].Cells[0].Paragraphs.First().Append(emailInfo).Font(_fontFamily).Alignment = Alignment.center;
            t.Rows[6].Cells[1].Paragraphs.First().Append($"ΣΥΝΟΛΟ: {total:F}").Font(_fontFamily);
        }

        public DocX AddHeaderToDocument(DocX doc, string? fontFamilyCustom)
        {
            ArgumentNullException.ThrowIfNull(doc);

            string header = "ΕΚΘΕΣΗ ΕΠΙΔΟΣΗΣ";

            var headerFormat = new Formatting();
            headerFormat.FontFamily = new Xceed.Document.NET.Font(fontFamilyCustom ?? _fontFamily);
            headerFormat.Size = 13D;
            headerFormat.Bold = true;
            headerFormat.UnderlineStyle = UnderlineStyle.singleLine;
            headerFormat.Spacing = 1.2;

            doc.InsertParagraph("", false, headerFormat);

            Paragraph headerTextParagraph = doc.InsertParagraph(header, false, headerFormat);
            headerTextParagraph.Alignment = Alignment.both;
            headerTextParagraph.Append("                                                                            ");
            headerTextParagraph.Append("Αριθμός.............").Bold().UnderlineStyle(UnderlineStyle.singleLine).FontSize(12D).Spacing(1.2).Font(_fontFamily).Alignment = Alignment.right;
            headerTextParagraph.AppendLine();

            return doc;
        }

        public DocX CreateIntroParagraph(DocX doc, string location, string locationUpiresias, bool isFusikoProsopo, string epispeudon, string DebtorDesc)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph introParagraph = doc.InsertParagraph("", false, _formatting);
            introParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            introParagraph.Alignment = Alignment.both;
            AddNewLine(introParagraph);

            if (isFusikoProsopo)
            {
                AddToParagraph(introParagraph, $"{location}, σήμερα στις ...................................... ");
            }
            else
            {
                AddToParagraph(introParagraph, $"{locationUpiresias}, σήμερα στις ...................................... ");
            }

            var monthName = _localizationService.GetGreekMonthName(DateTime.Now);
            AddToParagraph(introParagraph, $"(     ) του μηνός {monthName} του έτους δύο χιλιάδες είκοσι πέντε (2025), ημέρα .......................................... και ώρα ........");
            AddToParagraph(introParagraph, $", εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, .........................................................................., μέλος της εταιρείας «{_companySettings.Name}», που εδρεύει στην Αθήνα, οδός {_companySettings.Address}, με Α.Φ.Μ. {_companySettings.TaxId}, νομίμως εκπροσωπούμενης, κατόπιν της έγγραφης παραγγελίας");

            if (string.IsNullOrEmpty(epispeudon))
            {
                AddToParagraph(introParagraph, $" {DebtorDesc},");
            }
            else
            {
                AddToParagraph(introParagraph, $" {epispeudon},");
            }

            return doc;
        }

        public DocX EpispeudonParagraph(DocX doc, bool isFusikoProsopo, Gender gender, string ofeileths, string upiresia)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;

            if (isFusikoProsopo)
            {
                AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldAndUnderlinedText(paragraph, $"προς {EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeileths},");
            }
            else
            {
                AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldAndUnderlinedText(paragraph, $"{upiresia}");
            }
            return doc;
        }

        public DocX EpispeudonKatasxetiriaParagraph(DocX doc, string perigrafh, string ofeiletis, bool Eurobank, bool AlphaBank, bool Ethniki, bool Peiraios, bool Attica, bool HSBC, bool Chanion, bool Viva, bool Unicredit, bool Procredit, bool KentrikisMakedonias, bool AnaferomenaEggrafa, bool isAnagastikiEktelesi, string date)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
            AddToParagraphBoldAndUnderlinedText(paragraph, perigrafh);
            AddToParagraph(paragraph, $" την από {date} ");
            if (!isAnagastikiEktelesi)
            {
                int counter = 1;
                AddToParagraphBoldText(paragraph, $"ΕΠΙΒΟΛΗ ΣΥΝΤΗΡΗΤΙΚΗΣ ΚΑΤΑΣΧΕΣΗΣ-ΔΥΝΑΜΕΙ ΔΙΑΤΑΓΗΣ ΠΛΗΡΩΜΗΣ ");//TODO TO MALAKISMENO 8ELEI KENO GIA NA GRAFEI KA8E FORA
                AddToParagraph(paragraph, $"της πρώτης κατά των: ");//TODO EDW NA BEI SAN PARAMETER O OFEILETIS
                AddtoParagraphWithItalic(paragraph, ofeiletis + " ");
                AddToParagraph(paragraph, $"ΕΙΣ ΧΕΙΡΑΣ των: ");
                if (Eurobank) AddToParagraphBoldText(paragraph, counter++ + ") Eurobank ");
                if (AlphaBank) AddToParagraphBoldText(paragraph, counter++ + ") AlphaBank ");
                if (Ethniki) AddToParagraphBoldText(paragraph, counter++ + ") Εθνική Τράπεζα ");
                if (Peiraios) AddToParagraphBoldText(paragraph, counter++ + ") Τράπεζα Πειραιώς ");
                if (Attica) AddToParagraphBoldText(paragraph, counter++ + ") Attica Bank ");
                if (HSBC) AddToParagraphBoldText(paragraph, counter++ + ") HSBC ");
                if (Chanion) AddToParagraphBoldText(paragraph, counter++ + ") Χανίων ");
                if (Viva) AddToParagraphBoldText(paragraph, counter++ + ") Viva ");
                if (Unicredit) AddToParagraphBoldText(paragraph, counter++ + ") Unicredit ");
                if (Procredit) AddToParagraphBoldText(paragraph, counter++ + ") Procredit ");
                if (KentrikisMakedonias) AddToParagraphBoldText(paragraph, counter++ + ") Τράπεζα Κεντρικής Μακεδονίας ");

                AddToParagraph(paragraph, ",το περιεχόμενο της οποίας έχει όπως ακριβώς στην παρούσα αντιγράφεται, για να λάβει γνώση και για τις νόμιμες συνέπειες, ");

                if (AnaferomenaEggrafa)
                {
                    AddToParagraph(paragraph, $"συγκοινοποιώντας τα σε αυτή αναφερόμενα έγγραφα,");
                }

                //);//TODO EDO NA KOLLISW TA CHECKBOXES GIA NA KOLLISUN NA BEI H VIVA/OPTIMA/UNICREDIT/PROCREDIT/KENTRIKIS MAKEDONIAS/ KAI ENA CHECKBOX NA LEEI ΣΥΓΚΟΙΝΟΠΟΙΏΝΤΑΣ ΤΑ ΣΕ ΑΥΤΗ ΑΝΑΦΕΡΟΜΕΝΑ ΕΓΓΡΑΦΑ
            }
            else
            {
                AddToParagraphBoldText(paragraph, $"");
            }
            return doc;
        }

        public DocX ParagraphAkrivesAdigrafo(DocX doc, Gender gender, string documentNumber, string sumbolaiografos, string ofeileths, bool Article)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddToParagraph(paragraph, $"ακριβές αντίγραφο της υπ΄ αριθμόν");
            AddToParagraphBoldText(paragraph, $" {documentNumber} ΠΡΑΞΗΣ ΔΗΛΩΣΗΣ-ΕΝΤΟΛΗΣ ΣΥΝΕΧΙΣΗΣ ΠΛΕΙΣΤΗΡΙΑΣΜΟΥ ΑΚΙΝΗΤΟΥ ΚΑΤΑ ΤΟ ΑΡΘΡΟ " + ArthroSunexisisPlistiriasmou(Article) + " ΤΟΥ Κ.ΠΟΛ.Δ.,");
            AddToParagraph(paragraph, $" {sumbolaiografos} κατά {EpiloghArthrouBasiGenous(gender)} {ofeileths}, για να λάβει γνώση και για τις νόμιμες συνέπειες.");
            return doc;
        }

        public DocX CreateIntroParagraphGiaPraxiDaneistwn(DocX doc, string location, string locationUpiresias, bool isFusikoProsopo, string bailif, string notary)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;

            if (isFusikoProsopo)
            {
                AddToParagraph(paragraph, $"{location}, ");
            }
            else
            {
                AddToParagraph(paragraph, $"{locationUpiresias}, ");
            }

            var monthName = _localizationService.GetGreekMonthName(DateTime.Now);
            AddToParagraph(paragraph, $"σήμερα στις .................................... (      ) του μηνός {monthName} του έτους δύο χιλιάδες είκοσι πέντε (2025), ημέρα ................................ και ώρα ........," +
                $" εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, {bailif}, μέλος της εταιρείας «{_companySettings.Name}», που εδρεύει στην Αθήνα, οδός {_companySettings.Address}, με Α.Φ.Μ. {_companySettings.TaxId}, νομίμως εκπροσωπούμενης, κατόπιν της έγγραφης παραγγελίας {notary}" +
                $", ως επί του πλειστηριασμού υπαλλήλου,");
            return doc;
        }

        public DocX CreateIntroParagraphKatasxetiria(DocX doc, string Location, PistotikaIdrymataUpoEkkatharisi pistotikaIdrymata)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;

            var monthName = _localizationService.GetGreekMonthName(DateTime.Now);
            AddToParagraph(paragraph, $"{Location}, σήμερα στις .................................... (      ) του μηνός {monthName} του έτους δύο χιλιάδες είκοσι πέντε (2025), ημέρα ................................ και ώρα ........," +
                    $" εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, ......................................................., μέλος της εταιρείας «{_companySettings.Name}», που εδρεύει στην Αθήνα, οδός {_companySettings.Address}, με Α.Φ.Μ. {_companySettings.TaxId}, νομίμως εκπροσωπούμενης," +
                    $" κατόπιν της έγγραφης παραγγελίας της δικηγόρου Ναυπλίου ");
            AddtoParagraphWithUnderlineText(paragraph, $"Ευαγγελίας Ξυπνητού,");
            AddToParagraph(paragraph, $" πληρεξουσίου του υπό ειδική εκκαθάριση πιστωτικού ιδρύματος με την επωνυμία    ");
            AddToParagraphBoldText(paragraph, $"«" + pistotikaIdrymata.Name + "»");
            AddToParagraph(paragraph, $" με το διακριτικό τίτλο ");
            AddToParagraphBoldText(paragraph, $"«" + pistotikaIdrymata.DiakritikosTitlos + $"» ");
            AddToParagraph(paragraph, pistotikaIdrymata.Edra);
            AddToParagraph(paragraph, $" και εκπροσωπείται νόμιμα από τον Ειδικό Εκκαθαριστή αυτής ανώνυμη εταιρεία με την επωνυμία");
            AddToParagraphBoldText(paragraph, $" «PQH ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ, ΕΙΔΙΚΟΣ ΕΚΚΑΘΑΡΙΣΤΗΣ ΠΙΣΤΩΤΙΚΩΝ ΙΔΡΥΜΑΤΩΝ»");
            AddToParagraph(paragraph, $", με τον διακριτικό τίτλο ");
            AddToParagraphBoldText(paragraph, $"«PQH ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ Α.Ε.»");
            AddToParagraph(paragraph, $", με έδρα στο Δήμο Αμαρουσίου Αττικής, οδός Γραβιάς 3 και Γρανικού, με Α.Φ.Μ. 800721689, δυνάμει της υπ' αριθ. 182/1/4.4.2016 Απόφασης της Επιτροπής" +
                $" Πιστωτικών και Ασφαλιστικών Θεμάτων της Τράπεζας της Ελλάδος (ΦΕΚ β' 925/5.4.2016), όπως νομίμως εκπροσωπείται,");
            return doc;
        }

        public DocX ParagrafosPraxis(DocX doc, bool? isPraxi, string keimenoPraxis)
        {
            ArgumentNullException.ThrowIfNull(doc);

            if (isPraxi == true)
            {
                Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
                paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                paragraph.Alignment = Alignment.both;
                AddToParagraph(paragraph, keimenoPraxis);
                if (string.IsNullOrEmpty(keimenoPraxis))
                {
                    AddNewLine(paragraph);
                    AddNewLine(paragraph);
                    AddNewLine(paragraph);
                }
                return doc;
            }
            else if (isPraxi == false)
            {
                Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
                paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                paragraph.Alignment = Alignment.both;
                AddNewLine(paragraph);
                AddNewLine(paragraph);
                AddNewLine(paragraph);
                AddNewLine(paragraph);
                return doc;
            }
            else if (isPraxi == null && !string.IsNullOrEmpty(keimenoPraxis))
            {
                Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
                paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
                paragraph.Alignment = Alignment.both;
                AddToParagraph(paragraph, keimenoPraxis);
                return doc;
            }
            else
            {
                return doc;
            }

        }

        public DocX ParagrafosSuntaxisEkthesis(DocX doc)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddToParagraph(paragraph, $"Σε πίστωση των παραπάνω συνέταξα την παρούσα έκθεση επιδόσεως σε δύο όμοια πρωτότυπα η οποία αφού διαβάστηκε και βεβαιώθηκε υπογράφεται όπως ακολουθεί.");
            return doc;
        }

        public DocX ParagrafosUpografis(DocX doc, bool? isPraxi, bool isFusikoProsopo, Signature signature)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddNewLine(paragraph);
            switch (signature)
            {
                case Signature.paralavon:
                    AddToParagraph(paragraph, $".. παραλαβ.....                                             η Δικαστική Επιμελήτρια ");
                    break;
                case Signature.paredros:
                    AddToParagraph(paragraph, $".. παραλαβ..... Πάρεδρος                                            η Δικαστική Επιμελήτρια ");
                    break;
                case Signature.ypallilos:
                    AddToParagraph(paragraph, $".. παραλαβ..... εξουσιοδοτημεν.... Υπάλληλος                       η Δικαστική Επιμελήτρια ");
                    break;
                case Signature.genericMartyras:
                    AddToParagraph(paragraph, $".. .....αρ...........                                                                     η Δικαστική Επιμελήτρια ");
                    break;                
                default:
                    break;
            }
            return doc;
        }

        public DocX ParagrapfosProsOfeilethPraxisDaneistwn(DocX doc, Gender gender, bool isFusikoProsopo, string ofeiletis, string upiresia)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;            
            if (isFusikoProsopo)
            {
                AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldAndUnderlinedText(paragraph, $"προς {EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeiletis}, ");
            }
            else
            {
                AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldAndUnderlinedText(paragraph, upiresia);
            }
            return doc;
        }

        public DocX ParagrafosAkrivesAdigrafouPraxisDaneistwn(DocX doc, Gender gender, string defender, string documentNumber, string ofeiletis, bool isPinakas, bool IsAnaplistiriasmos, bool IsEikozomenon, string AttorneyNoun)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;           
            AddToParagraph(paragraph, $"ακριβές αντίγραφο της υπ΄ αριθμόν ");
            if (IsAnaplistiriasmos)
            {
                AddToParagraphBoldText(paragraph, $"{documentNumber} ΠΡΑΞΗΣ ΕΠΙΣΠΕΥΣΗΣ ΑΝΑΠΛΕΙΣΤΗΡΙΑΣΜΟΥ ΚΑΤ' ΑΡΘΡΟ 965 Κ.ΠΟΛ.Δ. ");

            }
            else if (IsEikozomenon)
            {
                AddToParagraphBoldText(paragraph,
                    $"{documentNumber} ΓΕΝΙΚΗ ΠΡΟΣΚΛΗΣΗ ΤΩΝ ΚΑΘΕ ΦΥΣΕΩΣ ΕΙΚΑΖΟΜΕΝΩΝ ΔΑΝΕΙΣΤΩΝ ");
            }
            else
            {
                AddToParagraphBoldText(paragraph, $"{documentNumber} ΠΡΑΞΗΣ {PraxiHPinakas(isPinakas)} ");
            }
            AddToParagraph(paragraph, $"{AttorneyNoun} ως άνω συμβολαιογράφου κατά {EpiloghArthrouBasiGenous(gender)}{ofeiletis}, για να λάβει γνώση και για τις νόμιμες συνέπειες.");
            return doc;
        }
        private string ProNounChange(string pronoun)
        {
            if (pronoun == "της") return "την";
            else if (pronoun == "του") return "τον";
            else return pronoun;

        }

        public DocX CreateIntroParagraphDilosiSunexisis(DocX doc, string location, string locationUpiresias, bool isFusikoProsopo, string DateOfConfiscation, string NotaryDescription, string DateOfOrder, string NotaryName, string NotaryCity, string NotaryPronoun)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph introParagraph = doc.InsertParagraph("", false, _formatting);
            introParagraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            introParagraph.Alignment = Alignment.both;
            AddNewLine(introParagraph);

            if (isFusikoProsopo)
            {
                AddToParagraph(introParagraph, $"{location}, σήμερα στις ...................................... ");
            }
            else
            {
                AddToParagraph(introParagraph, $"{locationUpiresias}, σήμερα στις ...................................... ");
            }

            var monthName = _localizationService.GetGreekMonthName(DateTime.Now);
            AddToParagraph(introParagraph, $"(     ) του μηνός {monthName} του έτους δύο χιλιάδες είκοσι πέντε (2025), ημέρα .......................................... και ώρα ........");
            AddToParagraph(introParagraph, $", εγώ η δικαστική επιμελήτρια του Εφετείου Αθηνών, .........................................................................., μέλος της εταιρείας «{_companySettings.Name}», που εδρεύει στην Αθήνα, οδός {_companySettings.Address}, με Α.Φ.Μ. {_companySettings.TaxId}, νομίμως εκπροσωπούμενης, μετά την έγγραφη παραγγελία ");
            AddToParagraph(introParagraph, "που μου δόθηκε στις ");
            AddToParagraphBoldText(introParagraph, DateOfOrder);
            AddToParagraph(introParagraph, " από "+ ProNounChange(NotaryPronoun) + " Συμβολαιογράφο " + NotaryCity + " ");
            AddToParagraphBoldText(introParagraph, NotaryName + " ");
            AddToParagraph(introParagraph, NotaryDescription + " ως υπάλληλο του πλειστηριασμού,");
            return doc;
        }

        public DocX EpispeudonParagraphDilosi(DocX doc, bool isFusikoProsopo, Gender gender, string ofeileths, string upiresia)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            
            if (isFusikoProsopo)
            {
                AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldAndUnderlinedText(paragraph, $"προς {EpilogiArthrouBasiGenousGenikiPtwsh(gender)} {ofeileths},");
            }
            else
            {
                AddToParagraph(paragraph, $"ήλθα για να επιδώσω ");
                AddToParagraphBoldAndUnderlinedText(paragraph, $"{upiresia}");
            }
            AddToParagraph(paragraph, " προς γνώση και για τις νόμιμες συνέπειες,");
            return doc;
        }

        public DocX ParagraphAkrivesAdigrafoDilosi(DocX doc, Gender gender, string documentNumber, string sumbolaiografos, string ofeileths, bool Article, string DateOfConfiscation, string FundName, string FundDesc, string MaedapName, string MaedapAdress, string NotaryPronoun)
        {
            ArgumentNullException.ThrowIfNull(doc);

            Paragraph paragraph = doc.InsertParagraph("", false, _formatting);
            paragraph.SetLineSpacing(LineSpacingType.Line, 16.0f);
            paragraph.Alignment = Alignment.both;
            AddToParagraph(paragraph, $"ακριβές αντίγραφο της υπ΄ αριθμόν");
            AddToParagraphBoldText(paragraph, $" {documentNumber} ΠΡΑΞΗΣ ΔΗΛΩΣΗΣ-ΕΝΤΟΛΗΣ ΣΥΝΕΧΙΣΗΣ ΠΛΕΙΣΤΗΡΙΑΣΜΟΥ ΑΚΙΝΗΤΟΥ ΚΑΤΑ ΤΟ ΑΡΘΡΟ " + ArthroSunexisisPlistiriasmou(Article) + " ΤΟΥ Κ.ΠΟΛ.Δ.,");
            AddToParagraph(paragraph, $" των πράξεων {NotaryPronoun} ως άνω Συμβολαιογράφου, για πλειστηριασμό που θα διενεργηθεί στις ");
            AddToParagraphBoldAndUnderlinedText(paragraph, DateOfConfiscation);
            AddToParagraph(paragraph, " επισπευδόμενης από την εταιρεία ειδικού σκοπού τιτλοποίησης με την επωνυμία ");
            AddToParagraphBoldText(paragraph, "«" + FundName + "»");
            AddToParagraph(paragraph, " , " + FundDesc + ", επ' ονόματι και για λογαριασμό της οποίας ενεργεί η εταιρεία με την επωνυμία ");
            AddToParagraphBoldText(paragraph, "«" + MaedapName + "»");
            AddToParagraph(paragraph, " η οποία εδρεύει " + MaedapAdress + " όπως εκπροσωπείται νόμιμα,");
            AddToParagraph(paragraph, " κατά " + EpilogiArthouOfileti(gender) + " ");
            AddToParagraphBoldText(paragraph, ofeileths);
            AddToParagraph(paragraph, ".");
            return doc;
        }

        public MemoryStream EntoliSunexisisPlistiriasmou(SunexisiPlistiriasmouModel model)
        {
            ArgumentNullException.ThrowIfNull(model);

            using (DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {
                CreatePricingAndNameTable(doc, model.Zone, model.IsFusikoProsopo, model.ZoneB);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraph(doc, model.Location, model.Address, model.IsFusikoProsopo, model.Epispeudon, model.DebtorDefaultList.Description);
                EpispeudonParagraph(doc, model.IsFusikoProsopo, model.Gender, model.Debtor, model.Upiresia);
                ParagraphAkrivesAdigrafo(doc, model.Gender, model.CaseNumber, model.Notary.GiaSunexisi, model.Debtor, model.Ar8ro966);
                ParagrafosPraxis(doc, model.PraxiUpiresias, model.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, model.PraxiUpiresias, model.IsFusikoProsopo, model.Signature);
                return CreateAndReturnDocAsMemoryStream(doc);
            }
        }

        public MemoryStream CreateAndReturnDocAsMemoryStream(DocX doc)
        {
            ArgumentNullException.ThrowIfNull(doc);

            var ms = new MemoryStream();
            doc.SaveAs(ms);
            ms.Position = 0;
            return ms;
        }
        public MemoryStream DilosiSunexisis(DilosiSunexisisModel model)
        {
            ArgumentNullException.ThrowIfNull(model);

            using (DocX doc = DocX.Create(String.Format(model.Debtor + ".docx", DateTime.Now)))
            {
                CreatePricingAndNameTable(doc, model.Zone, model.IsFusikoProsopo, model.ZoneB);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraphDilosiSunexisis(doc, model.Location, model.Address, model.IsFusikoProsopo, model.DateOfConfiscation, model.Notary.Description, model.DateOfOrder, model.Notary.Name, model.Notary.City, model.Notary.Pronoun);
                EpispeudonParagraphDilosi(doc, model.IsFusikoProsopo, model.Gender, model.Debtor, model.Upiresia);
                ParagraphAkrivesAdigrafoDilosi(doc, model.Gender, model.CaseNumber, model.Notary.Name, model.Debtor, model.Ar8ro966, model.DateOfConfiscation, model.Fund.Name, model.Fund.Description, model.Fund.MAEDAP, model.Fund.MAEDAPAdress, model.Notary.Pronoun);
                ParagrafosPraxis(doc, model.PraxiUpiresias, model.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, model.PraxiUpiresias, model.IsFusikoProsopo, model.Signature);
                return CreateAndReturnDocAsMemoryStream(doc);
            }
        }
        public MemoryStream PraxiPlistiriasmou(LoanerInvitationModel model)
        {
            ArgumentNullException.ThrowIfNull(model);

            using (DocX doc = DocX.Create(String.Format("Zip_{0}.docx", DateTime.Now.ToString("yyyy-MMM-dd-HHmmss"))))
            {
                CreatePricingAndNameTable(doc, model.Zone, model.IsFusikoProsopo, model.ZoneB);
                AddHeaderToDocument(doc, null);
                CreateIntroParagraphGiaPraxiDaneistwn(doc, model.Location, model.Address, model.IsFusikoProsopo, model.Baillif.Name, model.Notary.Description);
                ParagrapfosProsOfeilethPraxisDaneistwn(doc, model.Gender, model.IsFusikoProsopo, model.Debtor, model.Upiresia);
                ParagrafosAkrivesAdigrafouPraxisDaneistwn(doc, model.Gender, model.Upiresia, model.CaseNumber, model.Debtor, model.IsTable, model.IsAnaplistiriasmos, model.IsEikazomenon, model.Notary.Pronoun);
                ParagrafosPraxis(doc, model.PraxiUpiresias, model.KeimenoPraxis);
                ParagrafosSuntaxisEkthesis(doc);
                ParagrafosUpografis(doc, model.PraxiUpiresias, model.IsFusikoProsopo, model.Signature);
                return CreateAndReturnDocAsMemoryStream(doc);
            }
        }
    }
    public enum Gender
    {
        [Display(Name = "Ανδρας")]
        Man,
        [Display(Name = "Γυναίκα")]
        Woman,
        [Display(Name = "Τράπεζα/Εταιρεία")]
        Etaireia
    }

    
}

