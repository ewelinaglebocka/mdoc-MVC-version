namespace mdoc.DataBase.Models.Dokumentacja_wykonawcza
{
    public class dokumenty
    {
        public int ID { get; set; }
        public string grupa_dokumentu { get; set; }
        public string nazwa_dokumentu { get; set; }
        public string link_dokumentu { get; set; }
        public string typ_dokumentu { get; set; }
        public string status_dokumentu { get; set; }
        public string data_dodania { get; set; }
        public string wydzial { get; set; }
        public string aktywny { get; set; }
        public string data_wydania { get; set; }
        public string osoba_wydająca { get; set; }
        public string osoba_dodajaca { get; set; }
        public string nazwa_pliku_local { get; set; }
        public DateTime data_wygaszenia { get; set; }
        public string uwagi { get; set; }
        public string nr_dokumentu { get; set; }
        public string wersja { get; set; }
        public string stanowiska_dostepne { get; set; }
        public string stanowiska_wydane { get; set; }
        public string kopia_robocza { get; set; }
        public string wygas_iD { get; set; }
        public string link_dokumentu_ikea { get; set; }
        public string data_porownania { get; set; }
        public string status_porownania { get; set; }

    }
}
