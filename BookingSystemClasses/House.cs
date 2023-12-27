using BookingSystem.MVVM.Model;

namespace BookingSystem.BookingSystemClasses
{
    /// <summary>
    /// Represents a House as a type of accommodation.
    /// </summary>
    public class House : AccommodationBaseClass, IAccommodation
    {
        /// <summary>
        /// Constructor for creating a new House.
        /// </summary>
        /// <param name="bookingID">Unique identifier for the booking.</param>
        /// <param name="price">Price per night for the House.</param
        public House(int bookingID, double price)
                     : base(bookingID, price) { }

        public override void Print()
        {
            // Prints the details including specific amenities
            //Console.WriteLine($"- Accommodation Type: {GetType().Name}");
            base.Print();
        }

        public class SpaciousFamilyHouse : House
        {
            /// <summary>
            /// Represents a Type of house with specific amenities.
            /// </summary>
            public SpaciousFamilyHouse(int bookingID, double price)
                                       : base(bookingID, price)
            {
                // Adding specific amenities for a Spacious Family House
                Amenities.Add("- Large backyard");
                Amenities.Add("- Swimming pool");

            }

            public override void Print()
            {
                // Prints the details including specific amenities
                Console.WriteLine($"- Accommodation Type: {GetType().Name}");
                base.Print();
            }
        }

        public class CozyFamilyHouse : House
        {
            /// <summary>
            /// Represents a Type of house with specific amenities.
            /// </summary>
            public CozyFamilyHouse(int bookingID, double price)
                                   : base(bookingID, price)
            {
                // Adding specific amenities for a Cozy Family House
                Amenities.Add("- Fireplace");
                Amenities.Add("- Garden view");
            }

            public override void Print()
            {
                // Prints the details including specific amenities
                Console.WriteLine($"- Accommodation Type: {GetType().Name}");
                base.Print();
            }
        }
    }
}
