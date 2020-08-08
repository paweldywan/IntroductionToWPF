using System.ComponentModel;
using System.Runtime.Remoting;
using System.Text.RegularExpressions;

namespace Regexp
{
    class Osoba : IDataErrorInfo
    {
        public string Nazwisko { get; set; }
        public string Imiona { get; set; }
        public string Pesel { get; set; }
        public string KodPocztowy { get; set; }

        public string Error => throw new System.NotImplementedException();

        public string this[string nazwaWlasciwosciOsoby]
        {
            get
            {
                string komunikat = string.Empty;

                switch (nazwaWlasciwosciOsoby)
                {
                    case "Nazwisko":
                        if (string.IsNullOrEmpty(Nazwisko))
                            komunikat = "Nazwisko musi być wpisane!";
                        else if (!Regex.IsMatch(Nazwisko, @"^\p{Lu}\p{Ll}+((\s|-)\p{Lu}\p{Ll}+){0,2}$"))
                            komunikat = "Nazwisko z dużej litery, minimum 2 znaki i maksymalnie trójczłonowe!";
                        break;
                    case "Imiona":
                        if (string.IsNullOrEmpty(Imiona))
                            komunikat = "Należy wpisać imię lub imiona!";
                        else if (!Regex.IsMatch(Imiona, @"^\p{Lu}\p{Ll}+(\s\p{Lu}\p{Ll}+)*$"))
                            komunikat = "Imiona z dużej litery i minimum 2 znaki";
                        break;
                    case "Pesel":
                        if (string.IsNullOrEmpty(Pesel))
                            komunikat = "Pesel musi być wpisany!";
                        else if (!Regex.IsMatch(Pesel, @"^\d{11}$"))
                            komunikat = "Numer PESEL musi miec 11 znaków";
                        break;
                    case "KodPocztowy":
                        if (string.IsNullOrEmpty(KodPocztowy))
                            komunikat = "Kod pocztowy musi być wpisany!";
                        else if (!Regex.IsMatch(KodPocztowy, @"^\d{2}-\d{3}$"))
                            komunikat = "Kod pocztowy ma mieć format 99-999";
                        break;
                }

                return komunikat;
            }
        }
    }
}
