using DVD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DVD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Seed();

            CollectionViewSource view = new CollectionViewSource();
            view.Source = SharedContext.DvdOwners;
            this.DataContext = view;

        }

        private void Seed()
        {

            Genre g1 = new Genre()
            {
                Name = "Fjölskyldu"
            };

            Genre g2 = new Genre()
            {
                Name = "Hasar"
            };

            Genre g3 = new Genre()
            {
                Name = "Hryllings"
            };

            Genre g4 = new Genre()
            {
                Name = "Grín"
            };

            Genre g5 = new Genre()
            {
                Name = "Drama"
            };

            Dvd d1 = new Dvd() {
                Title = "Rush hour",
                Released = new DateTime(2004, 10, 08)
            };

            Dvd d2 = new Dvd()
            {
                Title = "Titanic",
                Released = new DateTime(2001, 1, 08)
            };

            Dvd d3 = new Dvd()
            {
                Title = "Taxi driver",
                Released = new DateTime(1981, 5, 15)
            };

            d1.Genres.Add(g1);
            d1.Genres.Add(g2);
            d1.Genres.Add(g3);

            d2.Genres.Add(g5);

            d3.Genres.Add(g5);



            DvdOwner dow1 = new DvdOwner
                {
                    FirstName = "Baldur",
                    LastName = "Pétursson",
                    Email = "baldur@simnet.is",
                };

            DvdOwner dow2 = new DvdOwner
                {
                    FirstName = "Ólöf",
                    LastName = "Guðbrandsdóttir",
                    Email = "olla@net.is"
                };

            DvdOwner dow3 = new DvdOwner
            {
                FirstName = "Sigurrós",
                LastName = "Bolladóttir",
                Email = "sigga@gmail.is",
                
            };

            dow1.Dvds.Add(d1);
            dow1.Dvds.Add(d2);

            dow2.Dvds.Add(d2);
            dow2.Dvds.Add(d3);

            dow3.Dvds.Add(d3);


            SharedContext.Genres.Add(g1);
            SharedContext.Genres.Add(g2);
            SharedContext.Genres.Add(g3);
            SharedContext.Genres.Add(g4);
            SharedContext.Genres.Add(g5);

            SharedContext.DvdOwners.Add(dow1);
            SharedContext.DvdOwners.Add(dow2);
            SharedContext.DvdOwners.Add(dow3);


        }

        private void menu_QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu_NewOwnerClick(object sender, RoutedEventArgs e)
        {
            NewDvdOwnerWindow win = new NewDvdOwnerWindow();
            win.ShowDialog();
        }

        private void menu_NewDvdClick(object sender, RoutedEventArgs e)
        {
            NewDvdWindow win = new NewDvdWindow();
            win.ShowDialog();
        }

        private void menu_ChangeOwnerClick(object sender, RoutedEventArgs e)
        {
            ChangeDvdOwnerWindow win = new ChangeDvdOwnerWindow();
            win.ShowDialog();
        }

        private void cbDvdOwners_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SharedContext.selectedDvdOwner = (DvdOwner)cbDvdOwners.SelectedItem;
        }
    }
}
