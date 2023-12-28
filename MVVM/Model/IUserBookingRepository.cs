namespace BookingSystem.MVVM.Model
{
    public interface IUserBookingRepository
    {
        void AddBooking(BookingModel bookingModel);
        void EditBooking(BookingModel bookingModel);
        void RemoveBooking(int bookingId);
        BookingModel GetBookingById(int bookingId);
        IEnumerable<BookingModel> GetAllBookings();
    }
}
