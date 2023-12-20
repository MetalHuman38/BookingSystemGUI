namespace BookingSystem
{

    /// <summary>
    /// Manages booking operations for accommodations.
    /// Implemented as a Singleton to ensure a single instance manages all bookings.
    /// </summary>
    public class BookingManager
    {
        // Singleton instance of the BookingManager
        private static BookingManager? _instance;

        // Dictionary to track bookings: Accommodation as key and UserId (nullable) as value
        private Dictionary<AccommodationBaseClass, int?> _bookings;


        /// <summary>
        /// Private constructor for the BookingManager, initializing the bookings dictionary.
        /// </summary>
        private BookingManager()
        {
            _bookings = new Dictionary<AccommodationBaseClass, int?>();
        }



        /// <summary>
        /// Provides access to the singleton instance of the BookingManager.
        /// </summary>
        /// <returns>The singleton instance of BookingManager.</returns>
        public static BookingManager GetInstance()
        {
            //Using compound assignment
            _instance ??= new BookingManager();
            return _instance;
        }


        /// <summary>
        /// Adds an accommodation to the booking management system.
        /// </summary>
        /// <param name="accommodation">The accommodation to be added.</param>
        public void AddAccommodation(AccommodationBaseClass accommodation)
        {
            if (!_bookings.ContainsKey(accommodation))
            {
                _bookings[accommodation] = null;
            }
        }


        /// <summary>
        /// Attempts to book an accommodation for a user.
        /// </summary>
        /// <param name="accommodation">The accommodation to be booked.</param>
        /// <param name="user">The user who is booking the accommodation.</param>
        /// <returns>True if booking is successful; false otherwise.</returns>
        public bool BookAccommodation(AccommodationBaseClass accommodation, User user)
        {
            if (_bookings.TryGetValue(accommodation, out var currentUserId))
            {
                if (currentUserId == null)
                {
                    _bookings[accommodation] = user.UserId;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Releases a previously booked accommodation, making it available for booking again.
        /// </summary>
        /// <param name="accommodation">The accommodation to be released.</param>
        public void ReleaseAccommodation(AccommodationBaseClass accommodation)
        {
            if (_bookings.ContainsKey(accommodation))
            {
                _bookings[accommodation] = null;
            }
        }
    }
}
