using WordManipulationDotNet7.Models;

namespace WordManipulationDotNet7.Data
{
    public static class DbSeeder
    {
        public static void SeedData(ApplicationDbContext context)
        {
            // Clear existing data
            context.Database.EnsureCreated();

            // Check if data already exists
            if (context.Baillifs.Any())
            {
                return; // Database has been seeded
            }

            // Seed Baillifs
            var baillifs = GetBaillifs();
            context.Baillifs.AddRange(baillifs);

            // Seed Attorneys (Notaries)
            var notaries = GetNotaries();
            context.Attorneys.AddRange(notaries);

            // Seed Attorneys (Notaries New)
            var notariesNew = GetNotariesNew();
            context.Attorneys.AddRange(notariesNew);

            // Seed Attorneys (Attorney List)
            var attorneys = GetAttorneysList();
            context.Attorneys.AddRange(attorneys);

            // Seed Funds
            var funds = GetFunds();
            context.Funds.AddRange(funds);

            // Seed Zones
            var zones = GetZones();
            context.Zones.AddRange(zones);

            // Seed EkthesiEpidoshsModels
            var ekthesiModels = GetZipFiles();
            context.EkthesiEpidoshsModels.AddRange(ekthesiModels);

            // Seed DebtorsForSunexisi
            var debtors = GetDebtorsForSunexisi();
            context.DebtorsForSunexisi.AddRange(debtors);

            // Seed Banks
            var banks = GetBanks();
            context.Banks.AddRange(banks);

            context.SaveChanges();
        }

        private static List<Baillif> GetBaillifs()
        {
            var id = 1;
            var list = new List<Baillif>();
            list.Add(new Baillif
            {
                Id = id++,
                Name = "Παρασκευή A. Μιχοπούλου",
                City = "Αθήνα",
                AFM = "152255360"
            });
            list.Add(new Baillif
            {
                Id = id++,
                Name = "Ματούλα Ζούζουλα",
                City = "Αθήνα",
                AFM = ""
            });
            list.Add(new Baillif
            {
                Id = id++,
                Name = "..................................................................",
                City = "Αθήνα"
            });
            return list;
        }

