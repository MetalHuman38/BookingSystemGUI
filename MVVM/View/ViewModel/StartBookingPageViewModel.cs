using BookingSystem.Core;

namespace BookingSystem.MVVM.ViewModel
{
    public class StartBookingPageViewModel : ObservableObject
    {
        private bool _isUserSignedIn;

        public bool IsUserSignedIn
        {
            get { return _isUserSignedIn; }
            set
            {
                _isUserSignedIn = value;
                OnPropertyChanged(nameof(IsUserSignedIn));
            }
        }


    }
}
