using BookingSystem.MVVM.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                string query = "INSERT INTO [UserBooking] (BookingId, GuestName, AccommodationType, CheckIN, CheckOut, NumberOfNights, TotalPrice) " +
                            "VALUES (@BookingId, @GuestName, @AccommodationType, @CheckIN, @CheckOut, @NumberOfNights, @TotalPrice)";

                using SqlCommand command = new(query, connection);

                command.Parameters.Add("@BookingId", SqlDbType.Int).Value = booking.BookingId;
                command.Parameters.Add("@GuestName", SqlDbType.NVarChar).Value = booking.GuestName;
                command.Parameters.Add("@AccommodationType", SqlDbType.NVarChar).Value = booking.AccommodationType;
                command.Parameters.Add("@CheckIN", SqlDbType.DateTime).Value = booking.CheckIN;
                command.Parameters.Add("@CheckOut", SqlDbType.DateTime).Value = booking.CheckOut;
                command.Parameters.Add("@NumberOfNights", SqlDbType.Int).Value = booking.NumberOfNights;
                command.Parameters.Add("@TotalPrice", SqlDbType.Decimal).Value = booking.TotalPrice;

                _ = command.ExecuteNonQuery();

                // Show success message
                _ = MessageBox.Show("Booking added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void EditBooking(BookingModel bookingModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookingModel> GetAllBookings()
        {
            List<BookingModel> bookings = new List<BookingModel>();

            using (var connection = GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM [UserBooking]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookingModel booking = new BookingModel
                            {
                                BookingId = (int)reader["BookingId"],
                                GuestName = (string)reader["GuestName"],
                                AccommodationType = (string)reader["AccommodationType"],
                                CheckIN = (DateTime)reader["CheckIN"],
                                CheckOut = (DateTime)reader["CheckOut"],
                                NumberOfNights = (int)reader["NumberOfNights"],
                                TotalPrice = (decimal)reader["TotalPrice"]
                                // Add other properties as needed
                            };

                            bookings.Add(booking);
                        }
                    }
                }
            }
            return bookings;
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
