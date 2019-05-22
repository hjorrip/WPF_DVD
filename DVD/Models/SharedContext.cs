using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD.Models
{
    class SharedContext
    {
        public static ObservableCollection<DvdOwner> DvdOwners = new ObservableCollection<DvdOwner>();

        public static ObservableCollection<Genre> Genres = new ObservableCollection<Genre>();

        public static DvdOwner selectedDvdOwner = new DvdOwner();

    }
}
