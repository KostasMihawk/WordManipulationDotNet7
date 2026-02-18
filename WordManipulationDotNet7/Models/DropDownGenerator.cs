using System;
using System.Diagnostics;

namespace WordManipulationDotNet7.Models
{
    public class DropDownGenerator
    {
        public List<Baillif> GetBaillifs()
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

        public List<Attorney> GetNotaries()
        {
            var id = 1;
            var list = new List<Attorney>();
            list.Add(new Attorney
            {
                Id = id++,
                Name = "Ανδριανοπούλου Δήμητρας",
                City = "Αθήνας",
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

        public List<Attorney> GetNotariesNew()
        {
            var id = 1;
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
            list.Add(new Attorney
            {
                Id = id++,
                Description = "μέλους της αστικής επαγγελματικής εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΟΘΩΝ Κ. ΡΟΥΣΣΟΣ – ΕΥΓΕΝΙΑ Π. ΣΤΑΥΡΟΠΟΥΛΟΥ» που εδρεύει στην Πάτρα, οδός Παντανάσσης αριθμός 9, με ΑΦΜ 996502166",
                City = "Πάτρας",
                Pronoun = "του",
                Name = "Όθωνα Ρούσσο",
                GiaSunexisi = "του συμβολαιογράφου Πατρών Όθωνα Κωνσταντίνου Ρούσσου,μέλους της αστικής επαγγελματικής εταιρείας Συμβολαιογράφων με την επωνυμία «ΕΤΑΙΡΕΙΑ ΣΥΜΒΟΛΑΙΟΓΡΑΦΩΝ ΟΘΩΝ Κ. ΡΟΥΣΣΟΣ – ΕΥΓΕΝΙΑ Π. ΣΤΑΥΡΟΠΟΥΛΟΥ» που εδρεύει στην Πάτρα, οδός Παντανάσσης αριθμός 9, με ΑΦΜ 996502166"
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
                Description = "της συμβολαιογράφου ΑΘηνών Αικατερίνη Κωνσταντίνου Οικονόμου που εδρεύει στην οδό Καποδιστρίου αριθμός 18 με Α.Φ.Μ. 996910660,",
                City = "Αθήνας",
                Pronoun = "της",
                Name = "Αικατερίνη Κωνσταντίνου Οικονόμου ",
                GiaSunexisi = "της συμβολαιογράφου ΑΘηνών Αικατερίνη Κωνσταντίνου Οικονόμου "
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
            return list;
        }


        public List<Fund> GetFunds()
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
                Name = "FRONTIER II ISSUER DESIGNATED ACTIVITY COMPANY",
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
                Name = "NIGHTSHADE ISSUER DESIGNATED ACTIVITY COMPANY",
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
                //todo need to fix e8niki since it is not a fund
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
                Name = "LEON CAPITAL FINANCE DESIGNATED ACTIVITY COMPANY",
                Description = "με έδρα το Δουβλίνο Ιρλανδίας",
                MAEDAP = "DOVALUE GREECE  ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ",
                MAEDAPAdress = "στο Μοσχάτο Αττικής, επί της Κύπρου αρ. 27 και Αρχιμήδους, Α.Φ.Μ. 099755919, Δ.Ο.Υ. Φ.Α.Ε. Πειραιά,"
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
        public List<Attorney> GetAttorneysList()
        {
            var id = 1;
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

        public List<Zone> GetZones()
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

       

       



        //Praxi equals 
        public List<EkthesiEpidoshsModel> GetZipFiles()
        {
            var list = new List<EkthesiEpidoshsModel>();
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "_Ε.Φ.Κ.Α.",
                Perigrafh = "προς το Ν.Π.Δ.Δ. με την επωνυμία e-ΕΦΚΑ που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                Signature = Signature.paralavon,
                HasKleisimo = Kleisimo.exei,
                PriorityNumber = 1,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο του άνω Ν.Π.Δ.Δ. στην έδρα του επί της οδού Αγίου Κωνσταντίνου αρ. 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτού …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. " /// <------
            }) ;
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "_Α' ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ",
                Perigrafh = "προς τη Α' Περιφερειακή Διεύθυνση ΚΕΑΟ Αττικής,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false,
                PriorityNumber = 1,
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Veraltis",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «VERALTIS ASSET MANAGEMENT ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «VERALTIS ASSET MANAGEMENT ΑΕΔΑΔΠ», η οποία εδρεύει στην Αθήνα, επί της Λεωφόρου Κηφισίας αρ. 1-3, και εκπροσωπείται νόμιμα, ως εντολοδόχο και ειδικό πληρεξούσιο, αντιπρόσωπο και αντίκλητο της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «HELLAS 3P INVEMSTEMT DESIGNATED ACTIVITY COMPANY», που εδρεύει στο Δουβλίνο Ιρλανδίας και εκπροσωπείται νόμιμα, και η οποία κατέστη ειδική διάδοχος των απαιτήσεων της «ULTIMO PORTFOLIO INVESTMENT S.A.», ως ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ Α.Ε.», που εδρεύει στην Αθήνα, όπως εκπροσωπείται νόμιμα",
                Praxh = null,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Κηφισίας αρ.1-3, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "_Β' ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ",
                Perigrafh = "προς τη Β' Περιφερειακή Διεύθυνση ΚΕΑΟ Αττικής,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false,
                PriorityNumber= 1
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "_ΚΕΑΟ ΠΕΙΡΑΙΑ",
                Perigrafh = "προς το ΠΕΡΙΦΕΡΕΙΑΚΟ ΚΕΑΟ ΠΕΙΡΑΙΩΣ ΒΟΡΕΙΟΥ ΚΑΙ ΝΟΤΙΟΥ ΑΙΓΑΙΟΥα,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ελευσίνα",
                Name = "ΚΕΑΟ ΕΛΕΥΣΙΝΑΣ",
                Perigrafh = "προς το e-ΕΦΚΑ, ΑΠΟΚΕΝΤΡΩΜΕΝΟ ΤΜΗΜΑ ΚΕΑΟ ΔΥΤΙΚΗΣ ΑΤΤΙΚΗΣ ΜΕ ΕΔΡΑ ΣΤΗΝ ΕΛΕΥΣΙΝΑ,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "                 ",
                Name = "Δ.Ο.Υ. (Εφοριες)",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) Α Αθηνων",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Α Αθηνών,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Αμαρουσιου",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Αμαρουσίου,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            }); 
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Νίκαια Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Νίκαιας",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Νίκαιας,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αιγάλεω Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Αιγάλεω",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Αιγάλεω,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "_ΚΕΒΕΙΣ",
                Perigrafh = "προς τον προϊστάμενο του ΚΕ.Β.ΕΙΣ ΑΤΤΙΚΗΣ,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Ταύρο Αττικής",
                Name = "_ΚΕΦΟΔΕ ΑΤΤΙΚΗΣ",
                Perigrafh = "προς τον προϊστάμενο του ΚΕ.ΦΟ.Δ.Ε. ΑΤΤΙΚΗΣ,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ΔΗΜΟΣ ΑΘΗΝΑΙΩΝ",
                Perigrafh = "προς τον ΔΗΜΟ ΑΘΗΝΑΙΩΝ,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Περιστέρι Αττικής",
                Name = "ΔΗΜΟΣ ΠΕΡΙΣΤΕΡΙΟΥ",
                Perigrafh = "προς τον ΔΗΜΟ ΠΕΡΙΣΤΕΡΙΟΥ,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Χαλάνδρι Αττικής",
                Name = "APS RECOVERY GREECE",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «APS Recovery Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» υπό την ιδιότητα της ως διαχειρίστριας των μεταβοβασθέντων απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «APS DELTA SA» ενεργούσα δια του τμήματος Άρκτος, ως ειδικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «Τράπεζα Πειραιώς Α.Ε.», νομίμως εκπροσωπούμενης,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.exei,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Παλαιολόγου αρ.7, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά Αττικής",
                Name = "ΔΗΜΟΣ ΠΕΙΡΑΙΑ",
                Perigrafh = "προς τον ΔΗΜΟ ΠΕΙΡΑΙΑ,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "Δ.Ο.Υ. (Εφοριες) Ε Πειραιά",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Ε Πειραιά,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στους Αγίους Αναργύρους Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Αγίοι Ανάργυροι",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Αγίων Αναργύρων,",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) ΙΓ Αθηνών",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ ΙΓ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Γλυφάδα Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Γλυφάδας",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Γλυφάδας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ηλιούπολη Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Ηλιούπολης",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Ηλιούπολης, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) Δ Αθηνών",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Δ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) IZ Αθηνών",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ IZ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Ιωνία Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Νεας Ιωνίας",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Νέας Ιωνίας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Κηφισιά Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Κηφισιάς",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Κηφισιάς, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) ΚΕΜΕΕΠ",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Κέντρο Ελέγχου Μεγάλων Επιχειρήσεων, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Περιστέρι Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Α Περιστερίου",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Περιστερίου, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ελευσίνα Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Ελευσίνας",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Ελευσίνας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "Δ.Ο.Υ. (Εφοριες) Α Πειραιά",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Α Πειραιά, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "Δ.Ο.Υ. (Εφοριες) Πλοίων",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Πλοίων, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Παλλήνη Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Παλλήνης",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Παλλήνης, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Δ.Ο.Υ. (Εφοριες) ΦΑΕ ΑΘΗΝΩΝ",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ ΦΑΕ Αθηνών, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Χολαργό Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Χολαργού",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Χολαργού, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) Καλλιθέας",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ Καλλιθέας, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά Αττικής",
                Name = "Δ.Ο.Υ. (Εφοριες) ΦΑΕ Πειραιά",
                Perigrafh = "προς τον προϊστάμενο της ΔΟΥ ΦΑΕ Πειραιά, ",
                Praxh = null,
                Signature = Signature.ypallilos,
                HasKleisimo = Kleisimo.denExei,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "_ΤΕΛ",
                Perigrafh = "προς την Τελωνειακή Περιφέρεια Αττικής,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false,
                PriorityNumber =1
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "ΤΕΛΩΝΕΙΟ Α ΠΕΙΡΑΙΑ",
                Perigrafh = "προς το Α Τελωνείο Πειραιά,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Μεταμόρφωση Αττικής",
                Name = "_ΤΕΛΩΝΕΙΟ Α ΑΘΗΝΩΝ",
                Perigrafh = "προς το ΤΕΛΩΝΕΙΟ Α ΑΘΗΝΩΝ,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                ZoneB = true,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Λαύριο Αττικής",
                Name = "Τελωνείου Λαυρίου",
                Perigrafh = "προς το Τελωνείο Λαυρίου,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false,
                ZoneB = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ελευσίνα Αττικής",
                Name = "Τελωνείο Ελευσίνας",
                Perigrafh = "προς το Τελωνείο Ελευσίνας,",
                Praxh = null,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                FusikoProswpo = false,
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Άλιμο Αττικής",
                Name = "ΟΑΕΔ",
                Perigrafh = "προς τον Δημόσια Υπηρεσία Αποσχόλησης,",
                Praxh = null,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                ZoneB = true,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω εταιρείας στην έδρα της στην οδό Εθνικής Αντιστάσεως αρ. 8 ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο. "
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στον Πειραιά",
                Name = "_ΟΛΠ",
                Perigrafh = "προς τον Οργανισμό Λιμένος Πειραιώς Α.Ε.,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                PriorityNumber =1,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω εταιρείας στην έδρα της στην οδό Ακτή Μιαούλη αρ. 10 ούτε Διευθυντή ή συνεργάτη, αλλά την εξουσιοδοτημένη για την παραλαβή υπάλληλο αυτής Βλασιάδου Ευαγγελία, όπως μου δήλωσε, επέδωσα σ΄ αυτην το άνω δικόγραφο. "
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "_ΑΑΔΕ (Υπουργος Οικονομικων)",
                Perigrafh = "προς τον κ. Διοικητή Της Ανεξάρτητης Αρχής Δημοσίων Εσόδων (Α.Α.Δ.Ε.), ως εκπρόσωπο του Ελληνικού Δημοσίου, κατοικοεδρεύοντα στην Αθήνα,",
                Praxh = null,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.denExei,
                Signature = Signature.ypallilos,
                PriorityNumber =1,
                Kleisimo = "Αφού δεν βρήκα τον ίδιο στην έδρα του Νομικού Συμβουλίου του Κράτους επί της οδού Ακαδημίας & Χαρ. Τρικούπη, όπου σύμφωνα με τον Νόμο γίνονται οι επιδόσεις προς αυτόν, ούτε Διευθυντή ή συνεργάτη του, αλλά τ... εξουσιοδοτημέν... γιά την παραλαβή υπάλληλο Ν.Σ.Κ. ............................................, επέδωσα σ΄ αυτ... το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "",
                Name = "_Οφειλέτης",
                Perigrafh = "προς τον ",
                Praxh = true,
                HasKleisimo = Kleisimo.MegaloKeno,
                Signature = Signature.genericMartyras,
                FusikoProswpo = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "",
                Name = "Μπαλαντερ",
                Perigrafh = "",
                Praxh = false,
                FusikoProswpo = false
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Εθνική Τράπεζα",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «Εθνική Τράπεζα της Ελλάδος Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα με ΑΦΜ 094014201",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Αιόλου αρ.86, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "EUROBANK",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «Τράπεζα Eurobank Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Πανεπιστημίου αρ.36, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "SUNSHINE LEASING",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «SUNSHINE LEASES ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «SUNSHINE LEASES MAE» η οποία εδρεύει στην Αθήνα, οδός Πανεπιστημίου αρ. 39 και εκπροσωπείται νόμιμα, ως καθολική διάδοχος της ανώνυμης εταιρείας με την επωνυμία «ΠΕΙΡΑΙΩΣ FINANCIAL LEASING ΧΡΗΜΑΤΟΔΟΤΙΚΕΣ ΜΙΣΘΩΣΕΙΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΤΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ΠΕΙΡΑΙΩΣ FINANCIAL LEASING M.A.E.» η οποία πρότερον έφερε την επωνυμία «CPB LEASING ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ ΧΡΗΜΑΤΟΔΟΤΙΚΩΝ ΜΙΣΘΩΣΕΩΝ» και τον διακριτικό τίτλο «CPB LEASING A.E.», πρότερον την επωνυμία «LAIKI LEASING ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ ΧΡΗΜΑΤΟΔΟΤΙΚΩΝ ΜΙΣΘΩΣΕΩΝ» και τον διακριτικό τίτλο «LAIKI LEASING A.E.» πρότερον την επωνυμία «MARFIN ΧΡΗΜΑΤΟΔΟΤΙΚΕΣ ΜΙΣΘΩΣΕΙΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «MARFIN LEASING A.E.» και πρότερον την επωνυμία «ΕΓΝΑΤΙΑ ΛΗΖΙΝΓΚ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ ΧΡΗΜΑΤΟΔΙΚΗΣ ΜΙΣΘΩΣΗΣ» και τον διακριτικό τίτλο «EGNATIA LEASING S.A.», η οποία είχε καταστεί καθολική διάδοχος της ανώνυμης εταιρείας με την επωνυμία «ΛΑΪΚΗ ΧΡΗΜΑΤΟΔΟΙΚΕΣ ΜΙΣΘΩΣΕΙΣ Α.Ε.» και τον διακριτικό τίτλο «ΛΑΪΚΗ LEASING A.E.»",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Πανεπιστημίου αρ.39, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ΠΕΙΡΑΙΩΣ",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «Τράπεζα Πειραιώς Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφόρο Αλεξάνδρας αρ.170, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ΑΛΦΑ ΤΡΑΠΕΖΑ",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΦΛΑ ΤΡΑΠΕΖΑ Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Πανεπιστημίου αρ.43, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Asopus",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων σύμφωνα με τις διατάξεις του Ν. 4354/2015, όπως αυτός τροποποιημένος ισχύει, της εταιρείας ειδικού σκοπού με την επωνυμία «Asopus LP», συσταθείσας σύμφωνα με το δίκαιο της πολιτείας του Delaware (Ντελαγουερ) των Ηνωμένων Πολιτειών της Αμερικής, η οποία εδρεύει στο Corporation Trust Centre, 1209 Orange Street, City Of Wilmington 1980 και εκπροσωπείται  νόμιμα, οι οποίες απαιτήσεις έχουν μεταβιβαστεί στο πλάισιο τιτλοποίησης αξιώσεων σύμφωνα με τις διατάξεις του Ν. 3156/2003, από την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αιόλου αρ. 86",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                ZoneB = true,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Metalaxis",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «ABS METALAXIS SA»,δια του Compartment 1 αυτής, που εδρεύει στο Λουξεμβούργο (Rue de Bitbourg 19L-1273,Μεγάλο Δουκάτο του Λουξεμβούργου), όπως εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», με έδρα στην Αθήνα, επί της οδού Ομήρου αρ. 23",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                ZoneB = true,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant PILLAR",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «PILLAR FINANCE DESIGNATED ACTIVITY»,δια του Compartment 1 αυτής, που εδρεύει στο Λουξεμβούργο (Rue de Bitbourg 19L-1273,Μεγάλο Δουκάτο του Λουξεμβούργου), όπως εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», με έδρα στην Αθήνα, επί της οδού Ομήρου αρ. 23",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                ZoneB = true,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Intrum Hellas 2",
                Perigrafh = "προς την ανώνυμη  εταιρεία με την επωνυμία «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «INTRUM HELLAS 2 DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας, κτίριο 1-2, οδός Χάντιγκτον, 1ος όροφος, Τ.Κ. D04XN32(Dublin, Ireland, 1-2 Victoria Buildings, Haddington Road, 1st Floor, Eircode D04XN32), και εκπροσωπείται νόμιμα, οι οποίες απαιτήσεις έχουν μεταβιβαστεί στο πλαίσιο τιτλοποίησης αξιώσεων σύμφωνα με τις διατάξεις του Ν. 3156/2003, από την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αιόλου αρ. 86",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                ZoneB = true,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Attica",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων, της εταιρείας ειδικού σκοπού με την επωνυμία «ABS METEXELIXIS S.A.», η οποία εδρεύει στο Μεγάλο Δουκάτο του Λουξεμβούργου, οδός r. deBitbourg αρ. 19, L-1273 και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Ομήρου αρ. 23 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                ZoneB = true,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "QQuant Alpheus",
                Perigrafh = "προς την QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» (η οποία έφερε πρότερον την επωνυμία «QQUANT MASTER SERVICER ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «QQUANT MASTER SERVICER Α.Ε.Δ.Α.Δ.Π.»), η οποία εδρεύει στο Αμαρούσιο Αττικής οδός Παραδείσου αρ. 16 και εκπροσωπείται νόμιμα, ως εντολοδόχος και ειδική πληρεξούσια, αντιπρόσωπος, αντίκλητος και διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «ALPHEUS HELLAS DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (1-2 Victoria Buildings, Haddington Road, 1st Floor, Eircode D04XN32) και εκπροσωπείται  νόμιμα, από την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                ZoneB = true,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Παραδείσου 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, ως διαχειρίστρια των απαιτήσεων της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, η οποία είχε καταστεί οιονεί καθολική διάδοχος των περουσιακών στοιχείων της «ΓΕΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε», ",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum Iris Πειραιως Leasing",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το δ.τ. «INTRUM HELLAS ΑΕΔΑΔΠ», που εδρεύει στο Δήμο Αθηναίων, Λεωφ. Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, επ’ ονόματι και για λογαριασμό της αλλοδαπής εταιρείας με την επωνυμία «IRIS HELLAS INVESTMENTS DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας και εκπροσωπείται νόμιμα, ειδική διάδοχος της μονοπρόσωπης εταιρείας με την επωνυμία «ΠΕΙΡΑΙΩΣ LEASING ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΜΙΣΘΩΣΕΙΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον δ.τ. «ΠΕΙΡΑΙΩΣ LEASING», κατόπιν αλλαγής της επωνυμίας και του εταιρικού τίτλου της ανώνυμης εταιρείας με την επωνυμία «ΠΕΙΡΑΙΩΣ LEASING ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΜΙΣΘΩΣΕΙΣ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», ",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum sunrise",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π.»που εδρεύει στο Δήμο Αθηναίων Λεωφόρος Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «SUNRISE I NPL FINANCE DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (οδός George’s Dock ar. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum sunrise II",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π.»που εδρεύει στο Δήμο Αθηναίων Λεωφόρος Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «SUNRISE II NPL FINANCE DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (οδός George’s Dock ar. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum sunrise estia",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, ενεργούσας δυνάμει της από 21-7-2020 σύμβαση, επ` ονόματι και για λογαριασμό της εταιρείας «Phoenix NPL Finance Designated Activity Company» που εδρεύει στο Δουβλίνο Ιρλανδίας ( με αρ. μητρώου 670746 και διεύθυνση George’s Dock, IFSC, 4ος όροφος, Δουβλίνο 1) ως νομίμως εκπροσωπείται, ως ειδική διάδοχος της Ανώνυμης Τραπεζικής Εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» που εδρεύει στην Αθήνα, οδός Αμερικής αρ. 4, με ΑΦΜ: 094014298, ως νομίμως εκπροσωπείται, ειδική διάδοχος της οποίας είχε καταστεί η εταιρεία ειδικού σκοπού «ESTIA MORTAGE FINANCE PLC» δυνάμει της από 12-12-2016 Σύμβασης Επανεκχώρησης Απαιτήσεων, διεπόμενης από το ελληνικό δίκαιο και νομίμως καταχωρημένης στον τόμο 8 και αυξ. Αρ. 306 των δημόσιων βιβλίων το υν. 2844/2000 του Ενεχυροφυλακείου Αθηνών ( αριθμός πρωτ. 15/175/12-02-2016) μετά του Παραρτήματος της, ως αναπόσπαστο μέρος και ενιαίο όλο, στο οποίο η απαίτηση φέρει α/α 103, με την οποία τα μέρη προέβησαν σε αναμεταβίβαση μέρους των απαιτήσεων, που μεταβιβάσθηκαν για τους σκοπούς της τιτλοποίησης, δυνάμει της από 20-05-2009 σύμβασης πώλησης και μεταβίβασης επιχειρηματικών απαιτήσεων του ν. 3156/03, που καταχωρήθηκε στον τόμο 4 και αυξ. Αριθμ. 124 του δημοσίου βιβλίου του άρθρου 3 του ν. 2844/2000 Ενεχυροφυλακείου Αθηνών,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum vega II",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «VEGA II NPL FINANCE DAC»,η οποία εδρεύει στο Δουβλίνο Ιρλανδίας ( οδός George’s Dock αρ. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum vega III",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «VEGA III NPL FINANCE DAC»,η οποία εδρεύει στο Δουβλίνο Ιρλανδίας ( οδός George’s Dock αρ. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum vega",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «VEGA II NPL FINANCE DAC»,η οποία εδρεύει στο Δουβλίνο Ιρλανδίας ( οδός George’s Dock αρ. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum snf",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και το διακριτικό τίτλο «INTRUM HELLAS ΑΕΔΑΔΠ», όπως μετονομάστηκε από «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στην Αθήνα Λεωφόρος Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα, η οποία ενεργεί επ’ ονόματι και για λογαριασμό της αλλοδαπής εταιρείας με την επωνυμία «PIREUS SNF DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας Palmerston House, 2ος όροφος, Fenian Street, Δουβλίνο 2 και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα, η οποία είχε καταστεί οιονεί καθολική διάδοχος των περουσιακών στοιχείων της «ΓΕΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε», ",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "Intrum me phoenix",
                Perigrafh = "προς την «INTRUM HELLAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «INTRUM HELLAS Α.Ε.Δ.Α.Δ.Π.» (πρώην «ALTERNATIVE FINANCIAL SOLUTIONS ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΩΝ» και τον διακριτικό τίτλο «ALTERNATIVE FINANCIAL SOLUTIONS Μ.Α.Ε.Δ.Α.Δ.Π»), η οποία εδρεύει στο Δήμο Αθηναίων επί της Λεωφόρου Μεσογείων αρ. 109-111 και εκπροσωπείται νόμιμα η οποία ενεργεί εν προκειμένω ως μη δικαιούχος και μη υπόχρεος διάδικος και ως διαχειρίστρια των απαιτήσεων της αλλοδαπής εταιρείας με την επωνυμία «PHOENIX NPL FINANCE DAC»,η οποία εδρεύει στο Δουβλίνο Ιρλανδίας ( οδός George’s Dock αρ. 3, 4ος όροφος IFSC, Δουβλίνο 1) και εκπροσωπείται νόμιμα, η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.» η οποία εδρεύει στην Αθήνα οδός Αμερικής αρ. 4 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Μεσογείων 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "PRAXIA",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «NPA SERVICING ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε.Δ.Α.Δ.Π.» ως εντολοδόχου, ειδικής πληρεξουσίου, αντιπροσώπου και αντικλήτου, της εταιρείας με την επωνυμία «ΤΑΜΖΟ HOLDINGS LTD», με έδρα στη Λευκωσία Κύπρου, όπως νομίμως εκπροσωπείται, η οποία κατέστη ειδική διάδοχος της Ανώνυμης Τραπεζικής Εταιρείας «Vivabank Μονοπρόσωπη Ανώνυμη Τραπεζική Εταιρεία» όπως μετονομάστηκε η εταιρία με την επωνυμία «PRAXIA BANK ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ» και δ.τ. «PRAXIA BANK» η οποία εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Κηφισίας 16, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal",
                Perigrafh = "προς την «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», η οποία εδρεύει στην Αθήνα, Λεωφόρος Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal Monza",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «MONZA NPL DESIGNATED ACTIVITY COMPANY» και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ Α.Ε.», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal GEMINI",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «GEMINI CORE SECURITISATION DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας, 1-2 Victoria Buildings, Haddington Road, Dublin 4, D04 XN32 και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal DOMUS",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «DOMUS 1 SECURITISATION DESIGNATED ACTIVITY COMPANY» και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑTTICA BANK  ΑΝΩΝΥΜΟΣ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal RODUS",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως πληρεξουσίας, εντολοδόχου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «RHODIUM I FINANVE DESIGNATED ACTIVITY COMPANY», που εδρεύει στην Ιρλανδία, όπως εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΊΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα,και η οποία τυγχάνει καθολική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΠΑΓΚΡΗΤΙΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal HERMES",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «HERMES ACQUISITIONS B DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίαςκαι εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Συγγρού 209-211, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στη Νέα Σμύρνη Αττικής",
                Name = "Cepal HOIST",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «HOIST FINANCE AB(PUBL)» η οποία εδρεύει στη Σουηδία (Box 7848, 10399 Stockholm) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal LANA",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «LANA SECURITIZATION S.A.R.L.» όπως εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal GALAXY II",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «GALAXY II FUNDING DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (1-2 Victoria Buildings, Haddington Road, Dublin 4, D04 XN32) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal GALAXY III",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «GALAXY III FUNDING DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (1-2 Victoria Buildings, Haddington Road, Dublin 4, D04 XN32) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal GALAXY IV",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «GALAXY IV FUNDING DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (1-2 Victoria Buildings, Haddington Road, Dublin 4, D04 XN32) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal SYMBOL",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων και νόμιμης εκπροσώπου της εταιρείας ειδικού σκοπού με την επωνυμία «Symbol Investment NPLCo Designated Activity Company»  η οποία εδρεύει στην Ιρλανδία στη διεύθυνση 5ος όροφος. The Exchange, George’s Dock, IFSC, Dublin 1, D01 και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.» που εδρεύει στην Αθήνα, οδός Αιόλου αρ. 86 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal GAIA",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία «GAIA SECURITISATION II DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στην Ιρλανδίας και εκπροσωπείται νόμιμα, ως ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal COSMOS",
                Perigrafh = "προς την «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», η οποία εδρεύει στην Αθήνα, Λεωφόρος Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιοότητα της ως Εταιρείας Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις, εντολοδόχου, ειδικού πληρεξουσίου, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «COSMOS SECURITISATION DESIGNATED ACTIVITY COMPANY» με έδρα το Δουβλίνο Ιρλανδίας, επί της οδού Haddington αρ. 1-2, Victoria Buildings, η οποία έχει καταστεί ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal ORION",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου Συγγρού αρ. 209 - 211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων και νόμιμης εκπροσώπου της εταιρείας ειδικού σκοπού με την επωνυμία «ORION X SECURITISATION DESIGNATED ACTIVITY COMPANY», που εδρεύει στο Δουβλίνο Ιρλανδίας(1 - 2 VICTORIA BUINDINGS, HADDIGNTON ROAN, DUBLIN 4, D04, XN32) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            }); list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Καλλιθέα Αττικής",
                Name = "Cepal Poseidon",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφόρου  Συγγρού αρ. 209-211 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων, εντολοδόχου και ειδικής πληρεξουσίας, αντιπροσώπου και αντικλήτου της εταιρείας ειδικού σκοπού με την επωνυμία «POSEIDON FINANCIAL INVESTOR DESIGNATED ACTIVITY COMPANY» η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (Cape House, Westend Office Park, Snugborough Road, Blanchardtown, Δουβλίνο 15) και εκπροσωπείται νόμιμα, της τελευταίας ως ειδικού διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», που εδρεύει στην Αθήνα, οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Λεωφ. Συγγρού 348, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa me citibank",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως καθολικής διαδόχου της ανώνυμης εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» (και ήδη μετονομασθείσας σε «ALPHA ΥΠΗΡΕΣΙΩΝ ΚΑΙ ΣΥΜΜΕΤΕΧΩΝ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»), κατόπιν διάσπασης της τελευταίας με απόσχιση του κλάδου της τραπεζικής δραστηριότητας και εισφοράς του στη νεοσυσταθείσα εταιρεία – πιστωτικό ίδρυμα, ενεργούσας για τις απαιτήσεις της ιδίας καθώς και ως ειδικής διαδόχου της «CITIBANK INTERNATIONAL PLC»,",
                Praxh = true,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Σταδίου 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK», η οποία εδρεύει στην Αθήνα οδός Σταδίου αρ. 40 και εκπροσωπείται νόμιμα, με αριθμο ΓΕΜΗ 159029160000 και ΑΦΜ 996807331 υπό την ιδιότητα της ως καθολικής διαδόχου της ανώνυμης εταιρείας με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» (και ήδη μετονομασθείσας σε «ALPHA ΥΠΗΡΕΣΙΩΝ ΚΑΙ ΣΥΜΜΕΤΕΧΩΝ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ με αριθμο ΓΕΜΗ 223791000 και ΑΦΜ 094014249,",
                Praxh = true,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Σταδίου 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ALfa διασπαση",
                Perigrafh = "προς την  ανώνυμη τραπεζική εταιρεία με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ALPHA BANK»(επωφελούμενη), η οποία εδρεύει στην Αθήνα και επί της οδού Σταδίου αρ. 40, με ΑΦΜ 996807331 όπως εκπροσωπείται νόμιμα ως καθολικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ALPHA ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»(Διασπώμενη), κατόπιν διάσπασης τελευταίας με απόσχιση του κλάδου της τραπεζικής δραστηριότητας και εισφοράς του στη νεοσυσταθείσα εταιρεία-πιστωτικό ίδρυμα,",
                Praxh = true,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                FusikoProswpo = false,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Σταδίου 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Cairo 2",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CAIRO No 2 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Corinth",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CORINTH FINANCIAL INVESTOR DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας και εκπροσωπείται νόμιμα, στην οποία μεταβιβάστηκαν απαιτήσεις από την αλλοδαπή εταιρεία ειδικού σκοπού με την επωνυμία «CAIRO NO.1 FINANCE DESIGNATED ACTIVITY COMPANY», που εδρεύει στο Δουβλίνο και εκπροσωπείται νόμιμα, και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me leon",
                Perigrafh = " ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας «LEON CAPITAL FINANCE DESIGNATED ACTIVITY COMPANY» και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Pillar",
                Perigrafh = "  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας «INTRUM HELLAS DAC» και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me itrum hellas",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» όπως μετονομάσθηκε η ανώνυμη εταιρεία με την επωνυμία «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, η οποία ενεργεί ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «PILLAR FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο “EUROBANK ERGASIAS” η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Eurobank",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, η οποία ενεργεί επ’ ονόματι και για λογαριασμό της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «EUROBANK», η οποία εδρεύει στην Αθήνα, οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα, ως καθολικής διαδόχου της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS Α.Ε.» λόγω διασπάσεως της τελευταίας με απόσχιση του κλάδου τραπεζικής δραστηριότητάς της και σύσταση της πρώτης τραπεζικής εταιρείας,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Cairo 1",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CAIRO No 1 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Cairo 3",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «CAIRO No 3 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Mexico ",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «MEXICO FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue me Mexico 2",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «MEXICO No 2 FINANCE DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue POSEIDON",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, στην οποία έχει ανατεθεί η διαχείριση των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «POSEIDON FINANCIAL INVESTOR DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας (Cape House, Westend Office Park, Snugborough Road, Blanchardstown, Δουβλίνο 15) και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue EAGLE",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «EAGLE ISSUER DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός Molesworth Street 32, Δουβλίνο 2 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue ERB",
                Perigrafh = "επιδώσω προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «ERB RECOVERY DAC», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας οδός George’s Dock αρ. 3, 4ος  όροφος, IFSC, Δουβλίνο 1 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ERGASIAS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», η οποία εδρεύει στην Αθήνα οδός Όθωνος αρ. 8 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Μοσχάτο",
                Name = "doValue FRONTIER",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «doValue Greece Ανώνυμη Εταιρεία Διαχείρισης Απαιτήσεων από Δάνεια και Πιστώσεις» και τον διακριτικό τίτλο «doValue Greece» πρώην «EUROBANK FPS ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EUROBANK FINANCIAL PLANNING SERVICES», η οποία εδρεύει στο Μοσχάτο Αττικής οδός Κύπρου αρ. 27 και Αρχιμήδους και εκπροσωπείται νόμιμα, ως μη δικαιούχος και μη υπόχρεος διάδικος και υπό την ιδιότητα της ως διαχειρίστριας των απαιτήσεων της αλλοδαπής εταιρείας ειδικού σκοπού με την επωνυμία «FRONTIER ISSUER DESIGNATED ACTIVITY COMPANY», η οποία εδρεύει στο Δουβλίνο Ιρλανδίας , οδός Fenian, 2ος όροφος Palmerston House, Δουβλίνο 2 και εκπροσωπείται νόμιμα και η οποία κατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.», η οποία εδρεύει στην Αθήνα οδός Αιόλου αρ. 86 και εκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα  της, στην οδό Κύπρου 27 και Αρχιμήδους, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο."
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "pqh Πελοποννησου",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία υπό ειδική εκκαθάριση με την επωνυμία «ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΠΕΛΟΠΟΝΝΗΣΟΥ ΣΥΝ. ΠΕ. – ΥΠΟ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ» που εδρεύει στην Κόρινθο, οδός Αδείμαντου αρ. 41 και εκπροσωπείται νόμιμα από τον Ειδικό Εκκαθαριστή αυτής ανώνυμη εταιρεία με την επωνυμία «PQH ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ, ΕΙΔΙΚΟΣ ΕΚΚΑΘΑΡΙΣΤΗΣ ΠΙΣΤΩΤΙΚΩΝ ΙΔΡΥΜΑΤΩΝ» και τον διακριτικό τίτλο «ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ Α.Ε.» με έδρα τον Δήμο Αμαρουσίου Αττικής, οδός Γραβιάς αρ. 3 και Γρανικού, όπως νόμιμα εκπροσωπείται",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Γραβιάς αρ. 3 και Γρανικού, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "pqh Αγροτική",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία υπό ειδική εκκαθάριση με την επωνυμία «ΑΓΡΟΤΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε. – ΥΠΟ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ» που εδρεύει στην Αθήνα, οδός Κατεχάκη αρ. 61Α και Βρανά και εκπροσωπείται νόμιμα από τον Ειδικό Εκκαθαριστή αυτής ανώνυμη εταιρεία με την επωνυμία «PQH ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ, ΕΙΔΙΚΟΣ ΕΚΚΑΘΑΡΙΣΤΗΣ ΠΙΣΤΩΤΙΚΩΝ ΙΔΡΥΜΑΤΩΝ» και τον διακριτικό τίτλο «ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ Α.Ε.» με έδρα τον Δήμο Αμαρουσίου Αττικής, οδός Γραβιάς αρ. 3 και Γρανικού, όπως νόμιμα εκπροσωπείται",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Γραβιάς αρ. 3 και Γρανικού, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "pqh fbb",
                Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «PQH ΕΝΙΑΙΑ\nΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ, ΕΙΔΙΚΟΣ ΕΚΚΑΘΑΡΙΣΤΗΣ\nΠΙΣΤΩΤΙΚΩΝ ΙΔΡΥΜΑΤΩΝ» και τον διακριτικό τίτλο «ΕΝΙΑΙΑ ΕΙΔΙΚΗ\nΕΚΚΑΘΑΡΙΣΗ Α.Ε.» με έδρα τον Δήμο Αμαρουσίου Αττικής, οδός Γραβιάς αρ. 3 και\nΓρανικού, όπως νόμιμα εκπροσωπείται, για λογαριασμό της εταιρείας με την επωνυμία\n«FBB ΠΡΩΤΗ ΕΠΙΧΕΙΡΗΜΑΤΙΚΗ ΤΡΑΠΕΖΑ υπό ειδική εκκαθάριση» και\nεκπροσωπείται νόμιμα,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Γραβιάς αρ. 3 και Γρανικού, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "pqh ΠΑΝΕΛΛΗΝΙΑ",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία υπό ειδική εκκαθάριση με την επωνυμία «ΠΑΝΕΛΛΗΝΙΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ ΥΠΟ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ» που εδρεύει στην Αθήνα, οδός Μεσογείων αρ. 290 και εκπροσωπείται νόμιμα από τον Ειδικό Εκκαθαριστή αυτής ανώνυμη εταιρεία με την επωνυμία «PQH ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ, ΕΙΔΙΚΟΣ ΕΚΚΑΘΑΡΙΣΤΗΣ ΠΙΣΤΩΤΙΚΩΝ ΙΔΡΥΜΑΤΩΝ» και τον διακριτικό τίτλο «ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ Α.Ε.» με έδρα τον Δήμο Αμαρουσίου Αττικής, οδός Γραβιάς αρ. 3 και Γρανικού, όπως νόμιμα εκπροσωπείται,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Γραβιάς αρ. 3 και Γρανικού, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στο Αμαρούσιο Αττικής",
                Name = "pqh ΑΤΕ ΛΗΖΙΝΓΚ",
                Perigrafh = "προς το αναγγελθέν υπό ειδική εκκαθάριση χρηματοδοτικό ίδρυμα με την επωνυμία «ΑΤΕ ΛΗΖΙΝΓΚ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΧΡΗΜΑΤΟΔΟΤΙΚΗΣ ΜΙΣΘΩΣΗΣ (ΥΠΟ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ)» που εδρεύει στην Αθήνα, οδός Κατεχάκη αρ. 61Α και Βρανά και εκπροσωπείται νόμιμα από τον Ειδικό Εκκαθαριστή αυτής ανώνυμη εταιρεία με την επωνυμία «PQH ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ, ΕΙΔΙΚΟΣ ΕΚΚΑΘΑΡΙΣΤΗΣ ΠΙΣΤΩΤΙΚΩΝ ΙΔΡΥΜΑΤΩΝ» και τον διακριτικό τίτλο «ΕΝΙΑΙΑ ΕΙΔΙΚΗ ΕΚΚΑΘΑΡΙΣΗ Α.Ε.» με έδρα τον Δήμο Αμαρουσίου Αττικής, οδός Γραβιάς αρ. 3 και Γρανικού, όπως νόμιμα εκπροσωπείται,",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Γραβιάς αρ. 3 και Γρανικού, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                ZoneB = true
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Ηλιούπολη Αττικής",
                Name = "EOS MATRIX",
                Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία  με την επωνυμία «EOS MATRIX GREECE ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «EOS MATRIX GREECE ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ Μ.Α.Ε.» η οποία εδρεύει στην Ηλιούπολη Αττικής επί της Λεωφ. Βουλιαγμένης αρ. 432Β και εκπροσωπείται νόμιμα, η οποία ενεργεί κατ’ εντολή και για λογαριασμό και ούσα νόμιμη αντιπρόσωπος της εταιρείας με την επωνυμία «EOS FINANCE GmbH» η οποία εδρεύει στο Αμβούργο Γερμανίας, οδός Steindamm αρ. 71 και εκπροσωπείται νόμιμα, ως καθολικής διαδόχου της εταιρείας με την επωνυμία “BARCLAYS BANK PLC” η οποία εδρεύει στο Λονδίνο οδός 1 Churchill Place και εκπροσωπείται νόμιμα",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφ. Βουλιαγμένης αρ. 423Β, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                
            });
            list.Add(new EkthesiEpidoshsModel
            {
                Location = "Στην Αθήνα",
                Name = "ΘΕΑ ΑΡΤΕΜΙΣ",
                Perigrafh = "προς την  ανώνυμη εταιρεία με την επωνυμία «ΘΕΑ\nΑΡΤΕΜΙΣ – ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ\nΚΑΙ ΠΙΣΤΩΣΕΙΣ» και τον διακριτικό τίτλο «ΤΗΕΑ ARTEMIS FINANCIAL\nSOLUTIONS A.E.D.A.D.P.», ως εκπροσωπείται νόμιμα, ενεργούσης εν προκειμένω επ’\nονόματι, για λογαριασμό και ως διαχειρίστρια απαιτήσεων της αλλοδαπής εταιρείας με την\nεπωνυμία «ARTEMIS SECURITISATION S.A.», με έδρα το Λουξεμβούργο, η οποία\nκατέστη ειδική διάδοχος της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ATTICA\nBANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο «ATTICA BANK»,\nως νόμιμα εκπροσωπείται",
                Praxh = true,
                FusikoProswpo = false,
                HasKleisimo = Kleisimo.exei,
                Signature = Signature.paralavon,
                Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Πλουτάρχου αρ. 11, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
                
            });

