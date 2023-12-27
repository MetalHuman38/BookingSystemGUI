namespace BookingSystem.BookingSystemClasses
{
    /// <summary>
    /// Abstract base class representing a general accommodation.
    /// It provides common properties and methods for all accommodation types.
    /// </summary>
    public abstract class AccommodationBaseClass
    {

        // Properties
        public int BookingID { get; set; }

        public double Price { get; set; }

        public List<string> Amenities { get; }

        public string TypeName => GetType().Name;


        /// <summary>
        /// Constructor for the accommodation class.
        /// </summary>
        /// <param name="bookingID">Unique identifier for the booking.</param>
        /// <param name="price">Price per night for the accommodation.</param>
        public AccommodationBaseClass(int bookingID, double price)
        {
            BookingID = bookingID;
            Price = price;
            Amenities = new List<string>();
        }


        /// <summary>
        /// Prints details of the accommodation including its amenities.
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"- Accommodation Type: {GetType().Name}");
            Console.WriteLine($"- Booking ID: {BookingID}");
            Console.WriteLine("Amenities:");
            foreach (string amenity in Amenities)
            {
                Console.WriteLine($"{amenity}");
            }
            Console.WriteLine($"- Price Per Night: {Price:C}");
        }

        /// <summary>
        /// Calculates the total price for a given number of nights.
        /// Applies a discount for stays longer than 7 nights.
        /// </summary>
        /// <param name="numberOfNights">The number of nights for the booking.</param>
        /// <returns>The total cost for the stay.</returns>
        public double CalculateTotalPrice(int numberOfNights)
        {
            double totalCost = Price * numberOfNights;

            if (numberOfNights > 7)
            {
                double discountPercentage = 0.10; // 10% discount, for example
                totalCost -= totalCost * discountPercentage;
            }

            return totalCost;


        }
    }

}
