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
    /// Interaction logic for NewDvdOwnerWindow.xaml
    /// </summary>
    public partial class NewDvdOwnerWindow : Window
    {

        DvdOwner d;

        public NewDvdOwnerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            d = new DvdOwner();
            this.DataContext = d;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.DvdOwners.Add(d);
            this.Close();
        }
    }
}
