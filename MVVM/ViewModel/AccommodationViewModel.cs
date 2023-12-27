using BookingSystem.BookingSystemClasses;
using BookingSystem.Core;
using BookingSystem.MVVM.Model;
using System.Collections.ObjectModel;

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

    }
}
