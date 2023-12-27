using BookingSystem.Core;
using BookingSystem.MVVM.View;
using System.Windows.Input;

namespace BookingSystem.MVVM.ViewModel
{

    public class StartBookingPageViewModel : ObservableObject
    {
        private bool _isUserSignedIn;

        private AccommodationViewModel accommodationViewModel;

        public ICommand AccommodationsCommand { get; }

        public bool IsUserSignedIn
        {
            get { return _isUserSignedIn; }
            set
            {
                _isUserSignedIn = value;
                OnPropertyChanged(nameof(IsUserSignedIn));
            }
        }

        public StartBookingPageViewModel()
        {
            AccommodationsCommand = new RelayCommand(ExecuteAccommodationsCommand);

        }

        private void ExecuteAccommodationsCommand(object obj)
        {
            // Open the StartBookingPage.xaml window
            Accommodations accommodations = new Accommodations();
            accommodations.Show();
        }
    }
}
