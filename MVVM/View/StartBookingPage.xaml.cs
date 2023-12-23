using BookingSystem.MVVM.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace BookingSystem.MVVM.View
{
    /// <summary>
    /// Interaction logic for StartBookingPage.xaml
    /// </summary>
    public partial class StartBookingPage : Window
    {
        public StartBookingPage()
        {
            InitializeComponent();
            DataContext = new StartBookingPageViewModel();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
