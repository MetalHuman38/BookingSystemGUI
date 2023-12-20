namespace BookingSystem
{
    /// <summary>
    /// Manages and schedules maintenance and cleaning tasks for accommodations.
    /// </summary>
    public class MaintenanceScheduler
    {
        // List to track all maintenance requests
        private List<MaintenanceRequest> maintenanceRequests;

        // List to track all cleaning requests
        private List<CleaningRequest> cleaningRequests;


        /// <summary>
        /// Constructor for initializing the maintenance and cleaning request lists.
        /// </summary>
        public MaintenanceScheduler()
        {
            maintenanceRequests = new List<MaintenanceRequest>();
            cleaningRequests = new List<CleaningRequest>();
        }

        /// <summary>
        /// Schedules a maintenance task for an accommodation.
        /// </summary>
        /// <param name="maintenanceRequest">The maintenance request to be scheduled.</param>
        public void ScheduleMainteanance(MaintenanceRequest maintenanceRequest)
        {
            maintenanceRequests.Add(maintenanceRequest);
        }

        /// <summary>
        /// Schedules a cleaning task for an accommodation.
        /// </summary>
        /// <param name="request">The cleaning request to be scheduled.</param>
        public void ScheduleCleaning(CleaningRequest request)
        {
            cleaningRequests.Add(request);
            Console.WriteLine($"Cleaning scheduled for {request.Accommodation.GetType().Name} on\n{request.ScheduleDate.ToShortDateString()} (Deep Cleaning: {request.IsDeepCleaning})");
        }

        /// <summary>
        /// Schedules multiple cleaning tasks at once.
        /// </summary>
        /// <param name="requests">A list of cleaning requests to be scheduled.</param>
        public void ScheduleMultipleCleanings(List<CleaningRequest> requests)
        {
            foreach (var request in requests)
            {
                ScheduleCleaning(request);
            }
        }
    }

}
