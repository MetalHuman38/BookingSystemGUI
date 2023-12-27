using BookingSystem.BookingSystemClasses;

namespace BookingSystem
{
    /// <summary>
    /// Represents a booking in the booking system.
    /// Contains details about the accommodation, number of nights, the user who booked, and the total price.
    /// </summary>
    public class Bookings
    {
        // Properties
        public AccommodationBaseClass Accommodation { get; set; }
        public int NumberOfNights { get; set; }
        public double TotalPrice { get; private set; }

        public DateTime BookingDate { get; set; }
        public User BookedBy { get; set; }

        /// <summary>
        /// Constructor for creating a new booking.
        /// </summary>
        /// <param name="accommodation">The accommodation being booked.</param>
        /// <param name="numberOfNights">The number of nights for the booking.</param>
        /// <param name="bookedBy">The user who is making the booking.</param>
        public Bookings(AccommodationBaseClass accommodation, int numberOfNights, User bookedBy)
        {
            Accommodation = accommodation;
            NumberOfNights = numberOfNights;
            BookedBy = bookedBy;
            BookingDate = DateTime.Now; // Assuming booking date is the current date
            TotalPrice = accommodation.CalculateTotalPrice(numberOfNights);

        }

        /// <summary>
        /// Prints the details of the booking to the console.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine($"Booking Details:");
            //Console.WriteLine($"- Accommodation: {Accommodation.GetType().Name}");
            //Console.WriteLine($"- Booking ID: {Accommodation.BookingID}"); // Accessing BookingID from Accommodation
            Console.WriteLine($"- Booked By: {BookedBy.Name}");
            Console.WriteLine($"- Number of Nights: {NumberOfNights}");
            Console.WriteLine($"- Booking Date: {BookingDate.ToShortDateString()}");
            Accommodation.Print();
        }
    }
}
