using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataGridProductsEdition
{
    class Produkt : IDataErrorInfo
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public string Magazyn { get; set; }

        public string Error
        {
            get
            {
                string komunikat = string.Empty;

                if (Symbol.Substring(0, 1) == "A" && LiczbaSztuk < 10) //Lepiej StartsWith
                {
                    komunikat = "Wymagana liczba produktów o symbolu A to min. 10";
                }

                return komunikat;
            }
        }

        public string this[string nazwaWlasciwosciProduktu]
        {
            get
            {
                string komunikat = string.Empty;

                switch (nazwaWlasciwosciProduktu)
                {
                    case nameof(Symbol):
                        if (string.IsNullOrEmpty(Symbol))
                            komunikat = "Symbol musi być wpisany!";
                        else if (!Regex.IsMatch(Symbol, @"^[A-Z][A-Z0-9]-[0-9]{2}$"))
                            komunikat = "Symbol ma mieć format XX-99 lub X9-99 (X-litera, 9-cyfra)";
                        break;
                    case nameof(LiczbaSztuk):
                        if(LiczbaSztuk < 0 || LiczbaSztuk > 10000)//if (!Regex.IsMatch(LiczbaSztuk.ToString(), "^[0-9]{1,4}0?$"))
                            komunikat = "Liczba sztuk ma być z zakresu <0,10000>";
                        break;
                }

                return komunikat;
            }
        }

        public Produkt(string sym, string naz, int lszt, string mag)
        {
            Symbol = sym;
            Nazwa = naz;
            LiczbaSztuk = lszt;
            Magazyn = mag;
        }

        public Produkt()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Symbol, Nazwa, LiczbaSztuk, Magazyn);
        }
    }
}
