namespace BookingSystem
{
    /// <summary>
    /// Represents a Hotel as a type of accommodation.
    /// </summary>
    public class Hotel : AccommodationBaseClass
    {

        /// <summary>
        /// Constructor for creating a new Hotel.
        /// </summary>
        /// <param name="bookingID">Unique identifier for the booking.</param>
        /// <param name="price">Price per night for the Hotel.</param
        public Hotel(int bookingID, double price)
                     : base(bookingID, price)
        {
        }

        // Prints the common details of the Hotel
        public override void Print() => base.Print();

        public class StandardRoom : Hotel
        {
            /// <summary>
            /// Represents a Standard Room with specific amenities.
            /// </summary>
            public StandardRoom(int bookingID, double price)
                                : base(bookingID, price)
            {
                // Adding specific amenities for a Standard Room
                Amenities.Add("- Coffee Machine");
                Amenities.Add("- Desk (Work-Space)");
                Amenities.Add("- Free WiFi");
                Amenities.Add("- Gym");
            }

            public override void Print()
            {
                // Prints the details including specific amenities
                base.Print();
            }
        }

        public class DeluxeRoom : Hotel
        {
            /// <summary>
            /// Represents a Deluxe Room with specific amenities.
            /// </summary>
            public DeluxeRoom(int bookingID, double price)
                             : base(bookingID, price)
            {
                // Adding specific amenities for a Deluxe Room
                Amenities.Add("- Mini-Bar");
                Amenities.Add("- City View");
                Amenities.Add("- Free WiFi");
                Amenities.Add("- Gym");

            }

            public override void Print()
            {
                // Prints the details including specific amenities
                base.Print();
            }
        }

        public class PresidentialSuite : Hotel
        {
            /// <summary>
            /// Represents a Presidential Suite with specific amenities.
            /// </summary>
            public PresidentialSuite(int bookingID, double price)
                                     : base(bookingID, price)

            {
                // Adding specific amenities for a Presidential Suite
                Amenities.Add("- Desk (Work-Space)");
                Amenities.Add("- Spa");
                Amenities.Add("- Private Pool");
                Amenities.Add("- Free WiFi");
                Amenities.Add("- Phone (Direct Dialing Capability)");
                Amenities.Add("- Gym");

            }

            public override void Print()
            {
                // Prints the details including specific amenities
                base.Print();
            }
        }


    }
}
