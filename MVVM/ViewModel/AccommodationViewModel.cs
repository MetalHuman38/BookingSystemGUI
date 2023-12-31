using BookingSystem.BookingSystemClasses;
using BookingSystem.Core;
using BookingSystem.MVVM.Model;
using BookingSystem.MVVM.View;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace BookingSystem.MVVM.ViewModel
{


    public class AccommodationViewModel : ObservableObject
    {
        public ObservableCollection<IAccommodation> Accommodations { get; }

        public ObservableCollection<IAccommodation> HouseAccommodations
        {
            get { return new ObservableCollection<IAccommodation>(Accommodations.OfType<House>()); }
        }

        public ObservableCollection<IAccommodation> FlatAccommodations
        {
            get { return new ObservableCollection<IAccommodation>(Accommodations.OfType<Flat>()); }
        }

        public ObservableCollection<IAccommodation> HotelAccommodations
        {
            get { return new ObservableCollection<IAccommodation>(Accommodations.OfType<Hotel>()); }
        }


        public AccommodationViewModel()
        {

            Accommodations = new ObservableCollection<IAccommodation>();

            // Create instances of the House and its derived classes
            var house = new House(1, 250.0);
            var spaciousFamilyHouse = new House.SpaciousFamilyHouse(2, 200.0);
            var cozyFamilyHouse = new House.CozyFamilyHouse(3, 180.0);

            // Add them to the ObservableCollection
            Accommodations.Add(house);
            Accommodations.Add(spaciousFamilyHouse);
            Accommodations.Add(cozyFamilyHouse);

            // Create instances of the Hotel and its derived classes
            var hotel = new Hotel(4, 250.0);
            var standardRoom = new Hotel.StandardRoom(5, 300.0);
            var deluxeRoom = new Hotel.DeluxeRoom(6, 350.0);
            var presidentialSuite = new Hotel.PresidentialSuite(7, 500.0);

            // Add them to the ObservableCollection
            Accommodations.Add(hotel);
            Accommodations.Add(standardRoom);
            Accommodations.Add(deluxeRoom);
            Accommodations.Add(presidentialSuite);

            // Create instances of the Flat and its derived classes
            var flat = new Flat(8, 120.0);
            var oneBedRoom = new Flat.OneBedRoom(9, 150.0);
            var twoBedRoom = new Flat.TwoBedRoom(10, 180.0);
            var threeBedRoom = new Flat.ThreeBedRoom(11, 220.0);

            // Add them to the ObservableCollection
            Accommodations.Add(flat);
            Accommodations.Add(oneBedRoom);
            Accommodations.Add(twoBedRoom);
            Accommodations.Add(threeBedRoom);

        }


        private ICommand _bookCommand;

        public ICommand BookCommand
        {
            get
            {
                _bookCommand ??= new RelayCommand(async _ => await ExecuteBookCommand());
                return _bookCommand;
            }
        }

        private async Task ExecuteBookCommand()
        {
            await Task.Delay(1000);

            // Get the selected property
            IAccommodation selectedAccommodation = GetSelectedAccommodation();

            // Open the StartBookingPage.xaml window
            AddBooking addBooking = new AddBooking();
            addBooking.Show();

            // Populate BookingHistories table
            PopulateBookingHistories(selectedAccommodation);
        }

        private IAccommodation _selectedAccommodation;

        public IAccommodation SelectedAccommodation
        {
            get { return _selectedAccommodation; }
            set
            {
                if (_selectedAccommodation != value)
                {
                    _selectedAccommodation = value;
                    OnPropertyChanged(nameof(SelectedAccommodation));
                }
            }
        }



        private void PopulateBookingHistories(IAccommodation selectedAccommodation)
        {
            using (var dbContext = new BookingDbContext())
            {
                BookingHistory bookingHistory = null;  // Declare bookingHistory outside the if block

                // Assume TypeName and RoomType are specific to BookingHistory
                if (selectedAccommodation is BookingHistory)
                {
                    bookingHistory = (BookingHistory)selectedAccommodation;
                    bookingHistory.TypeName = "YourTypeName"; // Replace with the actual value for TypeName
                    bookingHistory.RoomType = "YourRoomType"; // Replace with the actual value for RoomType
                }

                // Check if bookingHistory is not null before accessing its properties
                if (bookingHistory != null)
                {
                    // Set common properties from IAccommodation
                    bookingHistory.Price = selectedAccommodation.Price;
                    bookingHistory.Amenities = selectedAccommodation.Amenities;

                    dbContext.BookingHistories.Add(bookingHistory);
                    dbContext.SaveChanges();
                }
                else
                {
                    // Handle the case where selectedAccommodation is not of type BookingHistory
                    // You might log an error, throw an exception, or handle it as appropriate for your application.
                }
            }
        }

        private IAccommodation GetSelectedAccommodation()
        {
            return SelectedAccommodation;
        }
    }
}

