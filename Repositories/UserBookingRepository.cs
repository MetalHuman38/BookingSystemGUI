using BookingSystem.MVVM.Model;
using System.Data;
using System.Data.SqlClient;

namespace BookingSystem.Repositories
{
    public class UserBookingRepository : RepositoryBaseClass, IUserBookingRepository
    {
        public void AddBooking(BookingModel booking)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                // Assuming your UserBooking table columns match the properties of BookingModel
                string query = "INSERT INTO [UserBooking] (BookingId, GuestName, AccommodationType, BookingDate, NumberOfNights, TotalPrice) " +
                            "VALUES (@BookingId, @GuestName, @AccommodationType, @BookingDate, @NumberOfNights, @TotalPrice)";

                using SqlCommand command = new(query, connection);

                command.Parameters.Add("@BookingId", SqlDbType.Int).Value = booking.BookingId;
                command.Parameters.Add("@GuestName", SqlDbType.NVarChar).Value = booking.GuestName;
                command.Parameters.Add("@AccommodationType", SqlDbType.NVarChar).Value = booking.AccommodationType;
                command.Parameters.Add("@BookingDate", SqlDbType.DateTime).Value = booking.BookingDate;
                command.Parameters.Add("@NumberOfNights", SqlDbType.Int).Value = booking.NumberOfNights;
                command.Parameters.Add("@TotalPrice", SqlDbType.Decimal).Value = booking.TotalPrice;

                _ = command.ExecuteNonQuery();
            }
        }

        public void EditBooking(BookingModel bookingModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookingModel> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public BookingModel GetBookingById(int bookingId)
        {
            throw new NotImplementedException();
        }

        public void RemoveBooking(int bookingId)
        {
            throw new NotImplementedException();
        }
    }
}
