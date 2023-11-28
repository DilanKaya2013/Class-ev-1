using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ev_1
{
    internal class Emlak
    {
      
        double fiyat;
        string site;
        int binaYasi;
        string isitma;
        string binaKat;
        string ilce;
        string asonsor;
        string yanginCikis;
        string otopark;
        int   bulunduguKat;
        bool esyali;
        string metrekare;
        int odaSayisi;
        string ilanTarihi;
        int banyoSayisi;
        string emlakTuru;
        string balkon;
        string bahce;
        string teras;
        string manzara;
        string semt;
        string evturu;



        public double Fiyat { get => fiyat; set => fiyat = value; }
        public string Site { get => site; set => site = value; }
        public int BinaYasi { get => binaYasi; set => binaYasi = value; }
        public string Isitma { get => isitma; set => isitma = value; }
        public string BinaKat { get => binaKat; set => binaKat = value; }
        public string Ilce { get => ilce; set => ilce = value; }
        public string Asonsor { get => asonsor; set => asonsor = value; }
        public string YanginCikis { get => yanginCikis; set => yanginCikis = value; }
        public string Otopark { get => otopark; set => otopark = value; }
        public int BulunduguKat { get => bulunduguKat; set => bulunduguKat = value; }
        public bool Esyali { get => esyali; set => esyali = value; }
        public string Metrekare { get => metrekare; set => metrekare = value; }
        public int OdaSayisi { get => odaSayisi; set => odaSayisi = value; }
        public string IlanTarihi { get => ilanTarihi; set => ilanTarihi = value; }
        public int BanyoSayisi { get => banyoSayisi; set => banyoSayisi = value; }
        public string EmlakTuru { get => emlakTuru; set => emlakTuru = value; }
        public string Balkon { get => balkon; set => balkon = value; }
        public string Bahce { get => bahce; set => bahce = value; }
        public string Teras { get => teras; set => teras = value; }
        public string Manzara { get => manzara; set => manzara = value; }
        public string Semt { get => semt; set => semt = value; }
        public string Evturu { get => evturu; set => evturu = value; }

        public Emlak(double fiyat, string site, int binaYasi, string isitma, string binaKat, string ilce, string asonsor, string yanginCikis, string otopark, int bulunduguKat, bool esyali, string metrekare, int odaSayisi, string ilanTarihi, int banyoSayisi, string emlakTuru, string balkon, string bahce, string teras, string manzara, string semt, string evturu)
        {
            this.fiyat = fiyat;
            this.site = site;
            this.binaYasi = binaYasi;
            this.isitma = isitma;
            this.binaKat = binaKat;
            this.ilce = ilce;
            this.asonsor = asonsor;
            this.yanginCikis = yanginCikis;
            this.otopark = otopark;
            this.bulunduguKat = bulunduguKat;
            this.esyali = esyali;
            this.metrekare = metrekare;
            this.odaSayisi = odaSayisi;
            this.ilanTarihi = ilanTarihi;
            this.banyoSayisi = banyoSayisi;
            this.emlakTuru = emlakTuru;
            this.balkon = balkon;
            this.bahce = bahce;
            this.teras = teras;
            this.manzara = manzara;
            this.semt = semt;
            this.evturu = evturu;
        }
    }
}
