using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD.Models
{
    class DvdOwner : INotifyPropertyChanged
    {

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {   _firstName = value;
                NotifyPropertyChanged("FullName");
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {   _lastName = value;
                NotifyPropertyChanged("FullName");
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                NotifyPropertyChanged("Email");
            }
        }
        public ObservableCollection<Dvd> Dvds { get; set; }

        public DvdOwner()
        {
            Dvds = new ObservableCollection<Dvd>();
        }


        private void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