            return list;
        }

        public List<DebtorForSunexisi> GetDebtorsForSunexisi()
        {
            var list = new List<DebtorForSunexisi>();
            list.Add(new DebtorForSunexisi
            {
                Id = 1,
                Name = "Βρεττός Cepal Galaxy Alfa",
                Description = $"του Νικολάου  Βρεττού του Λαζάρου και της Κωνσταντίνας, κατοίκου Αθηνών, οδός Ηλείας αρ.5-7, με Α.Φ.Μ. 042326390 Δ.Ο.Υ. Δ' Αθηνών, ο οποίος ενεργεί στο παρόν ως πληρεξούσιος, αντιπρόσωπος, αντίκλητος και για λογαριασμό της μονοπρόσωπης ανώνυμης εταιρείας με την επωνυμία «CEPAL ΗΕLLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής επί της Λεωφόρου Συγγρού 209 - 211, με Α.Φ.Μ. 800715056  στην οποία έχει ανατεθεί η διαχείριση των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία GALAXY ΙΙ FUNDING DESIGNATED ACTIVITY COMPANY,με έδρα το Δουβλίνο Ιρλανδίας  στον οποίο Δικαιούχο της Απαίτησης,η Ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο ALΡΗΑ ΒΑΝΚ, όπως εκπροσωπείται νόμιμα, πρώην ΕΜΠΟΡΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ ΑΕ, έχει εκχωρήσει και μεταβιβάσει ληξιπρόθεσμες απαιτήσεις της από δάνεια και πιστώσεις, όπως νομίμως εκπροσωπείται"
            });
            list.Add(new DebtorForSunexisi
            {
                Id = 2,
                Name = "Βρεττός Cepal ORION ALFA",
                Description = $"του Νικολάου  Βρεττού του Λαζάρου και της Κωνσταντίνας, κατοίκου Αθηνών, οδός Ηλείας αρ.5-7, με Α.Φ.Μ. 042326390 Δ.Ο.Υ. Δ' Αθηνών, ο οποίος ενεργεί στο παρόν ως πληρεξούσιος, αντιπρόσωπος, αντίκλητος και για λογαριασμό της μονοπρόσωπης ανώνυμης εταιρείας με την επωνυμία «CEPAL ΗΕLLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ», που εδρεύει στη Νέα Σμύρνη Αττικής επί της Λεωφόρου Συγγρού 209-211, με Α.Φ.Μ. 800715056  στην οποία έχει ανατεθεί η διαχείριση των απαιτήσεων της εταιρείας ειδικού σκοπού με την επωνυμία ORION X SECURITISATION DESIGNATED ACTIVITY COMPANY, με έδρα το Δουβλίνο Ιρλανδίας  στον οποίο Δικαιούχο της Απαίτησης έχει μεταβιβάσει ληξιπρόθεσμες απαιτήσεις από δάνεια και πιστώσεις η Ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ» και τον διακριτικό τίτλο ALΡΗΑ ΒΑΝΚ που εδρέύει στην Αθήνα, όπως εκπροσωπείται νόμιμα"
            });
            list.Add(new DebtorForSunexisi
            {
                Id = 3,
                Name = "ΚΩΣΤΟΓΙΑΝΝΗ CEPAL SYMBOL ΕΘΝΙΚΗ",
                Description = $"της Ζωής Κωστόγιαννη του Ηλία και της Βασιλικής, δικηγόρου και κατοίκου Αθηνών, Λεωφόρος Μεσογείων αριθμός 109-111, με Α.Φ.Μ. 154566907, που ενεργεί ως πληρεξούσια, αντιπρόσωπος και αντίκλητος και για λογαριασμό της μονοπρόσωπης ανώνυμης εταιρείας με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε. ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφ. Συγγρού αρ.209-211 και εκπροσωπείται νόμιμα με Α.Φ.Μ. 800715056, ως διαχειρίστριας των απαιτήσεων της εταιρείας με την επωνυμία «SYMBOL INVESTMENT NPLCo DESIGNATED ACTIVITY COMPANY» που εδρεύει στο Δουβλίνο Ιρλανδίας και εκπροσωπείται νόμιμα, στην οποία μεταβιβάστηκαν οι απαιτήσεις της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.» που εδρεύει στην Αθήνα, οδός Αιόλου αρ. 86, με ΑΦΜ 094014201, όπως εκπροσωπείται νόμιμα"
            });
            list.Add(new DebtorForSunexisi
            {
                Id = 4,
                Name = "ΑΝΑΣΤΑΣΤΙΟΣ ΧΑΤΖΗΕΥΡΑΙΜΙΔΗΣ CEPAL GALAXY 2 ALFA",
                Description = $"της Ζωής Κωστόγιαννη του Ηλία και της Βασιλικής, δικηγόρου και κατοίκου Αθηνών, Λεωφόρος Μεσογείων αριθμός 109-111, με Α.Φ.Μ. 154566907, που ενεργεί ως πληρεξούσια, αντιπρόσωπος και αντίκλητος και για λογαριασμό της μονοπρόσωπης ανώνυμης εταιρείας με την επωνυμία «CEPAL HELLAS ΧΡΗΜΑΤΟΟΙΚΟΝΟΜΙΚΕΣ ΥΠΗΡΕΣΙΕΣ ΜΟΝΟΠΡΟΣΩΠΗ Α.Ε. ΔΙΑΧΕΙΡΙΣΗΣ ΑΠΑΙΤΗΣΕΩΝ ΑΠΟ ΔΑΝΕΙΑ ΚΑΙ ΠΙΣΤΩΣΕΙΣ» που εδρεύει στη Νέα Σμύρνη Αττικής, επί της Λεωφ. Συγγρού αρ.209-211 και εκπροσωπείται νόμιμα με Α.Φ.Μ. 800715056, ως διαχειρίστριας των απαιτήσεων της εταιρείας με την επωνυμία «SYMBOL INVESTMENT NPLCo DESIGNATED ACTIVITY COMPANY» που εδρεύει στο Δουβλίνο Ιρλανδίας και εκπροσωπείται νόμιμα, στην οποία μεταβιβάστηκαν οι απαιτήσεις της ανώνυμης τραπεζικής εταιρείας με την επωνυμία «ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.» που εδρεύει στην Αθήνα, οδός Αιόλου αρ. 86, με ΑΦΜ 094014201, όπως εκπροσωπείται νόμιμα"
            });


            return list;
        }

        //public List<EkthesiEpidoshsModelKatasxetiria> GetZipFilesForKatasxetiria()
        //{
        //    var list = new List<EkthesiEpidoshsModelKatasxetiria>();
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ",
        //        Perigrafh = "προς την ανώνυμη εταιρεία με την επωνυμία «ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ»",
        //        KeimenoEisagoghs = "που εδρεύει στην Χαλκίδα του Δήμου Χαλκιδέων Ευβοίας, οδός Βελισσαρίου αρ. 2, με Α.Φ.Μ. 096123566, που τέθηκε σε ειδική εκκαθάριση",
        //        Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Όθωνος αρ. 4, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.ΠΕ»",
        //        DiakritikosTitlos = "«ΕΥΒΟΙΚΗ ΠΙΣΤΗ»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "που εδρεύει στην Αθήνα Αττικής, οδός Σταδίου αρ. 40, με Α.Φ.Μ. 094014249",
        //        Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Πανεπιστημίου αρ. 43, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΑΛΦΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ»",
        //        DiakritikosTitlos = "«ALPHA BANK»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "που εδρεύει στην Αθήνα Αττικής, οδός Αμερικής αρ. 4, με Α.Φ.Μ. 094014298", //TODO ΑΠΟ ΚΑΤΩ Η ΔΙΕΥΘΥΝΣΗ ΜΑΛΛΟΝ ΕΙΝΑΙ ΛΑΘΟΣ ΚΑΘΩΣ ΠΑΜΕ ΣΤΗΝ ΑΛΕΞΑΝΔΡΑΣ
        //        Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην Λεωφόρο Αλεξάνδρας αρ. 170, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ»",
        //        DiakritikosTitlos = "«ΤΡΑΠΕΖΑ ΠΕΙΡΑΙΩΣ»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ", //TODO ΑΥΤΗ ΜΑΛΛΟΝ ΔΕΝ ΛΕΓΕΤΑΙ ΕΤΣΙ 
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Πανεπιστημίου αρ. 36, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΤΡΑΠΕΖΑ EUROBANK ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»",
        //        DiakritikosTitlos = "«EUROBANK ",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Μαυρομιχάλη αρ. 8, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ATTICA BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ»",
        //        DiakritikosTitlos = "«ATTICA BANK»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "HSBC Continental Europe Greece",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «HSBC Confidental Greece Europe ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ», που εδρεύει στην Γαλλία και διατηρεί υποκατάστημα στην Αθήνα, όπως εκπροσωπείται νόμιμα,",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα το νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της στην οδό Μεσογείων αρ. 109-111, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«HSBC Conntinental Greece Europe ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ»",
        //        DiakritikosTitlos = "«HSBC Confidental Greece Europe»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ ΣΥΝΕΤΑΙΡΙΣΜΟΣ ΠΕΡΙΟΡΙΣΜΕΝΗΣ ΕΥΘΥΝΗΣ",
        //        Perigrafh = "προς τον τραπεζικό συνεταιρισμό με την επωνυμία «ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ ΣΥΝΕΤΑΙΡΙΣΜΟΣ ΠΕΡΙΟΡΙΣΜΕΝΗΣ ΕΥΘΥΝΗΣ», που εδρεύει στα Χανία Κρήτης και διατηρεί υποκατάστημα στην Αθήνα, όπως εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "", //TODO ΠΟΙΑ ΕΙΝΑΙ Η ΔΙΕΥΘΥΝΣΗ??
        //        Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Σταδίου αρ. 40, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ ΣΥΝΕΤΑΙΡΙΣΜΟΣ ΠΕΡΙΟΡΙΣΜΕΝΗΣ ΕΥΘΥΝΗΣ»",
        //        DiakritikosTitlos = "«ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΧΑΝΙΩΝ»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΣΥΝ.ΠΕ.",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΣΥΝ.ΠΕ.», που εδρεύει στο Ηράκλειο Κρήτης και διατηρεί υποκατάστημα στην Αθήνα, όπως εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "",//TODO ΠΟΙΑ ΕΙΝΑΙ Η ΔΙΕΥΘΥΝΣΗ??
        //        Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της επί της οδού Όθωνος αρ. 4, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΣΥΝ.ΠΕ.»",
        //        DiakritikosTitlos = "«ΠΑΓΚΡΗΤΙΑ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε., που εδρεύει στην Αθήνα και εκπροσωπείται νόμιμα",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της στην οδό Αιόλου αρ. 86, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.»",
        //        DiakritikosTitlos = "«ΕΘΝΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ Α.Ε.»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στο Αμαρούσιο Αττικής",
        //        Name = "ΤΡΑΠΕΖΑ OPTIMA BANK",//TODO VIVA KAI OPTIMA EINAI B ZONH
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «ΤΡΑΠΕΖΑ OPTIMA BANK»",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην οδό Αιγιαλείας αρ. 32, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«ΤΡΑΠΕΖΑ OPTIMA BANK»",
        //        DiakritikosTitlos = "«ΤΡΑΠΕΖΑ OPTIMA BANK»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon,
        //        ZoneB = true
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στο Αμαρούσιο Αττικής",
        //        Name = "VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.",//TODO DEN EIMASTE SIGOUROI GIA THN EPONUMIA THS
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.»",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στην έδρα της, στην Λεωφόρο Καποδιστρίου αρ. 2, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.»",
        //        DiakritikosTitlos = "«VIVA ΥΠΗΡΕΣΙΕΣ ΠΛΗΡΩΜΩΝ Α.Ε.»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon,
        //        ZoneB = true
        //    });
        //    list.Add(new EkthesiEpidoshsModelKatasxetiria
        //    {
        //        Location = "Στην Αθήνα",
        //        Name = "UNICREDIT BANK A.G.",
        //        Perigrafh = "προς την ανώνυμη τραπεζική εταιρεία με την επωνυμία «UNICREDIT BANK A.G.»",
        //        KeimenoEisagoghs = "",
        //        Kleisimo = "Αφού δεν βρήκα τον νόμιμο εκπρόσωπο της άνω Εταιρίας στα γραφεία της, στην Ηρακλείτου αρ. 7, ούτε Διευθυντή ή συνεργάτη, αλλά τ… εξουσιοδοτημέν… για την παραλαβή υπάλληλο αυτής …………………….……………, όπως μου δήλωσε, επέδωσα σ΄ αυτ…. το άνω δικόγραφο.",
        //        FullName = "«UNICREDIT BANK A.G.»",
        //        DiakritikosTitlos = "«UNICREDIT BANK A.G.»",
        //        HasKleisimo = Kleisimo.exei,
        //        Signature = Signature.paralavon
        //    });
        //    return list;
        //}

        public List<PistotikaIdrymataUpoEkkatharisi> GetBanks()
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
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 2,
                Name = "PROTON ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "PROTON BANK",
                Edra = "που εδρεύει στην Αθήνα, οδός Κατεχάκη αρ.61Α και Βρανά ,",
                AFM = "με Α.Φ.Μ. 099877056"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 3,
                Name = "T BANK ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "T BANK",
                Edra = "που εδρεύει στην Αθήνα, οδός Βρανά αρ. 61,",
                AFM = "με Α.Φ.Μ. 094351776"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 4,
                Name = "ΑΧΑΙΚΗ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΑΝΩΝΥΜΗ ΕΠΕΝΔΥΤΙΚΗΣ ΔΙΑΜΕΣΟΛΑΒΗΣΗΣ",
                DiakritikosTitlos = "ΑΧΑΙΚΗ ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ Α.Ε.Ε.Δ.",
                Edra = "που εδρεύει στην Πάτρα, οδός Μιχαλακοπούλου αρ. 66,",
                AFM = "με Α.Φ.Μ. 099235674"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 5,
                Name = "ΑΓΡΟΤΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ ΑΕ",
                DiakritikosTitlos = "ΑΓΡΟΤΙΚΗ ΤΡΑΠΕΖΑ ΤΗΣ ΕΛΛΑΔΟΣ",
                Edra = "που εδρεύει στην Αθήνα, οδός Πανεπιστημίου αρ. 23,",
                AFM = "με Α.Φ.Μ. 094326270"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 6,
                Name = "ΤΑΧΥΔΡΟΜΙΚΟ ΤΑΜΙΕΥΤΗΡΙΟ ΕΛΛΑΔΟΣ ΑΝΩΝΥΜΗ ΤΡΑΠΕΖΙΚΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "ΤΑΧΥΔΡΟΜΙΚΟ ΤΑΜΙΕΥΤΗΡΙΟ",
                Edra = "που εδρεύει στην Αθήνα, οδός Κατεχάκη αρ. 61Α και Βρανά",
                AFM = "με Α.Φ.Μ. 090038000"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 7,
                Name = "FBB ΠΡΩΤΗ ΕΠΙΧΕΙΡΗΜΑΤΙΚΗ ΤΡΑΠΕΖΑΖ ΑΝΩΝΥΜΗ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "FBBank",
                Edra = "που εδρεύει Αθήνα, οδός Κατεχάκη  αρ. 61Α και Βρανα,",
                AFM = "με Α.Φ.Μ. 999931359"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 8,
                Name = "ΤΡΑΠΕΖΑ PROBANK Ανώνυμη Εταιρεία",
                DiakritikosTitlos = "PROBANK",
                Edra = "που εδρεύει στην Μοσχάτο Αττικής, οδός Πειραιώς αρ. 74,",
                AFM = "με Α.Φ.Μ. 099877019"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 9,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΩΔΕΚΑΝΗΣΟΥ ΣΥΝ.Π.Ε",
                DiakritikosTitlos = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΩΔΕΚΑΝΗΣΟΥ ΣΥΝ.Π.Ε",
                Edra = "που εδρεύει στην Ρόδο, οδός Καμείρου αρ. 76,",
                AFM = "με Α.Φ.Μ. 096237510"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 10,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΕΥΒΟΙΑΣ ΣΥΝ.Π.Ε",
                DiakritikosTitlos = "T BANK",
                Edra = "που εδρεύει στην Χαλκίδα του Δήμου Χαλκιδέων Ευβοίας, οδός Βελισσαρίου αρ. 2,",
                AFM = "με Α.Φ.Μ. 096123566"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 11,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΥΤΙΚΗΣ ΜΑΚΕΔΟΝΙΑΣ ΣΥΝ. Π.Ε.",
                DiakritikosTitlos = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΔΥΤΙΚΗΣ ΜΑΚΕΔΟΝΙΑΣ ΣΥΝ. Π.Ε.",
                Edra = "που εδρεύει στην Κοζάνη, οδός Ελ. Βενιζέλου αρ. 2,",
                AFM = "με Α.Φ.Μ. 096189647"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 12,
                Name = "ΠΑΝΕΛΛΗΝΙΑ ΤΡΑΠΕΖΑ ΑΝΩΝΥΜΟΣ ΕΤΑΙΡΕΙΑ",
                DiakritikosTitlos = "ΠΑΝΕΛΛΗΝΙΑ ΤΡΑΠΕΖΑ",
                Edra = "που εδρεύει στον Χολαργό Αττικής, Λεωφόρος Μεσογείων αρ. 290,",
                AFM = "με Α.Φ.Μ. 999984630"
            });
            list.Add(new PistotikaIdrymataUpoEkkatharisi
            {
                Id = 13,
                Name = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΠΕΛΟΠΟΝΝΗΣΟΥ ΣΥΝ Π.Ε",
                DiakritikosTitlos = "ΣΥΝΕΤΑΙΡΙΣΤΙΚΗ ΤΡΑΠΕΖΑ ΠΕΛΟΠΟΝΝΗΣΟΥ",
                Edra = "που εδρεύει στην Κόρινθο, οδός Αδειμάντου αρ. 41,",
                AFM = "με Α.Φ.Μ. 096158148"
            });
            return list;
        }
        }
    }
