using BookingSystem.Core;
using BookingSystem.MVVM.Model;
using BookingSystem.Repositories;
using System.Windows.Input;

namespace BookingSystem.MVVM.ViewModel
{
    public class AddBookingViewModel : ObservableObject
    {


        private string _guestName;
        private int _bookingId;
        private string _accommodationType;
        private DateTime _bookingDate;
        private int _numbersofNights;
        private double _totalPrice;



        private IUserBookingRepository userBookingRepository;

        public int BookingId
        {
            get { return _bookingId; }
            set
            {
                if (_bookingId != value)
                {
                    _bookingId = value;
                    OnPropertyChanged(nameof(BookingId));
                }
            }
        }
        public string GuestName
        {
            get { return _guestName; }
            set
            {
                if (_guestName != value)
                {
                    _guestName = value;
                    OnPropertyChanged(nameof(GuestName));
                }
            }
        }

        public string AccommodationType
        {
            get { return _accommodationType; }
            set
            {
                if (_accommodationType != value)
                {
                    _accommodationType = value;
                    OnPropertyChanged(nameof(AccommodationType));
                }
            }
        }

        public DateTime BookingDate
        {
            get { return _bookingDate; }
            set
            {
                if (_bookingDate != value)
                {
                    _bookingDate = value;
                    OnPropertyChanged(nameof(BookingDate));
                }
            }
        }

        public int NumberOfNights
        {
            get { return _numbersofNights; }
            set
            {
                if (_numbersofNights != value)
                {
                    _numbersofNights = value;
                    OnPropertyChanged(nameof(NumberOfNights));
                }
            }
        }

        public double TotalPrice
        {
            get { return _totalPrice; }
            set
            {
                if (_totalPrice != value)
                {
                    _totalPrice = value;
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }
        }




        public AddBookingViewModel()
        {
            userBookingRepository = new UserBookingRepository();
            SubmitCommand = new RelayCommand(ExecuteSubmitCommand);
            CancelCommand = new RelayCommand(ExecuteCancelCommand);
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        private void ExecuteSubmitCommand(object parameter)
        {
            // Ensure that the parameter is of the correct type (string in this case)
            string? guestName = parameter as string;
            if (!string.IsNullOrEmpty(guestName))
            {
                // Create a new BookingModel instance with all the properties
                BookingModel newBooking = new BookingModel
                {
                    BookingId = BookingId,
                    GuestName = guestName,
                    AccommodationType = AccommodationType,
                    BookingDate = BookingDate,
                    NumberOfNights = NumberOfNights,
                    TotalPrice = TotalPrice
                    // Add other properties as needed
                };

                // Perform any necessary actions with the entered data
                userBookingRepository.AddBooking(newBooking);
            }
            else
            {
                // Display an error or take appropriate action
            }
        }

        private void ExecuteCancelCommand(object parameter)
        {
            // Handle the cancel logic here
            // For example, you might close the window or navigate to another page
        }
    }
}
