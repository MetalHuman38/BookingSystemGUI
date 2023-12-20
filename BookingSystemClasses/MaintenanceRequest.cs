namespace BookingSystem
{
    /// <summary>
    /// Represents a request for maintenance of an accommodation.
    /// Contains details about the scheduled date for maintenance and a description of the maintenance task.
    /// </summary>
    public class MaintenanceRequest
    {
        /// <summary>
        /// The date on which the maintenance is scheduled.
        /// </summary>
        public DateTime ScheduleDate { get; set; }

        /// <summary>
        /// A brief description of the maintenance task to be performed.
        /// </summary>
        public string Description { get; set; }
    }
}
