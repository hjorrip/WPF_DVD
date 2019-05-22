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
    /// Interaction logic for ChangeDvdOwnerWindow.xaml
    /// </summary>
    public partial class ChangeDvdOwnerWindow : Window
    {
        DvdOwner temp;

        public ChangeDvdOwnerWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            temp = new DvdOwner();

            temp.FirstName = SharedContext.selectedDvdOwner.FirstName;
            temp.LastName = SharedContext.selectedDvdOwner.LastName;
            temp.Email = SharedContext.selectedDvdOwner.Email;

            this.DataContext = temp;

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SharedContext.selectedDvdOwner.FirstName = temp.FirstName;
            SharedContext.selectedDvdOwner.LastName = temp.LastName;
            SharedContext.selectedDvdOwner.Email = temp.Email;

            this.Close();
        }
    }
}
