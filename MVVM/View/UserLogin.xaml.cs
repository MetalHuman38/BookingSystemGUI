using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace BookingSystem.MVVM.View
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {

        public UserLogin()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void PackIcon_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void PackIcon_WindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Handle the WindowMinimize click event here
            // You can perform actions such as minimizing the window
            WindowState = WindowState.Minimized;
        }

        private void PackIcon_CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            // Handle the CloseWindow click event here
            // You can perform actions such as closing the window
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
