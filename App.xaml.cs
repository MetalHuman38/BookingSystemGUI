using BookingSystem.MVVM.View;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;


namespace BookingSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {

        // Implement CreateShell method
        protected override Window CreateShell()
        {
            return Container.Resolve<UserLogin>();

        }

        // Common logic for handling view startup
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            UserLogin loginView = new UserLogin();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    var mainView = new MainWindow();
                    mainView.Show();
                    loginView.Close();
                }
            };
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register your types and dependencies here
            containerRegistry.RegisterForNavigation<UserLogin>();
            containerRegistry.RegisterForNavigation<StartBookingPage>();
            containerRegistry.RegisterForNavigation<MainWindow>();
        }

    }

}
