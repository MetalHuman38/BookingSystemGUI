namespace BookingSystem
{
    /// <summary>
    /// Represents a flat as a type of accommodation.
    /// </summary>
    public class Flat : AccommodationBaseClass
    {
        /// <summary>
        /// Constructor for creating a new flat.
        /// </summary>
        /// <param name="bookingID">Unique identifier for the booking.</param>
        /// <param name="price">Price per night for the flat.</param
        public Flat(int bookingID, double price) : base(bookingID, price) { }

        public override void Print()
        {
            // Prints the common details of the flat
            base.Print();
        }

        public class OneBedRoom : Flat
        {
            /// <summary>
            /// Represents a one-bedroom flat with specific amenities.
            /// </summary>
            public OneBedRoom(int bookingID, double price) : base(bookingID, price)

            {
                // Adding specific amenities for a one-bedroom flat
                Amenities.Add("- City View");
                Amenities.Add("- Gym");
                Amenities.Add("- Nearby Supermarkets");

            }

            public override void Print()
            {
                // Prints the details including specific amenities

                base.Print();
            }
        }

        /// <summary>
        /// Represents a two-bedroom flat with additional amenities.
        /// </summary>
        public class TwoBedRoom : Flat
        {

            public TwoBedRoom(int bookingID, double price) : base(bookingID, price)

            {
                // Adding specific amenities for a two-bedroom flat
                Amenities.Add("- Furnished");
                Amenities.Add("- Gym");
                Amenities.Add("- Elevator");
                Amenities.Add("- Nearby Supermarkets");

            }

            public override void Print()
            {
                // Prints the details including specific amenities
                base.Print();
            }
        }


        /// <summary>
        /// Represents a three-bedroom flat with a comprehensive list of amenities.
        /// </summary>
        public class ThreeBedRoom : Flat
        {
            public ThreeBedRoom(int bookingID, double price) : base(bookingID, price)
            {
                // Adding specific amenities for a three-bedroom flat
                Amenities.Add("- City View");
                Amenities.Add("- Fully Furnished");
                Amenities.Add("- Gym");
                Amenities.Add("- Nearby Supermarkets");
                Amenities.Add("- Elevator Access");

            }

            public override void Print()
            {
                // Prints the details including specific amenities
                base.Print();
            }
        }
    }
}
