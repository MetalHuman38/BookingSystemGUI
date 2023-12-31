using BookingSystem.Core;
using BookingSystem.MVVM.Model;
using BookingSystem.Repositories;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookingSystem.MVVM.ViewModel
{
    public class BookingViewModel : ObservableObject
    {
        private IUserBookingRepository userBookingRepository;

        private ObservableCollection<BookingModel> _bookings;

        public ObservableCollection<BookingModel> Bookings
        {
            get { return _bookings; }
            set
            {
                if (_bookings != value)
                {
                    _bookings = value;
                    OnPropertyChanged(nameof(Bookings));
                }
            }
        }

        public BookingViewModel(IUserBookingRepository userBookingRepository)
        {
            this.userBookingRepository = new UserBookingRepository();
            LoadBookings(); // Load bookings initially
            // Subscribe to events or perform any other setup logic here
        }

        public ICommand LoadBookingsCommand => new RelayCommand(LoadBookings);

        private void LoadBookings()
        {
            // Load bookings from the repository and update the ObservableCollection
            Bookings = new ObservableCollection<BookingModel>(userBookingRepository.GetAllBookings());
        }
    }
}

