using BookingSystem.MVVM.ViewModel;
using System.Windows;

namespace BookingSystem.MVVM.View
{
    /// <summary>
    /// Interaction logic for Accommodations.xaml
    /// </summary>
    public partial class Accommodations : Window
    {
        public Accommodations()
        {
            InitializeComponent();
            DataContext = new AccommodationViewModel();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
