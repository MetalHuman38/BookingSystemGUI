namespace BookingSystem
{
    /// <summary>
    /// Represents a request for cleaning an accommodation.
    /// Contains information about the accommodation, the scheduled date for cleaning, 
    /// and whether it is a deep cleaning.
    /// </summary>
    public class CleaningRequest
    {
        /// <summary>
        /// The accommodation for which the cleaning is requested.
        /// </summary>
        public AccommodationBaseClass Accommodation { get; set; }

        /// <summary>
        /// The date on which the cleaning is scheduled.
        /// </summary>
        public DateTime ScheduleDate { get; set; }

        /// <summary>
        /// Indicates whether the cleaning is a standard or deep cleaning.
        /// </summary>
        public bool IsDeepCleaning { get; set; }
    }
}