        private static List<Attorney> GetNotaries()
        {
            var id = 1;
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Ανδριανοπούλου Δήμητρας",
                City = "Αθηνών",
                Pronoun = "της",
                Description = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας, που εδρεύει στην οδό Ακαδημίας, αριθμός 41 με Α.Φ.Μ. 055298233, Δ.Ο.Υ. Δ' Αθηνών",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "της συμβολαιογράφου ΑΘηνών Αικατερίνη Κωνσταντίνου Οικονόμου που εδρεύει στην οδό Καποδιστρίου αριθμός 18 με Α.Φ.Μ. 996910660,",
                City = "Αθήνας",
                Pronoun = "της",
                Name = "Αικατερίνη Κωνσταντίνου Οικονόμου ",
                GiaSunexisi = "της συμβολαιογράφου ΑΘηνών Αικατερίνη Κωνσταντίνου Οικονόμου "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "της Βαρβάρας Α. Σγούρα, μέλους της Εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΒΑΡΒΑΡΑ Α. ΣΓΟΥΡΑ-ΑΙΚΑΤΕΡΙΝΗ Κ. ΟΙΚΟΝΟΜΟΥ-ΚΩΝΣΤΑΝΤΙΝΟΣ Ε.ΣΤΕΡΓΙΟΥ» που εδρεύει στην Αθήνα, οδός Καποδιστρίου αριθμός 18, με ΑΦΜ 996561989, ΚΕΦΟΔΕ Αττικής",
                City = "Αθήνας",
                Pronoun = "της",
                Name = "Βαρβάρα Σγούρα",
                GiaSunexisi = "της Βαρβάρας Α. Σγούρα, μέλους της Εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΒΑΡΒΑΡΑ Α. ΣΓΟΥΡΑ-ΑΙΚΑΤΕΡΙΝΗ Κ. ΟΙΚΟΝΟΜΟΥ-ΚΩΝΣΤΑΝΤΙΝΟΣ Ε.ΣΤΕΡΓΙΟΥ» που εδρεύει στην Αθήνα, οδός Καποδιστρίου αριθμός 18, με ΑΦΜ 996561989, ΚΕΦΟΔΕ Αττικής"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Σπυρίδων Αθ. Πέτρου, μέλους της συμβολαιγραφικής εταιρείας με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΜΕΛΠΟΜΕΝΗ ΑΘ. ΜΠΑΡΛΑΜΑ - ΣΠΥΡΙΔΩΝ ΑΘ. ΠΕΤΡΟΥ» που εδρεύει στην Αθήνα, οδός Ακαδημίας αριθμός 85, με ΑΦΜ 996965880, Δ.Ο.Υ. Α' Αθηνών",
                City = "Αθήνας",
                Pronoun = "του",
                Name = "Σπυρίδων Πέτρου",
                GiaSunexisi = "του συμβολαιογράφου Αθηνών Σπυρίδων Πέτρου, μέλους της συμβολαιγραφικής εταιρείας με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΜΕΛΠΟΜΕΝΗ ΑΘ. ΜΠΑΡΛΑΜΑ - ΣΠΥΡΙΔΩΝ ΑΘ. ΠΕΤΡΟΥ», που εδρεύει στην Αθήνα, οδός Ακαδημίας αριθμός 85, με ΑΦΜ 996965880, Δ.Ο.Υ. Α' Αθηνών"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Βασιλικής Αθανασίου Λάγιου, που εδρεύει στην Δημοτική κοινότητα Αμαλιάδας του Δήμου Ήλιδας ( οδός Καλαβρύτων αριθμός 35 ), με Α.Φ.Μ. 047614330, Δ.Ο.Υ. Αμαλιάδας",
                City = "Αμαλιάδας",
                Pronoun = "της",
                Name = "Βασιλική Λάγιου"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Κωνσταντίνας Ανδρέα Φουφοπούλου, με έδρα τον Πύργο Ηλείας, Α.Φ.Μ. 107690381 της Δ.Ο.Υ. Πύργου, με Α.Μ. 235 του Συμβολαιογραφικού Συλλόγου Εφετείου Πατρών",
                City = "Πύργου",
                Pronoun = "της",
                Name = "Κωνσταντίνας Ανδρέα Φουφοπούλου",
                GiaSunexisi = "της συμβολαιογράφου Πατρών Κωνσταντίνας Ανδρέα Φουφοπούλου, με έδρα τον Πύργο Ηλείας, Α.Φ.Μ. 107690381 της Δ.Ο.Υ. Πύργου, με Α.Μ. 235 του Συμβολαιογραφικού Συλλόγου Εφετείου Πατρών "

            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "Ευσταθίας Ηλία Μπόλτση με έδρα την Αθήνα οδός Αιόλου αρ. 100, μέλους της αστικής επαγγελματικής εταιρείας με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΕΥΣΤΑΘΙΑ ΜΠΟΛΤΣΗ - ΕΛΕΝΗ ΛΑΓΙΑΝΔΡΕΟΥ», με Α.Φ.Μ. 996797996 της Δ.Ο.Υ. Α' Αθηνών ",
                City = "Αθήνας",
                Pronoun = "της",
                Name = "Ευσταθίας Ηλία Μπόλτση ",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Ευσταθίας Η. Μπόλτση, που εδρεύει στην οδό Αιόλου, αριθμός 100, μέλους της αστικής επαγγελματικής εταιρείας με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΕΥΣΤΑΘΙΑ ΜΠΟΛΤΣΗ - ΕΛΕΝΗ ΛΑΓΙΑΝΔΡΕΟΥ», με Α.Φ.Μ. 996797996 της Δ.Ο.Υ. Α' Αθηνών "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "της Σταυρούλας Περικλή Παρασκευοπούλου-Ευαγγελάκου, συμβολαιογράφου Σπάρτης, με έδρα την Σπάρτη Λακωνίας, με Α.Φ.Μ. 043784858 της Δ.Ο.Υ. Σπάρτης ",
                City = "Σπάρτης",
                Pronoun = "της",
                Name = "Σταυρούλα Περικλή Παρασκευοπούλου-Ευαγγελάκου ",
                GiaSunexisi = "της συμβολαιογράφου Σπάρτης Σταυρούλας Περικλή Παρασκευοπούλου-Ευαγγελάκου με έδρα την Σπάρτη Λακωνίας, με Α.Φ.Μ. 043784858 της Δ.Ο.Υ. Σπάρτης "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Description = "του Όθωνα Κωνσταντίνου Ρούσσου, συμβολαιογράφου Πατρών, μέλους της αστικής επαγγελματικής εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΟΘΩΝ Κ. ΡΟΥΣΣΟΣ – ΕΥΓΕΝΙΑ Π. ΣΤΑΥΡΟΠΟΥΛΟΥ» που εδρεύει στην Πάτρα, οδός Παντανάσσης αριθμός 9, με ΑΦΜ 996502166",
                City = "Πάτρα",
                Pronoun = "του",
                Name = "Όθωνας Ρούσσος",
                GiaSunexisi = "του συμβολαιογράφου Πατρών Όθωνα Κωνσταντίνου Ρούσσου,μέλους της αστικής επαγγελματικής εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΟΘΩΝ Κ. ΡΟΥΣΣΟΣ – ΕΥΓΕΝΙΑ Π. ΣΤΑΥΡΟΠΟΥΛΟΥ» που εδρεύει στην Πάτρα, οδός Παντανάσσης αριθμός 9, με ΑΦΜ 996502166"
            });
            return list;
        }

        private static List<Attorney> GetNotariesNew()
        {
            var id = 100; // Start from different ID to avoid conflicts
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Δήμητρα Ν. Ανδριανοπούλου",
                City = "Αθηνών",
                Pronoun = "της",
                Description = "που εδρεύει στην οδό Ακαδημίας 41,",
                GiaSunexisi = "της συμβολαιογράφου Αθηνών Ανδριανοπούλου Ν. Δήμητρας "
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Βασιλική Θ. Παπαγεωργίου",
                City = "Πατρών",
                Pronoun = "της",
                Description = "που εδρεύει στην οδό Κανακάρη αρ. 149-153,",
                GiaSunexisi = "της συμβολαιογράφου Πατρών Βασιλικής Θ. Παπαγεωργίου"
            });
            // Add remaining notaries...
            return list;
        }

        private static List<Attorney> GetAttorneysList()
        {
            var id = 200; // Start from different ID to avoid conflicts
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Ευαγγελίας Ξυπνητού",
                City = "Ναυπλίου",
                Pronoun = "της"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Σπήλιου Σπηλιόπουλου",
                City = "Αθήνας",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Επαμεινώνδας Παπαδέας",
                City = "Αθήνα",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Μίλτος Δημητρόπουλος",
                City = "Πύργου",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Αλεξάνδρα Κβάσνιουκ",
                City = "Πύργου",
                Pronoun = "της"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Μάνος Παπαντωνάκης",
                City = "Ηρακλείου Κρήτης",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Αθανάσιος Αμπατζής",
                City = "Πάτρας",
                Pronoun = "του"
            });
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Κρινιώ Τσάφα",
                City = "Αμαλιάδας",
                Pronoun = "της"
            });
            return list;
        }

        private static List<Fund> GetFunds()
        {
            var id = 1;
            var list = new List<Fund>();
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY I FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "FRONTIER ISSUER DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "BLUEBELL ISSUER DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "CAIRO 2 FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "CAIRO 1 FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "POSEIDON DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GRAMILTON DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "MEXICO FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY II FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY III FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GALAXY IV FUNDING DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "GEMINI CORE SECURITISATION DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "HOIST FINANCE AB",
                Description = "με έδρα τη Στοκχολμη Σουηδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "Poseidon Financial Investor Designated Activity Company",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "SYMBOL INVESTMENT NPLCo DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "SUNRISE I NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ",
                Description = "",
                MAEDAP = "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.",
                MAEDAPAdress = "που εδρεύει στην Αθήνα, οδός Αιόλου αρ. 86 με Α.Φ.Μ.: 094014201 Δ.Ο.Υ. ΦΑΕ Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "VEGA I NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "VEGA II NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "VEGA III NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "PHOENIX NPL FINANCE DAC",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "INTRUM HELLAS ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Αθήνα, επί της Λεωφόρου Μεσογείων αρ. 109-111, Α.Φ.Μ. 801215902, Δ.Ο.Υ. Φ.Α.Ε. Αθηνών"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "PILLAR FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μαρούσι Αττικής, επί της Λεωφόρου Κηφισίας αριθ. 66, με ΑΦΜ 800858891  της Δ.Ο.Υ. ΦΑΕ Αθηνών και με αριθ. ΓΕΜΗ 143190101000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "ORION X SECURITISATION DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "COSMOS SECURITISATION DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "DYSART II DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στην Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209-211, Α.Φ.Μ. 800715056, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά, με αρ. ΓΕΜΗ 138019601000"
            });
            list.Add(new Fund
            {
                Id = id++,
                Name = "XYQ Luxco S. ar.I.",
                Description = "με έδρα το Λουξεμβούργο",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
            });
            return list;
        }

        private static List<Zone> GetZones()
        {
            var list = new List<Zone>();
            list.Add(new Zone
            {
                Id = 1,
                Name = "Α",
                Value = 35d,
                Tax = 8.40d,
                TaxedValue = 43.40d
            });
            list.Add(new Zone
            {
                Id = 2,
                Name = "Β",
                Value = 55d,
                Tax = 13.2d,
                TaxedValue = 68.2d
            });
            list.Add(new Zone
            {
                Id = 3,
                Name = "Γ",
                Value = 73d,
                Tax = 17.52d,
                TaxedValue = 90.52d
            });
            list.Add(new Zone
            {
                Id = 4,
                Name = "Δ",
                Value = 95,
                Tax = 22.8d,
                TaxedValue = 117.8d
            });
            list.Add(new Zone
            {
                Id = 5,
                Name = "Α20",
                Value = 28,
                Tax = 6.72d,
                TaxedValue = 34.72d
            });
            list.Add(new Zone
            {
                Id = 6,
                Name = "Β20",
                Value = 44d,
                Tax = 10.56d,
                TaxedValue = 54.56d
            });
            list.Add(new Zone
            {
                Id = 7,
                Name = "Γ20",
                Value = 58.4d,
                Tax = 14.02d,
                TaxedValue = 72.42d
            });
            list.Add(new Zone
            {
                Id = 8,
                Name = "Δ20",
                Value = 76d,
                Tax = 18.24d,
                TaxedValue = 94.24d
            });
            return list;
        }

        private static List<EkthesiEpidoshsModel> GetZipFiles()
        {
            // This method returns all document templates from the legacy DropDownGenerator
            // Note: The original method in DropDownGenerator.cs had ~70+ entries
            // Due to size, we reference the original for the complete list
            var generator = new DropDownGenerator();
            return generator.GetZipFiles();
        }

        private static List<DebtorForSunexisi> GetDebtorsForSunexisi()
        {
            var list = new List<DebtorForSunexisi>();
            list.Add(new DebtorForSunexisi
            {
                Id = 1,
                Name = "Βρεττός Cepal Galaxy Alfa",
                Description = "του Νικολάου  Βρεττού του Λαζάρου και της Κωνσταντίνας, κατοίκου Αθηνών, οδός Ηλείας αρ.5-7, με Α.Φ.Μ. 042326390 Δ.Ο.Υ. Δ' Αθηνών..."
            });
            // Add more entries as needed
            return list;
        }

        private static List<PistotikaIdrymataUpoEkkatharisi> GetBanks()
        {
            var list = new List<PistotikaIdrymataUpoEkkatharisi>();
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 1,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ",
                DiakritikosTitlos = "ΕΥΒΟΙΚΗ ΠΙΣΤΗ",
                Edra = "που εδρεύει στην Χαλκίδα του Δήμου Χαλκιδέων Ευβοίας, οδός Βελισσαρίου αρ. 2,",
                AFM = "με Α.Φ.Μ. 096123566"
            });
            // Add more banks as needed
            return list;
        }
    }
}
