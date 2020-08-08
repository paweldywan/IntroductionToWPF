using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;

namespace StudentsMVVM
{
    class StudentViewModel : INotifyPropertyChanged
    {
        private Student _student;

        public Student Kursant
        {
            get { return _student; }
            set 
            { 
                _student = value;
                OnPropertyChanged("Kursant");
            }
        }

        public MyCommand Wyczysc { get; set; }

        public StudentViewModel()
        {
            Kursant = new Student { Imie = "Jan", Nazwisko = "Kowalski", RokPrzyjeciaNaStudia = 2014 };
            Wyczysc = new MyCommand(WyczyscDane);
        }

        private void WyczyscDane()
        {
            if(MessageBox.Show("Czy wyczyścić dane studenta?", "Pytanie", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Kursant.Imie = string.Empty;
                Kursant.Nazwisko = string.Empty;
                Kursant.RokPrzyjeciaNaStudia = DateTime.Now.Year;
            }
        }

        //Implementacja interfejsu INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
