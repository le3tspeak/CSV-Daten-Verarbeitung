using System.Text;
using System.Globalization;

namespace Aufgabe_15._5;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // StartUp Methode
        StartUp();
    }

    class Kunden
    {
        public string Anrede
        {
            get; set;
        }
        public string Vorname
        {
            get; set;
        }
        public string Nachname
        {
            get; set;
        }
        public DateTime? Geburtsdatum
        {
            get; set;
        }
        public string Stadt
        {
            get; set;
        }
        public string EMail
        {
            get; set;
        }
        public string Newsletter
        {
            get; set;
        }
    }

    // Startup
    void StartUp()
    {
        NewsletterAbos(customers);
        DisplayGenderPercentage(customers);
        DisplayMostCommonEmailProvider(customers);
        DisplayCustomersByAgeGroup(customers);
        FillComboBox(customers);
        AlleKundenMitGebdat(customers);
    }

    // CSV-Datei einlesen
    readonly List<Kunden> customers = ReadCustomersFromCSV("Daten.csv");

    // CSV Datei Spliten in Datens�tze
    static List<Kunden> ReadCustomersFromCSV(string filePath)
    {
        List<Kunden> customers = new List<Kunden>();

        using (var reader = new StreamReader(filePath, Encoding.UTF7))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                Kunden customer = new Kunden();
                customer.Anrede = values[1];
                customer.Vorname = values[3];
                customer.Nachname = values[4];
                DateTime birthdate;
                if (DateTime.TryParse(values[5], out birthdate))
                {
                    customer.Geburtsdatum = birthdate;
                }
                customer.Stadt = values[9];
                customer.EMail = values[12];
                customer.Newsletter = values[13];

                customers.Add(customer);
            }
        }
        return customers;
    }

    // Methoden zur Auswertung der Daten
    // Anzahl der Newsletter-Abonnenten
    void NewsletterAbos(List<Kunden> customers)
    {
        lblNewsletter.Text = $"Anzahl der Newsletter-Abonnenten: {customers.Count(c => c.Newsletter.Equals("ja", StringComparison.OrdinalIgnoreCase))}";
    }

    // Prozentuale Verteilung der Geschlechter
    void DisplayGenderPercentage(List<Kunden> customers)
    {
        var totalCustomers = customers.Count;
        // Anzahl der Kunden mit Anrede "Herr"
        var maleCount = customers.Count(c => c.Anrede.Equals("Herr", StringComparison.OrdinalIgnoreCase));
        // Anzahl der Kunden mit Anrede "Frau"
        var femaleCount = customers.Count(c => c.Anrede.Equals("Frau", StringComparison.OrdinalIgnoreCase));
        // Anzahl der Kunden mit unbekannter Anrede 
        var unknownGenderCount = totalCustomers - maleCount - femaleCount;
        // Berechnung der prozentualen Verteilung
        var malePercentage = (float)maleCount / totalCustomers * 100;
        var femalePercentage = (float)femaleCount / totalCustomers * 100;
        lblM�nnlich.Text = $"M�nnlich: {malePercentage:F2}%";
        lblWeiblich.Text = $"Weiblich: {femalePercentage:F2}%";
        lblUnbekannt.Text = $"Unbekannt: {100 - malePercentage - femalePercentage:F2}%";
    }

    // H�ufigster Email-Provider
    void DisplayMostCommonEmailProvider(List<Kunden> customers)
    {

        // Finde den Email Provider mit den meisten Vorkommen in der Klasse Kunden.Email
        var mostCommonEmailProvider = customers.Where(c => !string.IsNullOrEmpty(c.EMail))
                                                .Select(c => c.EMail.Split('@').Last())
                                                .GroupBy(emailProvider => emailProvider)
                                                .OrderByDescending(group => group.Count())
                                                .First()
                                                .Key;

        // Anzeige des h�ufigsten Email-Providers im Label
        lblEmailProvider.Text = $"H�ufigster Email-Provider: {mostCommonEmailProvider}";
    }

    //Kunden nach Altersgruppen anzeigen
    void DisplayCustomersByAgeGroup(List<Kunden> customers)
    {
        var now = DateTime.Today;
        var ageGroups = customers.Where(c => c.Geburtsdatum.HasValue)
                                 .Select(c => (now - c.Geburtsdatum.Value).Days / 365)
                                 .GroupBy(age => age < 18 ? "Unter 18" : (age < 30 ? "18-29" : (age < 40 ? "30-39" : (age < 50 ? "40-49" : "�ber 50"))));

        // Ausgabe der Altergruppen in Labels
        foreach (var group in ageGroups)
        {
            switch (group.Key)
            {
                case "Unter 18":
                    lblUnter18.Text = $"Unter 18: {group.Count()}";
                    break;
                case "18-29":
                    lbl18bis29.Text = $"18 - 29: {group.Count()}";
                    break;
                case "30-39":
                    lbl30bis39.Text = $"30 - 39: {group.Count()}";
                    break;
                case "40-49":
                    lbl40bis49.Text = $"40 - 49: {group.Count()}";
                    break;
                case "�ber 50":
                    lbl�ber50.Text = $"�ber 50: {group.Count()}";
                    break;
            }
        }
    }

    // F�lle ComboBox mit St�dten aus der CSV-Datei
    private void FillComboBox(List<Kunden> customers)
    {
        var stadt = customers.Select(c => c.Stadt).Distinct().ToList();
        cbCity.DisplayMember = "Stadt ausw�hlen:";
        cbCity.DataSource = stadt;
        cbCity.SelectedIndex = 0;
        cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    // Suche nach Stadt und Anzeige der Kunden in DataGridView nach �ndern der Stadt in ComboBox
    private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Suche Kunden nach ausgew�hlter Stadt in ComboBox und Zeige 50 Kunden an bei mehr als 50 soll man bl�ttern k�nnen
        var selectedCity = cbCity.SelectedItem.ToString();
        var customersInCity = customers.Where(c => c.Stadt.Equals(selectedCity, StringComparison.OrdinalIgnoreCase)).Take(50).ToList();
        // Geburtsdatum in Jahre umwandeln bei keinem Geburtsdatum auf "Keine Angabe" setzen und in neuer Liste speichern
        var customersInCityWithAge = customersInCity.Select(c => new
        {
            Anrede = c.Anrede,
            Vorname = c.Vorname,
            Nachname = c.Nachname,
            Geburtsdatum = c.Geburtsdatum.HasValue ? (c.Geburtsdatum.Value.ToShortDateString()) : "Keine Angabe",
            Alter = c.Geburtsdatum.HasValue ? (DateTime.Now.Year - c.Geburtsdatum.Value.Year).ToString() : "Keine Angabe",
            Stadt = c.Stadt,
            EMail = c.EMail,
            Newsletter = c.Newsletter
        }).ToList();

        // Anzeige der Kunden in DataGridView
        dgvCustomers.DataSource = customersInCityWithAge;
    }

    void AlleKundenMitGebdat(List<Kunden> customers)
    {
        // Filtere Kunden mit Geburtsdatum und erstelle eine neue Liste mit den Kunden
        var customersWithAge = customers.Where(c => c.Geburtsdatum.HasValue).ToList();
        var customersWithAgeList = customersWithAge.Select((c, index) => new
        {
            Nummer = index + 1,
            Anrede = c.Anrede,
            Vorname = c.Vorname,
            Nachname = c.Nachname,
            Geburtsdatum = c.Geburtsdatum.Value.ToShortDateString(),
            Alter = c.Geburtsdatum.HasValue ? (DateTime.Now.Year - c.Geburtsdatum.Value.Year).ToString() : "0",
            Stadt = c.Stadt,
            EMail = c.EMail,
            Newsletter = c.Newsletter
        }).ToList();

        const int pageSize = 50;
        var currentPage = 0;

        // Funktion zur Aktualisierung der DataGridView basierend auf der aktuellen Seite
        Action<int> UpdateDataGridView = (page) =>
        {
            dataGridView1.DataSource = customersWithAgeList.Skip(page * pageSize).Take(pageSize).ToList();
            // Erstelle Label zur Anzeige der aktuellen Seite
            labelPageNumber.Text = $"Seite {page + 1}/{Math.Ceiling((double)customersWithAgeList.Count / pageSize)}";
        };

        // Initialisierung der DataGridView
        UpdateDataGridView(currentPage);

        if (customersWithAgeList.Count > pageSize)
        {
            // Button zum Vorbl�ttern
            Button previousButton = new Button();
            previousButton.Text = "Vorherige Seite";
            previousButton.Location = new Point(200, 0);
            previousButton.Size = new Size(150, 25);
            previousButton.FlatStyle = FlatStyle.System;
            previousButton.Click += (sender, e) =>
            {
                if (currentPage > 0)
                {
                    currentPage--;
                    UpdateDataGridView(currentPage);
                }
            };
            panel1.Controls.Add(previousButton);

            // Button zum Zur�ckbl�ttern
            Button nextButton = new Button();
            nextButton.Text = "N�chste Seite";
            nextButton.Location = new Point(350, 0);
            nextButton.Size = new Size(150, 25);
            nextButton.FlatStyle = FlatStyle.System;
            nextButton.Click += (sender, e) =>
            {
                if (currentPage < Math.Ceiling((double)customersWithAgeList.Count / pageSize) - 1)
                {
                    currentPage++;
                    UpdateDataGridView(currentPage);
                }
            };
            panel1.Controls.Add(nextButton);
        }
    }
}
