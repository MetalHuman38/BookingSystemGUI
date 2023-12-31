using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.MVVM.Model
{
    public class BookingHistory : IAccommodation
    {
        [Key] // Specify that BookingId is the primary key

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingID { get; set; }
        public double Price { get; set; }
        public List<string>? Amenities { get; set; }

        // Additional properties specific to BookingHistory
        public string TypeName { get; set; }
        public string RoomType { get; set; }

        // Methods from IAccommodation
        public void Print()
        {
            // Implementation
        }

        public double CalculateTotalPrice(int numberOfNights)
        {
            // Implementation
            return 0;
        }
    }
}
