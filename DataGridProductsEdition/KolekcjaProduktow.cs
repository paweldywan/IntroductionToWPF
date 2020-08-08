using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridProductsEdition
{
    class KolekcjaProduktow : ObservableCollection<Produkt>
    {
        public KolekcjaProduktow()
        {
            Add(new Produkt
            {
                Symbol = "01-11",
                Nazwa = "ołówek",
                LiczbaSztuk = 8,
                Magazyn = "Katowice 1"
            });

            Add(new Produkt
            {
                Symbol = "PW-20",
                Nazwa = "pióro wieczne",
                LiczbaSztuk = 75,
                Magazyn = "Katowice 2"
            });

            Add(new Produkt
            {
                Symbol = "DZ-10",
                Nazwa = "długopis żelowy",
                LiczbaSztuk = 1121,
                Magazyn = "Katowice 1"
            });

            Add(new Produkt
            {
                Symbol = "DZ-12",
                Nazwa = "długopis kulkowy",
                LiczbaSztuk = 280,
                Magazyn = "Katowice 2"
            });
        }
    }
}
