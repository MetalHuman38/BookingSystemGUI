namespace BookingSystem
{
    /// <summary>
    /// Represents a user in the booking system.
    /// Contains user-specific information such as user ID and name.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// Name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor for creating a new user.
        /// </summary>
        /// <param name="userId">Unique identifier for the user.</param>
        /// <param name="name">Name of the user.</param>
        public User(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}
