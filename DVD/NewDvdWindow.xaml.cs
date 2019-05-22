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
using System.Windows.Shapes;

namespace DVD
{
    /// <summary>
    /// Interaction logic for NewDvdWindow.xaml
    /// </summary>
    public partial class NewDvdWindow : Window
    {

        Dvd d;

        public NewDvdWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            d = new Dvd();
            this.DataContext = d;
            lbAllGenres.DataContext = SharedContext.Genres;
            txtSelectedDvdOwner.DataContext = SharedContext.selectedDvdOwner;
        }

        private void lbAllGenres_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBox listb = sender as ListBox;

            Genre g = (Genre)listb.SelectedItem;

            d.Genres.Add(g);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.selectedDvdOwner.Dvds.Add(d);
            this.Close();


        }
    }
}
