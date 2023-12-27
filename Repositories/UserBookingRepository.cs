using BookingSystem.MVVM.Model;
using System.Data.SqlClient;

namespace BookingSystem.Repositories
{
    public class UserBookingRepository : RepositoryBaseClass
    {
        public void AddBooking(BookingModel booking)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                // Assuming your UserBooking table columns match the properties of BookingModel
                var query = "INSERT INTO UserBooking (UserId, GuestName, AccommodationType, BookingDate, NumberOfNights, TotalPrice) VALUES (@UserId, @GuestName, @AccommodationType, @BookingDate, @NumberOfNights, @TotalPrice)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", booking.UserId);
                    command.Parameters.AddWithValue("@GuestName", booking.GuestName);
                    command.Parameters.AddWithValue("@AccommodationType", booking.AccommodationType);
                    command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                    command.Parameters.AddWithValue("@NumberOfNights", booking.NumberOfNights);
                    command.Parameters.AddWithValue("@TotalPrice", booking.TotalPrice);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
