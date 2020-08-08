using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridProductsEdition
{
    class Magazyny : ObservableCollection<string>
    {
        public Magazyny()
        {
            Add("Katowice 1");
            Add("Katowice 2");
            Add("Gliwice 1");
        }
    }
}
