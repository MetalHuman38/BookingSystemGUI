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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            // Register your types and dependencies here
        }

    }

}
