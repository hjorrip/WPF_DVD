using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD.Models
{
    class Dvd
    {
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public ObservableCollection<Genre> Genres { get; set; }

        public Dvd()
        {
            Released = DateTime.Now;
            Genres = new ObservableCollection<Genre>();
        }
    }
}
