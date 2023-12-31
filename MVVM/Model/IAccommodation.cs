namespace BookingSystem.MVVM.Model
{
    public interface IAccommodation
    {
        int BookingID { get; set; }
        double Price { get; set; }

        List<string> Amenities { get; }

        void Print();
        double CalculateTotalPrice(int numberOfNights);
    }
}
